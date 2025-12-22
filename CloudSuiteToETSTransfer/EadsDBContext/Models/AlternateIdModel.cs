using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETSWebAPI.EadsDbContext.Models
{
    [Table("AlternateId", Schema = "dbo")]
    public class AlternateIdModel
    {
        [Key]
        public int AltId { get; set; }
        public int EntityId { get; set; }   
        public string EntityType { get; set; }
    }
}
