using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace ETSWebAPI.EadsDbContext.Models
{
    [Table("File",Schema ="dbo")]
    public class FileModel
    {
        //public FileModel()
        //{
        //    AssemblyDtsfiles = new HashSet<AssemblyModel>();
        //    AssemblySndsosfiles = new HashSet<AssemblyModel>();
        //}
        [Key]
        public int FileId { get; set; }
        public string FileName { get; set; }
        public int? LatestRevision { get; set; }
        public int? DocTypeEnumId { get; set; }
        public string FilePath { get; set; }
        public int? SourceFolderId { get; set; }
        public int StatusEnumId { get; set; }
        public DateTime FileTmsp { get; set; }
        public DateTime SubmittedTmsp { get; set; }
        public DateTime? StartedTmsp { get; set; }
        public DateTime? CompletedTmsp { get; set; }
        public int? RecordsCount { get; set; }
        public int? ErrorsCount { get; set; }
        public int? LastUpdatedByAuthUserId { get; set; }
        public DateTime? LastUpdatedTmsp { get; set; }
        public long AltId { get; set; }
        public string Message { get; set; }

        //public virtual FolderModel SourceFolder { get; set; }
        //public virtual ICollection<AssemblyModel> AssemblyDtsfiles { get; set; }
        //public virtual ICollection<AssemblyModel> AssemblySndsosfiles { get; set; }
    }
}

