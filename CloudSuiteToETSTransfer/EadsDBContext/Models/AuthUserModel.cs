using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace ETSWebAPI.EadsDbContext.Models
{
    [Table("AuthUser",Schema ="dbo")]
    public class AuthUserModel
    {
        //public AuthUserModel()
        //{
        //    AppInstanceUsers = new HashSet<AppInstanceUserModel>();
        //    BatchAddedByUsers = new HashSet<BatchModel>();
        //    BatchLastExportedByUsers = new HashSet<BatchModel>();
        //    NBNLogByUsers = new HashSet<NBNLogModel>();
        //}
        [Key]
        public int AuthUserId { get; set; }
        public string? AuthUserInitial { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? EmailAddress { get; set; }
        public string? ISDCode { get; set; }
        public string? PhoneNumber { get; set; }
        public string? AvatarImgUrl { get; set; }
        public string? Permissions { get; set; }

        //public virtual ICollection<AppInstanceUserModel> AppInstanceUsers { get; set; }
        //public virtual ICollection<BatchModel> BatchAddedByUsers { get; set; }
        //public virtual ICollection<BatchModel> BatchLastExportedByUsers { get; set; }
        //public virtual ICollection<NBNLogModel> NBNLogByUsers { get; set; }
    }
}
