using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ETSWebAPI.EadsDbContext.Models
{
    [Table("Manufacturer", Schema = "dbo")]
    public class ManufacturerModel
    {
        //public ManufacturerModel()
        //{
        //    BatchSectionTags = new HashSet<BatchSectionTagModel>();
        //    Facilities = new HashSet<FacilityModel>();
        //}
        [Key]
        public int ManufacturerId { get; set; }
        public string Name { get; set; }

        public bool? ExternalYN { get; set; }

        //public virtual ICollection<BatchSectionTagModel> BatchSectionTags { get; set; }
        //public virtual ICollection<FacilityModel> Facilities { get; set; }
    }
}
