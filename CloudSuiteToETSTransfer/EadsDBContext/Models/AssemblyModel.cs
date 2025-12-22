//using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.ComponentModel.DataAnnotations;
using static System.Collections.Specialized.BitVector32;

namespace ETSWebAPI.EadsDbContext.Models
{
    [Table("Assembly", Schema = "dbo")]
    
    public class AssemblyModel
    {
        [Key]
        public int AssemblyId { get; set; }
        public int? ModelId { get; set; }
        public string AssemblyName { get; set; }
        public int? CustomerId { get; set; }
        public string? Ponumber { get; set; }
        public string? QuoteNumber { get; set; }
        public int? SndsosfileId { get; set; }
        public int? DtsfileId { get; set; }
        public DateTime? Dsdate { get; set; }
        public string? CoolerType { get; set; }
        public string? ProposalNumber { get; set; }
        public string? EndUser { get; set; }
        public int? LocationId { get; set; }
        public string? Reference { get; set; }
        public string? OverallSize { get; set; }
        public string? EstWeight { get; set; }
        public string? DriverType { get; set; }
        public decimal? MotorHp { get; set; }
        public int? MotorRpm { get; set; }
        public string? MotorElectrical { get; set; }
        public string? MotorEnclosure { get; set; }
        public decimal? Ambient { get; set; }
        public decimal? Elevation { get; set; }
        public int? NumFans { get; set; }
        public int? FanId { get; set; }
        public int? LastUpdatedByAuthUserId { get; set; }
        public DateTime? LastUpdatedTmsp { get; set; }
        public bool? VBSNotRequired { get; set; }

    }
}
