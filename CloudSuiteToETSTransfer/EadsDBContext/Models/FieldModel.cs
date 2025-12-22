using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETSWebAPI.Models
{
    [Table("Field", Schema = "doc")]
    public class FieldModel
    {
        [Key]
        public int Id { get; set; }
        public int DocumentTypeId { get; set; }
        public int GroupId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Label { get; set; }
        public string SearchLabel { get; set; }
        public int Ord { get; set; }
        public bool Active {get; set; }
        public bool Calculated { get; set; }
    }

}
