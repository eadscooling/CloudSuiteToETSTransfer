using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace ETSWebAPI.EadsDbContext.Models
{
    [Table("Location", Schema = "dbo")]
    public class LocationModel
    {
        //public LocationModel()
        //{
        //    Assemblies = new HashSet<AssemblyModel>();
        //}
        [Key]
        public int LocationId { get; set; }
        public string Country { get; set; }

      //  public virtual ICollection<AssemblyModel> Assemblies { get; set; }
    }
}
