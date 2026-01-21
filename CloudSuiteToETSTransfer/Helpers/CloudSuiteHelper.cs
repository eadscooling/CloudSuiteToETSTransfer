
using CloudSuiteToETSTransfer.Classes;
using CloudSuiteToETSTransfer.EadsDbContext;

using ETSWebAPI.EadsDbContext.Models;

//using Microsoft.Agents.Core.HeaderPropagation;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CloudSuiteToETSTransfer.Helpers

{
    public class CloudSuiteHelper
    {
        private string _BaseUrl;
        private string _UserName;
        private string _Password;
        private string _ConfigName;
        private HttpClient _httpClient = new HttpClient();
        private UtilClass util = new UtilClass();


        public CloudSuiteHelper()
        {
            _BaseUrl = AppSettingsUtil.GetKey("CloudSuite", "BaseUrl");
            _UserName = AppSettingsUtil.GetKey("CloudSuite", "UserName");
            _Password = AppSettingsUtil.GetKey("CloudSuite", "Password");
            _ConfigName = AppSettingsUtil.GetKey("CloudSuite", "ConfigName");
        }

        public async Task<string> GetTokenAsync()
        {
            try
            {
                string requestUri = $"{_BaseUrl}/Token/{_ConfigName}/{_UserName}/{_Password}";
                HttpResponseMessage response = await _httpClient.GetAsync(requestUri);
                response.EnsureSuccessStatusCode(); // Throws an exception if the HTTP status code is not 2xx
                string responseBody = await response.Content.ReadAsStringAsync();
                CloudSuiteTokenClass cloudSuiteToken = JsonConvert.DeserializeObject<CloudSuiteTokenClass>(responseBody);

                //task result = cloudSuiteToken.Token as task;
                return cloudSuiteToken.Token;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Request exception: {e.Message}");
                throw; // Re-throw the exception for handling higher up
            }
        }
        public async Task UpdateECSAsync()
        {
            List<MasterScheduleClass> masterSchedule = await GetMasterScheduleAsync();


            using (ECSContext ecsContent = new ECSContext())
            {
                // List<ProductModel> allProducts = ecsContent.Products.ToList();

                var iCT = 0;
                foreach (var schedule in masterSchedule)
                {

                    List<string> routings = schedule.ue_uf_EDS_RoutingID.Split('/').ToList();
                    string location = "";
                    if (routings.Count > 0)
                    {
                        location = routings.Last().Trim();
                    }

                    //allProducts[iCT].DueDate = schedule.CoLineDueDate;
                    //allProducts[iCT].CustomerTag = schedule.CustItem;
                    //allProducts[iCT].Routing = location;

                    //ecsContent.Products.Update(allProducts[iCT]);
                    //ecsContent.SaveChanges();
                    //iCT++;
                    //if(iCT >= allProducts.Count)
                    //{
                    //    break;
                    //}

                    List<ProductModel> products = ecsContent.Products
                        .Where(p => p.SerialNumber == schedule.CoNum)
                        .ToList();
                    foreach (var product in products)
                    {
                        bool updateProduct = false;
                        if (product.DueDate == null || (schedule.CoLineDueDate != null && product.DueDate > schedule.CoLineDueDate))
                        {
                            product.DueDate = schedule.CoLineDueDate;
                            updateProduct = true;
                        }
                        if (product.CustomerTag != schedule.CustItem)
                        {
                            product.CustomerTag = schedule.CustItem;
                            updateProduct = true;
                        }


                        if (location.Length > 0 && location != product.Routing)
                        {
                            product.Routing = location;
                            updateProduct = true;
                        }
                        if (updateProduct)
                        {
                            ecsContent.Products.Update(product);
                            ecsContent.SaveChanges();
                        }
                    }
                }

            }
        }
        public async Task
GetListOfAssembliesOnMasterScheduleAsync()
        {
            List<string> assemblyList = new List<string>();
            try
            {
                var masterSchedule = await GetMasterScheduleAsync();
                var uniqueAssemblies = masterSchedule.Select(ms => ms.CoLineItem).Distinct();
                foreach (var assembly in uniqueAssemblies)
                {
                    var assemblyFullName = assembly;
                    var itemDescription = masterSchedule.FirstOrDefault(ms => ms.CoLineItem == assembly)?.ItemDescription;
                    var model = "";
                    if (itemDescription != null && itemDescription.Length > 0)
                    {
                        var itemDescSplit = itemDescription.Split(',');
                        model = itemDescSplit[0].Trim();

                    }
                    if (model.Length > 0)
                    {
                        assemblyFullName = $"{assembly}, {model}";
                    }
                    var ordersForAssembly = masterSchedule.Where(ms => ms.CoLineItem == assembly).ToList();
                    if (ordersForAssembly.Count > 0)
                    {
                        System.Diagnostics.Debug.WriteLine($"Assembly: {assemblyFullName} ");
                        foreach (var order in ordersForAssembly)
                        {
                            List<string> routings = order.ue_uf_EDS_RoutingID.Split('/').ToList();
                            string location = "";
                            if (routings.Count > 0)
                            {
                                location = routings.Last().Trim();
                            }

                            System.Diagnostics.Debug.WriteLine($"   Order: {order.CoNum} Location: {location}");
                        }
                        System.Diagnostics.Debug.WriteLine("");
                    }
                }
                System.Diagnostics.Debug.WriteLine($"Total Unique Assemblies: {uniqueAssemblies.Count()}");
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Request exception: {e.Message}");
                throw; // Re-throw the exception for handling higher up
            }
        }
        public async Task<List<MasterScheduleClass>> GetMasterScheduleAsync()
        {
            List<MasterScheduleClass> masterScheduleList = new List<MasterScheduleClass>();
            try
            {
                string token = GetTokenAsync().Result;
                string requestUri = $"{_BaseUrl}/load/ue_EDS_MasterSchedule?properties=CoNum,CoLineItem,ItemDescription,CoLineDueDate,CustItem,CustName,OrderDate,ue_uf_EDS_RoutingID,CoStat&filter=CoStat='P'";

                using (var client = new HttpClient())
                {
                    using (var request = new HttpRequestMessage(HttpMethod.Get, requestUri))
                    {
                        client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", token);

                        HttpResponseMessage response = await client.SendAsync(request);
                        string responseBody = response.Content.ReadAsStringAsync().Result;

                        var test = JObject.Parse(responseBody);
                        foreach (var item in test["Items"])
                        {
                            MasterScheduleClass masterScheduleClass = new MasterScheduleClass
                            {
                                CoNum = util.ToStringTrimmed(item["CoNum"]),
                                CoLineDueDate = util.ConvertSLDateStringToDateTime(util.ToStringTrimmed(item["CoLineDueDate"])),
                                CustItem = util.ToStringTrimmed(item["CustItem"]),
                                CustName = util.ToStringTrimmed(item["CustName"]),
                                OrderDate = util.ConvertSLDateStringToDateTime(util.ToStringTrimmed(item["OrderDate"])),
                                CoStat = util.ToStringTrimmed(item["CoStat"]),
                                CoLineItem = util.ToStringTrimmed(item["CoLineItem"]),
                                ItemDescription = util.ToStringTrimmed(item["ItemDescription"]),
                                ue_uf_EDS_RoutingID = util.ToStringTrimmed(item["ue_uf_EDS_RoutingID"])
                            };
                            masterScheduleList.Add(masterScheduleClass);
                        }
                    }
                }

                return masterScheduleList;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Request exception: {e.Message}");
                throw; // Re-throw the exception for handling higher up
            }
        }

    }
}
