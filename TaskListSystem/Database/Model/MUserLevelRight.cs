using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskListSystem.Database.Model
{
    [Table("UserLevelRight")]
    public partial class MUserLevelRight : BaseTable<MUserLevelRight>
    {        
        [StringLength(50)] public string? Name { get; set; }

        public string? Description { get; set; }
    }
}
