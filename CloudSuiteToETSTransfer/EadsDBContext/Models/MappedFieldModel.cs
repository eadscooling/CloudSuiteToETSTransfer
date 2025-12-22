using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETSWebAPI.EadsDbContext.Models
{
    [Table("MappedField", Schema = "doc")]
    public class MappedFieldModel
    {
        [Key]
        public int Id { get; set; }

        public int DocumentTypeId { get; set; }

        public int FieldId { get; set; }

        public int MappedFieldId { get; set; }
    }
}
