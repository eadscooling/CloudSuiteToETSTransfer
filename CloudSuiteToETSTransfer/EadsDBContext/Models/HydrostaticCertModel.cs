using static System.Collections.Specialized.BitVector32;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ETSWebAPI.EadsDbContext.Models
{
    [Table("HydrostaticCert", Schema = "dbo")]
    public class HydrostaticCertModel
    {

        //public HydrostaticCert()
        //{
        //}
        [Key]
        public int HydrostaticCertId { get; set; }
        public int? TestGauge1Id { get; set; }
        public int? TestGauge2Id { get; set; }
        public int? TestDurationMinutes { get; set; }
        public string? CustomerRep { get; set; }
        public DateTime? CustomerDate { get; set; }
        public string? CompanyRep { get; set; }
        public DateTime? CompanyDate { get; set; }
        public int BatchId { get; set; }
        public int ProductId { get; set; }
        public int SectionId { get; set; }
        public int? ManufacturerId { get; set; }
        public int? Year { get; set; }
        public int? NBN { get; set; }
        public string? Misc { get; set; }
        public bool CombinedYN { get; set; }
        public string? SerialNumber { get; set; }
        public string? Service { get; set; }
        public decimal? HydroPressure { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CalibrationDate1 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CalibrationDate2 { get; set; }

        //public virtual BatchModel Batch { get; set; }
        //public virtual ManufacturerModel? Manufacturer { get; set; }
        //public virtual ProductModel Product { get; set; }
        //public virtual SectionModel Section { get; set; }
        //public virtual GaugeCalibrationDateModel TestGauge1 { get; set; }
        //public virtual GaugeCalibrationDateModel TestGauge2 { get; set; }
    }
}
