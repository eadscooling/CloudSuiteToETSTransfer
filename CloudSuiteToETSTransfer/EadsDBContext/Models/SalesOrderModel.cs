using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using EadsWebAPI.EadsDbContext.Models;

namespace ETSWebAPI.EadsDbContext.Models
{
    [Table("SalesOrder", Schema = "dbo")]
    public class SalesOrderModel
    {
    
        [Key]
        public int SalesOrderId { get; set; }
        public long AltId { get; set; }
        public int OrderTypeEnumId { get; set; }
        public int? SubOrderTypeEnumId { get; set; }
        public int SharepointStatusEnumId { get; set; }
        //public string? PONumber { get; set; }
        public int? AssemblyId { get; set; }
        public string? QuoteNumber { get; set; }
        public string? Message { get; set; }
        public DateTime CreatedTmsp { get; set; }

    }
}
