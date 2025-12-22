using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using PnP.Framework.Provisioning.Providers.Xml.V201903;

namespace ETSWebAPI.EadsDbContext.Models
{
    [Table("PaintCode", Schema = "dbo")]
    public class PaintColorModel
    {
        [Key]
        public int Id { get; set; }
        public string? TopCoat { get; set; }
        public string? Description { get; set; }
        public string? PaintCode { get; set; }
        public string? Family { get; set; }
        public string? AlternatePaintCode { get; set; }

    }
}
