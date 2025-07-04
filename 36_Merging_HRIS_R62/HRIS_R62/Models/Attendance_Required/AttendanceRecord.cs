﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HRIS_R62.Models.Attendance_Required
{
    public class AttendanceRecord
    {
        [Key]
        [StringLength(50)]
        public string AttendanceRecordID { get; set; } = default!;

        [Required,Column(TypeName ="date")]
        public DateTime AttendanceDate { get; set; }

        //Regular Time
        [DataType(DataType.Time), Column(TypeName = "time")]
        public TimeOnly InTime { get; set; } = default!;

        [DataType(DataType.Time), Column(TypeName = "time")]
        public TimeOnly OutTime { get; set; } = default!;

        //OT Time
        [DataType(DataType.Time), Column(TypeName = "time")]
        public TimeOnly OTStart { get; set; } = default!;

        [DataType(DataType.Time), Column(TypeName = "time")]
        public TimeOnly OTEnd { get; set; } = default!;


        [DataType(DataType.Time), Column(TypeName = "time")]
        public TimeSpan TotalRegularHours { get; set; }     // Changed DataType into  TimeSpan By Zahid Sir

        [DataType(DataType.Time), Column(TypeName = "time")]
        public TimeSpan TotalOvertimeHours { get; set; }   // Changed DataType into  TimeSpan By Zahid Sir

        [StringLength(50)]
        public string DayType { get; set; } = default!;


        //Ommited By Zahid Sir
        //[ForeignKey("AttendanceConfiguration")]
        //public string AttendanceConfigurationID { get; set; } = default!;
        //public virtual AttendanceConfiguration? AttendanceConfiguration { get; set; }

        [ForeignKey("AttendanceStatus")]
        public string AttendanceStatusID { get; set; } = default!;
        public virtual AttendanceStatus? AttendanceStatus { get; set; }

        [ForeignKey("EmployeeInformation")]
        public string EmployeeID { get; set; }
        public virtual EmployeeInformation? EmployeeInformation { get; set; }
    }
}
