using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ETSWebAPI.EadsDbContext.Models
{
    [Table("PurchaseOrder", Schema = "dbo")]
    public class PurchaseOrderModel
    {
       

        [Key]
        public int PurchaseOrderId { get; set; }
        public long AltId { get; set; }
        public string PoNumber { get; set; }
        public int SalesOrderId { get; set; }

    }
}
