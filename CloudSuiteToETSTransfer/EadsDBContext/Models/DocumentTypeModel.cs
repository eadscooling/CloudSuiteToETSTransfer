using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETSWebAPI.Models
{
    [Table("DocumentType", Schema = "doc")]
    public class DocumentTypeModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
