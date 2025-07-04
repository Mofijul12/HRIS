﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HRIS_R62.Models.Attendance_Required
{
    public class LateApproval
    {
        [Key]
        [StringLength(50)]
        public string LateApprovalID { get; set; }
        public DateTime LateDate { get; set; }

        [StringLength(150)]
        public string LateReason { get; set; } = default!;

        [StringLength(50)]
        public string EntryUser { get; set; } = default!;

        [ForeignKey("EmployeeInformation")]
        public string EmployeeID { get; set; } = default!;
        public virtual EmployeeInformation? EmployeeInformation { get; set; }

    }
}
