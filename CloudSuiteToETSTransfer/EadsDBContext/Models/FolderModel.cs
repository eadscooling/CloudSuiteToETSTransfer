using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETSWebAPI.EadsDbContext.Models
{
    [Table("Folder", Schema = "dbo")]
    public class FolderModel
    {
        
        //public FolderModel()
        //{
        //    Files = new HashSet<FileModel>();
        //}
        [Key]
        public int FolderId { get; set; }
        public string Name { get; set; }
        public int? AppInstanceId { get; set; }
        public string OriginPath { get; set; }
        public string EndPointConnectString { get; set; }
        public string ShareName { get; set; }
        public int? ProcessingServiceId { get; set; }
        public string InputPath { get; set; }
        public string CompletePath { get; set; }
        public string ErrorPath { get; set; }
        public bool? EnabledYn { get; set; }

        //public virtual AppInstanceModel AppInstance { get; set; }
        //public virtual ICollection<FileModel> Files { get; set; }
    }
}
