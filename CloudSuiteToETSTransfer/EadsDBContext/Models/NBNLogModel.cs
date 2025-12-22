using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace ETSWebAPI.EadsDbContext.Models
{
    [Table("NBNLog",Schema="dbo")]
    public class NBNLogModel
    {
        [Key]
        public int NBNLogId { get; set; }
        public int NBN { get; set; }
        public int FacilityId { get; set; }
        public DateTime? UpdatedTmsp { get; set; }
        public int? UpdatedByAuthUserId { get; set; }
       // public virtual FacilityModel Facility { get; set; }
       //public virtual AuthUserModel UpdatedByAuthUser { get; set; }
    }
}
