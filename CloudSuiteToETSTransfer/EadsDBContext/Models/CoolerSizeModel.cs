using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETSWebAPI.EadsDbContext.Models
{
    [Table("CoolerSize", Schema = "dbo")]
    public class CoolerSizeModel
    {
        [Key]
        public int Id { get; set; }

        public int FanSize { get; set; }

        public int TotalSectionWidthWSS { get; set; }

        public int TotalSectionWidthWOSS { get; set; }

        public float ShaftHeight { get; set; }

        public float ShaftDia { get; set; }
    }
}
