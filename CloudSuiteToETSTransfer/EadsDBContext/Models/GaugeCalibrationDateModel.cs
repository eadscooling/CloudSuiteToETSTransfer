using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ETSWebAPI.EadsDbContext.Models
{
    [Table("GaugeCalibrationDate", Schema = "dbo")]
    public class GaugeCalibrationDateModel
    {
        [Key]
        public int GaugeCalibrationDateId { get; set; }

        [Required]
        [StringLength(50)]
        public string Code { get; set; }

        [Column(TypeName = "date")]

        public DateTime? CalibrationDate { get; set; }

        [Required]
        public int AddedByAuthUserId { get; set; }

        [Required]
        public DateTime AddedDate { get; set; }

       // public AuthUserModel AddedByAuthUser { get; set; }
    }
}
