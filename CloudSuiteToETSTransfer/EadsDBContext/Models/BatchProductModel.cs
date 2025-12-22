using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ETSWebAPI.EadsDbContext.Models
{
    [Table("BatchProduct", Schema = "dbo")]
    public class BatchProductModel
    {
        [Key]
        public int BatchProductId { get; set; }
        public int BatchId { get; set; }
        public int ProductId { get; set; }
        public DateTime Tmsp { get; set; }
        public string CustomerTag { get; set; }


        public virtual BatchModel Batch { get; set; }
        public virtual ProductModel Product { get; set; }
    }
}
