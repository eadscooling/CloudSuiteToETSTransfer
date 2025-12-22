using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Collections.Specialized.BitVector32;

namespace ETSWebAPI.EadsDbContext.Models
{
    [Table("SectionInspection", Schema = "dbo")]
    public class SectionInspectionModel
    {
        [Key]
        public int SectionInspectionId { get; set; }
        public int SectionId { get; set; }
        public int? InspectionEnumId { get; set; }

      //  public virtual Section Section { get; set; }
    }
}
