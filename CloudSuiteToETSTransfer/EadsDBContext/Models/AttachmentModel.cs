using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ETSWebAPI.EadsDbContext.Models
{
    [Table("Attachment", Schema = "dbo")]
    public class AttachmentModel
    {
        [Key]
        public int AttachmentId { get; set; }
        public long? ParentAltId { get; set; }
        public int? AttachmentTypeEnumId { get; set; }
        public DateTime? FileTimestamp { get; set; }
        public long? FileSize { get; set; }
        public string? Path { get; set; }
        public string? FileName { get; set; }
        public string? ThumbPath { get; set; }
        public string? GUID { get; set; }
        public bool? DefaultYN { get; set; }
        public int? AuthUserId { get; set; }
        public string? Description { get; set; }
    }
}
