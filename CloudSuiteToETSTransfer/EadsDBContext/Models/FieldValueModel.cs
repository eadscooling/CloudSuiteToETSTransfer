using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETSWebAPI.Models
{
    [Table("FieldValue", Schema = "doc")]
    public class FieldValueModel
    {
        [Key]
        public int Id { get; set; }
        public int AssemblyId { get; set; }
        public int FieldId { get; set; }
        public string Value { get; set; }
        public int Series { get; set; }
        public int? DocumentId { get; set; }
        public string ? CreatedBy { get; set; }
        public string ? ModifiedBy { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public DateTime? ModifiedDateTime { get; set; }


    }
}
