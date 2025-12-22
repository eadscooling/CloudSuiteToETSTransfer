using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace ETSWebAPI.EadsDbContext.Models
{
    [Table("Product", Schema = "dbo")]
    public class ProductModel
    {
        //public ProductModel()
        //{
        //    BatchProducts = new HashSet<BatchProductModel>();
        //    BatchSectionTags = new HashSet<BatchSectionTagModel>();
        //}
        [Key]
        public int ProductId { get; set; }
        public int? AssemblyId { get; set; }
        public int? FacilityId { get; set; }
        public string? SerialNumber { get; set; }
        public string? PONumber { get; set; }
        public string? CustomerTag { get; set; }
        public string? PaintTint { get; set; }
        public string? PaintName { get; set; }
        public bool? ActiveYn { get; set; }
        public int? QuoteId { get; set; }
        public int? LastUpdatedByAuthUserId { get; set; }
        public DateTime? LastUpdatedTmsp { get; set; }
        public int? OrderId { get; set; }
        public long? AltId { get; set; } 
        public int? PurchaseOrderId { get; set; }
        public DateTime? DueDate { get; set; }
        public string? Routing { get; set; }


        }
}
