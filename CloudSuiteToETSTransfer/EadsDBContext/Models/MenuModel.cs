using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EadsWebAPI.EadsDbContext.Models
{

    [Table("Menu", Schema = "dbo")]
    public partial class MenuModel
    {
        [Key]
        public int MenuId { get; set; }

        public string? AccessPath { get; set; }

        public string? DisplayName { get; set; }

        public string? IconClass { get; set; }

        public string? IconLibrary { get; set; }

        public string? Name { get; set; }

        public int? ParentMenuId { get; set; }
        public string? ToolTip { get; set; }
        public int? Ord { get; set; }
        public string? Permissions { get; set; }
        public bool? Active { get; set; }
    }
}

