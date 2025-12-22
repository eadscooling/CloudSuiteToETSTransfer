using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace ETSWebAPI.EadsDbContext.Models
{
    [Table("Section", Schema = "dbo")]
    public class SectionModel
    {
        //public SectionModel()
        //{
        //    BatchSectionTags = new HashSet<BatchSectionTagModel>();
        //    SectionInspections = new HashSet<SectionInspectionModel>();
        //}
        [Key]
        public int SectionId { get; set; }
        public int AssemblyId { get; set; }
        public int SeqNumber { get; set; }
        public string SectionName { get; set; }
        public string Service { get; set; }
        public bool CombinedYn { get; set; }
        public decimal? DesignTempMax { get; set; }
        public decimal? DesignTempMin { get; set; }
        public decimal? DesignPressure { get; set; }
        public decimal? DesignTempDual { get; set; }
        public decimal? DesignPressureDual { get; set; }
        public decimal? HydroPressure { get; set; }
        public decimal? HydroMultiplier { get; set; }
        public string PassArrangement { get; set; }
        public int? Rows { get; set; }
        public int? Passes { get; set; }
        public decimal? TubeOuterDiameter { get; set; }
        public int? TubeGuage { get; set; }
        public string TubeGuageType { get; set; }
        public string TubeMaterial { get; set; }
        public int? NumTubes { get; set; }
        public int? TubeLength { get; set; }
        public string? Turbulators { get; set; }
        public int? Accelerators { get; set; }
        public int? NozzleRating { get; set; }
        public string NozzleMaterial { get; set; }
        public int? NozzleInletSize { get; set; }
        public int? NozzleInletQty { get; set; }
        public int? NozzleOutletSize { get; set; }
        public int? NozzleOutletQty { get; set; }
        public string HeaderType { get; set; }
        public string HeaderMaterial { get; set; }
        public decimal? Ca { get; set; }
        public bool GroovingYn { get; set; }
        public string PlugType { get; set; }
        public string PlugMaterial { get; set; }
        public bool? Pwhtyn { get; set; }
        public bool? Asmeyn { get; set; }
        public bool? CanadianRegYn { get; set; }
        public bool? Api661yn { get; set; }
        public bool? NaceYn { get; set; }
        public string Louvers { get; set; }
        public bool HailguardYn { get; set; }
        public string Fluid { get; set; }
        public int? Location { get; set; }
        public decimal? ShaftSplit { get; set; }
        public decimal? WrapperSpan { get; set; }
        public decimal? Tpspan { get; set; }
        public decimal? WrapperThickness { get; set; }
        public decimal? Tpthickness { get; set; }
        public decimal? EndPlateThickness { get; set; }
        public decimal? BoxWidth { get; set; }
        public decimal? BoxHeight { get; set; }
        public decimal? BoxLength { get; set; }
        public string? PipeSchedule { get; set; }
        public string PipeMaterial { get; set; }
        public string FlangeMaterial { get; set; }
        public string SideFrameSize { get; set; }
        public string BtmTubeSupport { get; set; }
        public decimal? SftoBtslength { get; set; }
        public decimal? FloatBarThickness { get; set; }
        public decimal? FloatBarWidth { get; set; }
        public decimal? SecLiftLugThickness { get; set; }
        public decimal? SecLiftLugSpacing { get; set; }
        public string? HeaderSupport { get; set; }
        public decimal? TotalSectionDryWeight { get; set; }
        public string RecTube { get; set; }
        public decimal? MinRequiredSf { get; set; }
        public bool? NormalizedPlatReq { get; set; }
        public string PlateImpactTestNote { get; set; }
        public string PipeImpactTestNote { get; set; }
        public string FlangeImpactTestNote { get; set; }
        public string ImpactMinAvgTpwrap { get; set; }
        public string ImpactMinAvgEp { get; set; }
        public string ImpactMinEachTpwrap { get; set; }
        public string ImpactMinEachEp { get; set; }
        public bool PwhtrequiredTf { get; set; }
        public string HeatingNote { get; set; }
        public string HoldNote { get; set; }
        public string CoolingNote { get; set; }
        public decimal? Pitch { get; set; }
        public decimal? Tpthick { get; set; }
        public decimal? Tpwidth { get; set; }
        public decimal? Tplength { get; set; }
        public decimal? WrapThick { get; set; }
        public decimal? WrapWidth { get; set; }
        public decimal? WrapLength { get; set; }
        public decimal? EndThick { get; set; }
        public decimal? EndWidth { get; set; }
        public decimal? EndLength { get; set; }
        public decimal? PassThick { get; set; }
        public decimal? PassWidth { get; set; }
        public decimal? PassLength { get; set; }
        public decimal? PipeLength { get; set; }
        public string Flange { get; set; }
        public string Pipe { get; set; }
        public decimal? EndDrill { get; set; }
        public int? SapcesRndDwn { get; set; }
        public int? SapcesRndUp { get; set; }
        public string? PreHeatNote { get; set; }
        public string FinStripBack { get; set; }
        public decimal? FinHeight { get; set; }
        //public virtual AssemblyModel Assembly { get; set; }
        //public virtual ICollection<BatchSectionTagModel> BatchSectionTags { get; set; }
        //public virtual ICollection<SectionInspectionModel> SectionInspections { get; set; }
    }
}
