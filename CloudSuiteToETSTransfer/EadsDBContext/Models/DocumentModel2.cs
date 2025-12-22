using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic;

namespace ETSWebAPI.EadsDbContext.Models
{
    [Table("Document", Schema = "doc")]
    public class DocumentModel2
    {

        [Key]
        public int Id { get; set; }

        public int AssemblyId { get; set; }

        public int SalesOrderId { get; set; }

        public int AttachmentId { get; set; }

        public string FileName { get; set; }
        public int DocumentTypeId { get; set; }

        public DateTime CreatedDateTime { get; set; }
        public string? CreatedBy { get; set; }

    }
}
