using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETSWebAPI.Models
{
    [Table("Group", Schema = "doc")]
    public class GroupModel
    {
        [Key]
        public int Id { get; set; }
        public int DocumentTypeId { get; set; }
        public string Name { get; set; }
        public int Ord {  get; set; }
        public bool MultipleValues { get; set; }    

    }
}
