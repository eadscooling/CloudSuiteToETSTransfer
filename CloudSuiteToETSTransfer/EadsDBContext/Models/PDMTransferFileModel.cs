using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETSWebAPI.EadsDbContext.Models
{
    [Table("PDMTransferFile", Schema = "dbo")]
    public class PDMTransferFileModel
    {

        [Key]
        public int Id { get; set; }


        public int AssemblyId { get; set; }

        public int SalesOrderId { get; set; }

        public int AttachmentId { get; set; }

        public bool TransferredToPDM { get; set; } = false;

        public DateTime? TransferredDataTime { get; set; }
    }
}
