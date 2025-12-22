using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETSWebAPI.EadsDbContext.Models
{
    [Table("AppInstanceUser", Schema = "dbo")]
    public class AppInstanceUserModel
    {
        [Key]
        public int AppInstanceUserId { get; set; }
        public int AppInstanceId { get; set; }
        public int AuthUserId { get; set; }
        public bool EnabledYn { get; set; }

        //public virtual AppInstanceModel AppInstance { get; set; }
        //public virtual AuthUserModel AuthUser { get; set; }
    }
}
