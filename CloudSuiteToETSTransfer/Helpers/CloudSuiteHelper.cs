
using CloudSuiteToETSTransfer.Classes;
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

        public async Task<List<MasterScheduleClass>> GetMasterScheduleAsync()
        {
            List<MasterScheduleClass> masterScheduleList = new List<MasterScheduleClass>();
            try
            {
                string token = GetTokenAsync().Result;
                string requestUri = $"{_BaseUrl}/load/ue_EDS_MasterSchedule?properties=CoNum,CoLineDueDate,CustItem,CustName,OrderDate,ue_uf_EDS_RoutingID,CoStat&filter=CoStat<>'C'";

                using (var client = new HttpClient())
                {
                    using (var request = new HttpRequestMessage(HttpMethod.Get, requestUri))
                    {
                        client.DefaultRequestHeaders.TryAddWithoutValidation ("Authorization", token);

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
