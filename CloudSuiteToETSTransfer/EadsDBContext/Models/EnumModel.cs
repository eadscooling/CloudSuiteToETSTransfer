using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace ETSWebAPI.EadsDbContext.Models

{
    [Table("Enum",Schema="dbo")]
    public class EnumModel
    {
        [Key]
        public int EnumId { get; set; }
        public int EnumGroupId { get; set; }
        public string ShortDesc { get; set; }
        public string Description { get; set; }
        public bool? DefaultItem { get; set; }
        public string Abbr { get; set; }

     //   public virtual EnumGroupModel EnumGroup { get; set; }
    }
}
