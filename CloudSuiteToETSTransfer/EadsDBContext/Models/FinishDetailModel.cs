using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace ETSWebAPI.EadsDbContext.Models
{
    [Table("FinishDetail", Schema = "dbo")]
    public class FinishDetailModel
    {
        [Key]
        public int FinishDetailsId { get; set; }
        public int AssemblyId { get; set; }
        public int FinishTypeEnumId { get; set; }
        public int FinishSystemTypeEnumId { get; set; }
        public int SurfacePrepTypeEnumId { get; set; }
        public int PrimerTypeEnumId { get; set; }
        public int FinishCoatTypeEnumId { get; set; }

      //  public virtual AssemblyModel Assembly { get; set; }
    }
}
