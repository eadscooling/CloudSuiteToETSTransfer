using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETSWebAPI.EadsDbContext.Models
{
    [Table("AppInstance", Schema = "dbo")]
    public class AppInstanceModel
    {
       
        //public AppInstanceModel()
        //{
        //    AppInstanceUsers = new HashSet<AppInstanceUserModel>();
        //    Folders = new HashSet<FolderModel>();
        //}

        [Key]
        public int AppInstanceId { get; set; }
        public string Name { get; set; }
        public string OwnerOrgName { get; set; }
        public int? OwnerOrgId { get; set; }
        public DateTime? LastDataUpdateTmsp { get; set; }
        public int? ApplicationId { get; set; }
        public string ApplicationName { get; set; }
        public int? AppInstanceGroupId { get; set; }
        public string AppInstanceGroupName { get; set; }
        public int? ApplicationGroupId { get; set; }
        public string BillingCode { get; set; }
        public string EventXkey { get; set; }
        public string SurveyKey { get; set; }
        public string TimeZoneName { get; set; }
        public string AzureStorageAccount { get; set; }

        //public virtual ICollection<AppInstanceUserModel> AppInstanceUsers { get; set; }
        //public virtual ICollection<FolderModel> Folders { get; set; }
    }
}
