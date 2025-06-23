using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRIS_R62.Models.Attendance_Required
{
    public class Division
    {
        [Key]
        [StringLength(50)]
        public string DivisionID { get; set; } = default!;

        [Required]
        [StringLength(30)]
        public string DivisionName { get; set; } = default!;

        
        public string DivisionShortName { get; set; } = default!;

        public ICollection<LineInformation> LineInformation { get; set; } = new List<LineInformation>();
    }
}
