using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETSWebAPI.EadsDbContext.Models
{
    [Table("Facility", Schema = "dbo")]
    public class FacilityModel
    {
        //public FacilityModel()
        //{
        //    NBNLogs = new HashSet<NBNLogModel>();
        //    Products = new HashSet<ProductModel>();
        //    BatchSectionTags = new HashSet<BatchSectionTagModel>();
        //}
        [Key]
        public int FacilityId { get; set; }
        public string FacilityName { get; set; }
        public string Address { get; set; }
        public int? Seed { get; set; }
        public int? Increment { get; set; }
        public int? ManufacturerId { get; set; }
        //public virtual ManufacturerModel Manufacturer { get; set; }

        //public virtual ICollection<NBNLogModel> NBNLogs { get; set; }
        //public virtual ICollection<ProductModel> Products { get; set; }
        //public virtual ICollection<BatchSectionTagModel> BatchSectionTags { get; set; }
    }
}
