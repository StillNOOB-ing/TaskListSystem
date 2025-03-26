﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskListSystem.Database.Model
{
    [Table("DailyTask")]
    public partial class TDailyTask : BaseTable<TDailyTask>
    {        
        [StringLength(50)] public string? ReportByID { get; set; }
        public DateTime? ReportedOn { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Remark { get; set; }
        public int? PICID { get; set; }
        public string? PICName { get; set; }
        public int? StatusID { get; set; }
        public string? StatusName { get; set; }
        public int? TypeID { get; set; }
        public string? TypeName { get; set; }
        public DateTime? CompletedOn { get; set; }
        [NotMapped] public string? color { get; set; }
    }
}
