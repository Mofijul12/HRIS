﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HRIS_R62.Models.Attendance_Required
{
    public class ShiftEmployee
    {
        [Key]
        [StringLength(50)]
        public string ShiftEmployeeID { get; set; } = default!;

        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        
        [ForeignKey("DateWiseOfficeTime")]
        public string? DateWiseOfficeTimeID { get; set; }
        public virtual DateWiseOfficeTime? DateWiseOfficeTime { get; set; }

    }

}