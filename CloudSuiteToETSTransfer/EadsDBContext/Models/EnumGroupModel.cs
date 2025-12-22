using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETSWebAPI.EadsDbContext.Models
{
    [Table("EnumGroup",Schema ="dbo")]
    public class EnumGroupModel
    {
        //public EnumGroupModel()
        //{
        //    Enums = new HashSet<Enum>();
        //}
        [Key]
        public int EnumGroupId { get; set; }
        public string Description { get; set; }
        public string Identifier { get; set; }

       // public virtual ICollection<Enum> Enums { get; set; }
    }
}
