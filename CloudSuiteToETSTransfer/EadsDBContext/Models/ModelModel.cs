using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using System.Xml.Serialization;

namespace ETSWebAPI.EadsDbContext.Models
{
    [Table("Model",Schema="dbo")]
    public class ModelModel
    {
        //public ModelModel()
        //{
        //    Assemblies = new HashSet<AssemblyModel>();
        //}

        [Key]
        public int ModelId { get; set; }
        public string ModelName { get; set; }

       // public virtual ICollection<AssemblyModel> Assemblies { get; set; }
    }
}
