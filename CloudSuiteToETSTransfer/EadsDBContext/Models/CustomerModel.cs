using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace ETSWebAPI.EadsDbContext.Models
{
    [Table("Customer", Schema = "dbo")]
    public class CustomerModel
    {
        //public CustomerModel()
        //{
        //    Assemblies = new HashSet<Assembly>();
        //}
        [Key]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }

       // public virtual ICollection<Assembly> Assemblies { get; set; }
    }
}
