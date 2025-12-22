using static System.Collections.Specialized.BitVector32;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ETSWebAPI.EadsDbContext.Models
{
    [Table("BatchSection", Schema = "dbo")]
    public class BatchSectionTagModel
    {
        [Key]
        public int BatchSectionTagId { get; set; }
        public int BatchId { get; set; }
        public int ProductId { get; set; }
        public int SectionId { get; set; }
        public int? ManufacturerId { get; set; }
        public int? Year { get; set; }
        public int? Nbn { get; set; }
        public string Misc { get; set; }
        public string? Service { get; set; }
        public bool? CombinedYN { get; set; }
        public string? SerialNumber { get; set; }
        public int? FacilityId { get; set; }
        public DateTime? Tmsp { get; set; }
        public int? LastModifiedByAuthUserId { get; set; }
        public bool? PWHTYN { get; set; }
        //public virtual BatchModel? Batch { get; set; }
        //public virtual ManufacturerModel? Manufacturer { get; set; }
        //public virtual ProductModel? Product { get; set; }
        //public virtual SectionModel? Section { get; set; }
        //public virtual FacilityModel? Facility { get; set; }
    }
}
