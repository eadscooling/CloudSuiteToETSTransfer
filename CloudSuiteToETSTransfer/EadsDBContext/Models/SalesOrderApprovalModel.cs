using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETSWebAPI.EadsDbContext.Models
{
    [Table("SalesOrderApproval", Schema = "dbo")]
    public class SalesOrderApprovalModel
    {
        [Key]
        public int Id { get; set; }

        public int SalesOrderId { get; set; }

        public string? Approver { get; set; }
     
        public DateTime? ApprovedDateTime { get; set; }
        public DateTime? CreateDate { get;set; }
        public DateTime? ModDate { get; set; }
        public bool? Active { get; set; }
        public bool? DTSCalculated { get; set; }
        public bool? ASMEFilesTransferredToPDM { get; set; }
    }
}
