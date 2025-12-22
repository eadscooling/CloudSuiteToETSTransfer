
using CloudSuiteToETSTransfer.Classes;
using CloudSuiteToETSTransfer.EadsDbContext;
using CloudSuiteToETSTransfer.Helpers;
using ETSWebAPI.EadsDbContext.Models;

class Program
{
    static async Task Main(string[] args)
    {
        CloudSuiteHelper cloudSuiteHelper = new CloudSuiteHelper();
        List<MasterScheduleClass> masterSchedule = await cloudSuiteHelper.GetMasterScheduleAsync();
        foreach (var schedule in masterSchedule)
        {
            using (ECSContext ecsContent = new ECSContext())
            {
                List<string> routings = schedule.ue_uf_EDS_RoutingID.Split('/').ToList();
                string location = "";
                if (routings.Count > 0)
                {
                    location = routings.Last().Trim();
                }

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
                    if(product.CustomerTag != schedule.CustItem)
                    {
                        product.CustomerTag = schedule.CustItem;
                        updateProduct = true;
                    }
                   

                    if (location.Length > 0 && location!=product.Routing)
                    {
                        product.Routing= location;
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
}