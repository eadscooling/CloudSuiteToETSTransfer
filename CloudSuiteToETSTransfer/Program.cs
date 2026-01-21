
using CloudSuiteToETSTransfer.Classes;
using CloudSuiteToETSTransfer.EadsDbContext;
using CloudSuiteToETSTransfer.Helpers;
using ETSWebAPI.EadsDbContext.Models;

class Program
{
    static async Task Main(string[] args)
    {
        CloudSuiteHelper cloudSuiteHelper = new CloudSuiteHelper();
       // await cloudSuiteHelper.GetListOfAssembliesOnMasterScheduleAsync();

        await cloudSuiteHelper.UpdateECSAsync();
    }



}