using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace ETSWebAPI.EadsDbContext.Models
{
    [Table("Fan", Schema = "dbo")]
    public class FanModel
    {
        //public FanModel()
        //{
        //    Assemblies = new HashSet<AssemblyModel>();
        //}
        [Key]
        public int FanId { get; set; }
        public string Model { get; set; }
        public int? FanDiameter { get; set; }
        public decimal? FanHp { get; set; }
        public int? FanBlades { get; set; }
        public int? FanRpm { get; set; }
        public string FanSeries { get; set; }
        public decimal? FanPitch { get; set; }
        public int? FanTipSpeed { get; set; }

     //   public virtual ICollection<AssemblyModel> Assemblies { get; set; }
    }
}
