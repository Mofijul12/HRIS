using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HRIS_R62.Models.Attendance_Required
{
    public class ShiftTime
    {
        [Key]
        [StringLength(50)]
        public string ShiftID { get; set; }

        [StringLength(30)]
        public string ShiftName { get; set; } = default!;

        public DateTime ShiftStart { get; set; }

        public DateTime ShiftEnd { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int? ConsideredLunchHour { get; set; }

        public decimal BreakDuration { get; set; }

        [ForeignKey("EmployeeInformation")]
        public string? EmployeeID { get; set; } = default!; 

        public virtual EmployeeInformation? EmployeeInformation { get; set; }
    }
}
