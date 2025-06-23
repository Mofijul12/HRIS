using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HRIS_R62.Models.Attendance_Required
{
    public class OverTime
    {
        [Key]
        [StringLength(50)]
        public string OverTimeID { get; set; }

        public DateTime OTDate { get; set; }

        public TimeOnly OTStartTime { get; set; }
        
        public TimeOnly OTEndTime { get; set; }


        [ForeignKey("EmployeeInformation")]
        public string EmployeeID { get; set; }
        public virtual EmployeeInformation? EmployeeInformation { get; set; }
    }
}
