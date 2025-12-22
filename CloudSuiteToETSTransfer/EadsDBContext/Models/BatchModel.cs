using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace ETSWebAPI.EadsDbContext.Models
{
    [Table("Batch",Schema = "dbo")]
    public class BatchModel
    {
        //public BatchModel()
        //{
        //    BatchProducts = new HashSet<BatchProductModel>();
        //    BatchSectionTags = new HashSet<BatchSectionTagModel>();
        //    HydrostaticCerts = new HashSet<HydrostaticCertModel>();
        //}
        [Key]
        public int BatchId { get; set; }
        public DateTime InitiatedTmsp { get; set; }
        public DateTime? CompletedTmsp { get; set; }
        public int AddedByUserId { get; set; }
        public int? LastExportedByUserId { get; set; }
        public string Name { get; set; }

        public int? AddedByUser { get; set; }
        public int? LastExportedByUser { get; set; }
        //public virtual ICollection<BatchProductModel> BatchProducts { get; set; }
        //public virtual ICollection<BatchSectionTagModel> BatchSectionTags { get; set; }
        //public virtual ICollection<HydrostaticCertModel> HydrostaticCerts { get; set; }
    }
}
