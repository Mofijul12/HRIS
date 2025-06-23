using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRIS_R62.Migrations
{
    /// <inheritdoc />
    public partial class InitialSchemaByNoKiB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AttendanceConfigurations",
                columns: table => new
                {
                    AttendanceConfigurationID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GraceTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    LunchBreakStartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    LunchBreakEndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EveningSnacksBreakStartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EveningSnacksBreakEndTime = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendanceConfigurations", x => x.AttendanceConfigurationID);
                });

            migrationBuilder.CreateTable(
                name: "AttendanceStatuss",
                columns: table => new
                {
                    AttendanceStatusID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StatusName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusShortName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendanceStatuss", x => x.AttendanceStatusID);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    CompanyID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CompanyShortName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CompanyNameLocal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CompanyAddress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FaxNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyID);
                });

            migrationBuilder.CreateTable(
                name: "Designations",
                columns: table => new
                {
                    DesignationID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DesignationName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DesignationShortName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designations", x => x.DesignationID);
                });

            migrationBuilder.CreateTable(
                name: "Divisions",
                columns: table => new
                {
                    DivisionID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DivisionName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DivisionShortName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divisions", x => x.DivisionID);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeBenefits",
                columns: table => new
                {
                    BenefitID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BenefitDate = table.Column<DateTime>(type: "date", nullable: true),
                    BenefitAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BenefitType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BenefitActivationDate = table.Column<DateTime>(type: "date", nullable: true),
                    PreviousNetSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NewNetSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SalaryStepID = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    GrossSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BasicSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HouseRent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MedicalAllowance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ConveyanceAllowance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LunchAllowance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OtherAllowance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CashIncentive = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LocalAreaClerance = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LocalAreaRemarks = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ApprovalDate = table.Column<DateTime>(type: "date", nullable: false),
                    EntryUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeBenefits", x => x.BenefitID);
                });

            migrationBuilder.CreateTable(
                name: "EmploymentTypes",
                columns: table => new
                {
                    EmploymentTypeID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmploymentTypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmploymentTypes", x => x.EmploymentTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    GradeID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GradeShortID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GradeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FromGrossSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ToGrossSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Gross = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Basic = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HouseRent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Medical = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ConveyanceAllowance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LunchAllowance = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.GradeID);
                });

            migrationBuilder.CreateTable(
                name: "LeaveTypes",
                columns: table => new
                {
                    LeaveTypeID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LeaveTypeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EntryUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveTypes", x => x.LeaveTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    BuildingID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Floor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyID = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.BuildingID);
                    table.ForeignKey(
                        name: "FK_Buildings_Companies_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DepartmentName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DepartmentShortName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DepartmentNameLocal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CompanyID = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentID);
                    table.ForeignKey(
                        name: "FK_Departments_Companies_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    SectionsID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SectionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SectionShortName = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    SectionNameNative = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CompanyID = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.SectionsID);
                    table.ForeignKey(
                        name: "FK_Sections_Companies_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    UnitID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UnitName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CompanyID = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.UnitID);
                    table.ForeignKey(
                        name: "FK_Units_Companies_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID");
                });

            migrationBuilder.CreateTable(
                name: "TiffinAllowanceRates",
                columns: table => new
                {
                    TiffinAllowanceRateID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RateInTaka = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DesignationID = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiffinAllowanceRates", x => x.TiffinAllowanceRateID);
                    table.ForeignKey(
                        name: "FK_TiffinAllowanceRates_Designations_DesignationID",
                        column: x => x.DesignationID,
                        principalTable: "Designations",
                        principalColumn: "DesignationID");
                });

            migrationBuilder.CreateTable(
                name: "NightAllowances",
                columns: table => new
                {
                    NightAllowanceID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SalaryMinimum = table.Column<decimal>(type: "money", nullable: false),
                    SalaryMaximum = table.Column<decimal>(type: "money", nullable: false),
                    NightAllowanceRate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmploymentTypeID = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NightAllowances", x => x.NightAllowanceID);
                    table.ForeignKey(
                        name: "FK_NightAllowances_EmploymentTypes_EmploymentTypeID",
                        column: x => x.EmploymentTypeID,
                        principalTable: "EmploymentTypes",
                        principalColumn: "EmploymentTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NightAllowanceTimes",
                columns: table => new
                {
                    NightAllowanceTimeID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AllowanceType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    NightHours = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NightMinutes = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmploymentTypeID = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NightAllowanceTimes", x => x.NightAllowanceTimeID);
                    table.ForeignKey(
                        name: "FK_NightAllowanceTimes_EmploymentTypes_EmploymentTypeID",
                        column: x => x.EmploymentTypeID,
                        principalTable: "EmploymentTypes",
                        principalColumn: "EmploymentTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TiffinAllowanceTimes",
                columns: table => new
                {
                    TiffinAllowanceID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AllowanceDate = table.Column<DateOnly>(type: "date", nullable: false),
                    AllowanceType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Time = table.Column<TimeOnly>(type: "time", nullable: false),
                    EmploymentTypeID = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiffinAllowanceTimes", x => x.TiffinAllowanceID);
                    table.ForeignKey(
                        name: "FK_TiffinAllowanceTimes_EmploymentTypes_EmploymentTypeID",
                        column: x => x.EmploymentTypeID,
                        principalTable: "EmploymentTypes",
                        principalColumn: "EmploymentTypeID");
                });

            migrationBuilder.CreateTable(
                name: "SalaryGrades",
                columns: table => new
                {
                    SalaryGradeID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GradeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GradeStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RuleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EffectiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GradeID = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaryGrades", x => x.SalaryGradeID);
                    table.ForeignKey(
                        name: "FK_SalaryGrades_Grades_GradeID",
                        column: x => x.GradeID,
                        principalTable: "Grades",
                        principalColumn: "GradeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalarySteps",
                columns: table => new
                {
                    SalaryStepID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GradeID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StepNumber = table.Column<int>(type: "int", nullable: false),
                    BasicSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HouseAllowance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MedicalAllowance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ConveyanceAllowance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LunchAllowance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GrossSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StepStatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalarySteps", x => x.SalaryStepID);
                    table.ForeignKey(
                        name: "FK_SalarySteps_Grades_GradeID",
                        column: x => x.GradeID,
                        principalTable: "Grades",
                        principalColumn: "GradeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LineInformations",
                columns: table => new
                {
                    LineID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LineName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EntryDate = table.Column<DateTime>(type: "date", nullable: false),
                    UnitID = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    BuildingID = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    SectionsID = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    CompanyID = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    DivisionID = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineInformations", x => x.LineID);
                    table.ForeignKey(
                        name: "FK_LineInformations_Buildings_BuildingID",
                        column: x => x.BuildingID,
                        principalTable: "Buildings",
                        principalColumn: "BuildingID");
                    table.ForeignKey(
                        name: "FK_LineInformations_Companies_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID");
                    table.ForeignKey(
                        name: "FK_LineInformations_Divisions_DivisionID",
                        column: x => x.DivisionID,
                        principalTable: "Divisions",
                        principalColumn: "DivisionID");
                    table.ForeignKey(
                        name: "FK_LineInformations_Sections_SectionsID",
                        column: x => x.SectionsID,
                        principalTable: "Sections",
                        principalColumn: "SectionsID");
                    table.ForeignKey(
                        name: "FK_LineInformations_Units_UnitID",
                        column: x => x.UnitID,
                        principalTable: "Units",
                        principalColumn: "UnitID");
                });

            migrationBuilder.CreateTable(
                name: "AttendanceBonus",
                columns: table => new
                {
                    AttendanceBonusID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BonusAmount = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    BonusCategory = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendanceBonus", x => x.AttendanceBonusID);
                });

            migrationBuilder.CreateTable(
                name: "AttendanceRecords",
                columns: table => new
                {
                    AttendanceRecordID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AttendanceDate = table.Column<DateTime>(type: "date", nullable: false),
                    InTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    OutTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    OTStart = table.Column<TimeOnly>(type: "time", nullable: false),
                    OTEnd = table.Column<TimeOnly>(type: "time", nullable: false),
                    TotalRegularHours = table.Column<TimeSpan>(type: "time", nullable: false),
                    TotalOvertimeHours = table.Column<TimeSpan>(type: "time", nullable: false),
                    DayType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AttendanceStatusID = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    AttendanceConfigurationID = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendanceRecords", x => x.AttendanceRecordID);
                    table.ForeignKey(
                        name: "FK_AttendanceRecords_AttendanceConfigurations_AttendanceConfigurationID",
                        column: x => x.AttendanceConfigurationID,
                        principalTable: "AttendanceConfigurations",
                        principalColumn: "AttendanceConfigurationID");
                    table.ForeignKey(
                        name: "FK_AttendanceRecords_AttendanceStatuss_AttendanceStatusID",
                        column: x => x.AttendanceStatusID,
                        principalTable: "AttendanceStatuss",
                        principalColumn: "AttendanceStatusID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DateWiseOfficeTimes",
                columns: table => new
                {
                    DateWiseOfficeTimeID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ShiftStartDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ShiftEndDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ConsideredLunchHour = table.Column<TimeOnly>(type: "time", nullable: false),
                    BreakDuration = table.Column<TimeOnly>(type: "time", nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateWiseOfficeTimes", x => x.DateWiseOfficeTimeID);
                });

            migrationBuilder.CreateTable(
                name: "ShiftEmployees",
                columns: table => new
                {
                    ShiftEmployeeID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateWiseOfficeTimeID = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShiftEmployees", x => x.ShiftEmployeeID);
                    table.ForeignKey(
                        name: "FK_ShiftEmployees_DateWiseOfficeTimes_DateWiseOfficeTimeID",
                        column: x => x.DateWiseOfficeTimeID,
                        principalTable: "DateWiseOfficeTimes",
                        principalColumn: "DateWiseOfficeTimeID");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeInformations",
                columns: table => new
                {
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsLineSelected = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LineID = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    EmployeeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EmployeeNameLocal = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CompanyID = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    UnitID = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    DivisionID = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    DepartmentID = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    SectionID = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    DesignationID = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    GradeID = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ShiftEmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ProximityNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsOTAllowed = table.Column<bool>(type: "bit", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    IDentificationMark = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EmploymentTypeID = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    PresentAddress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    PermanentAddress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MobileNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NationalIDNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    IsMobileBanking = table.Column<bool>(type: "bit", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    BankName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    FatherName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FatherNameLocal = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    FatherOccupation = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    MotherName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MotherNameLocal = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    MotherOccupation = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlaceOfBirth = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DistrictOfBirth = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Religion = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BloodGroup = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: true),
                    MaritalStatus = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    DateOfMarriage = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AppointmentType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    JoiningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PostingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConfirmationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RetirementDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ServiceLength = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    SpouseName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SpouseOccupation = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    SpouseDateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SpouseBloodGroup = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CurrentSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SalaryAtJoining = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SalaryGradeID = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    SalaryStepID = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    PassportNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    PassportIssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PassportExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PassportIssuePlace = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    PassportIssueAuthority = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    LicenseNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LicenseIssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LicenseExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LicenseIssuePlace = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    LicenseIssueAuthority = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MembershipCardNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Association = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MembershipType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MembershipValidityDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReferenceName1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ReferenceAddress1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ReferencePhone1 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ReferenceOccupation1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ReferenceRelation1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ReferenceName2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ReferenceAddress2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ReferencePhone2 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ReferenceOccupation2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ReferenceRelation2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LocalAreaClerance = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LocalAreaRemarks = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    EmployeePhoto = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    EmployeeSignature = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    OldEmployeeID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreviousEmployeeID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WeeklyHoliDay = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ApprovedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmployeeStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeInformations", x => x.EmployeeID);
                    table.ForeignKey(
                        name: "FK_EmployeeInformations_Companies_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeInformations_Departments_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "DepartmentID");
                    table.ForeignKey(
                        name: "FK_EmployeeInformations_Designations_DesignationID",
                        column: x => x.DesignationID,
                        principalTable: "Designations",
                        principalColumn: "DesignationID");
                    table.ForeignKey(
                        name: "FK_EmployeeInformations_Divisions_DivisionID",
                        column: x => x.DivisionID,
                        principalTable: "Divisions",
                        principalColumn: "DivisionID");
                    table.ForeignKey(
                        name: "FK_EmployeeInformations_EmploymentTypes_EmploymentTypeID",
                        column: x => x.EmploymentTypeID,
                        principalTable: "EmploymentTypes",
                        principalColumn: "EmploymentTypeID");
                    table.ForeignKey(
                        name: "FK_EmployeeInformations_Grades_GradeID",
                        column: x => x.GradeID,
                        principalTable: "Grades",
                        principalColumn: "GradeID");
                    table.ForeignKey(
                        name: "FK_EmployeeInformations_LineInformations_LineID",
                        column: x => x.LineID,
                        principalTable: "LineInformations",
                        principalColumn: "LineID");
                    table.ForeignKey(
                        name: "FK_EmployeeInformations_SalaryGrades_SalaryGradeID",
                        column: x => x.SalaryGradeID,
                        principalTable: "SalaryGrades",
                        principalColumn: "SalaryGradeID");
                    table.ForeignKey(
                        name: "FK_EmployeeInformations_SalarySteps_SalaryStepID",
                        column: x => x.SalaryStepID,
                        principalTable: "SalarySteps",
                        principalColumn: "SalaryStepID");
                    table.ForeignKey(
                        name: "FK_EmployeeInformations_Sections_SectionID",
                        column: x => x.SectionID,
                        principalTable: "Sections",
                        principalColumn: "SectionsID");
                    table.ForeignKey(
                        name: "FK_EmployeeInformations_ShiftEmployees_ShiftEmployeeID",
                        column: x => x.ShiftEmployeeID,
                        principalTable: "ShiftEmployees",
                        principalColumn: "ShiftEmployeeID");
                    table.ForeignKey(
                        name: "FK_EmployeeInformations_Units_UnitID",
                        column: x => x.UnitID,
                        principalTable: "Units",
                        principalColumn: "UnitID");
                });

            migrationBuilder.CreateTable(
                name: "EarlyLeaveInformation",
                columns: table => new
                {
                    EarlyLeaveInformationID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LeaveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EarlyLeaveInformation", x => x.EarlyLeaveInformationID);
                    table.ForeignKey(
                        name: "FK_EarlyLeaveInformation_EmployeeInformations_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LateApprovals",
                columns: table => new
                {
                    LateApprovalID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LateReason = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    EntryUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LateApprovals", x => x.LateApprovalID);
                    table.ForeignKey(
                        name: "FK_LateApprovals_EmployeeInformations_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LeaveApprovals",
                columns: table => new
                {
                    LeaveApprovalID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LeaveTypeID = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    LeaveFromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ApprovedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LeaveEnjoyed = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    TotalLeave = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    ProvidedLeave = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeInformationsEmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    EntryUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EntryDate = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveApprovals", x => x.LeaveApprovalID);
                    table.ForeignKey(
                        name: "FK_LeaveApprovals_EmployeeInformations_EmployeeInformationsEmployeeID",
                        column: x => x.EmployeeInformationsEmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID");
                    table.ForeignKey(
                        name: "FK_LeaveApprovals_LeaveTypes_LeaveTypeID",
                        column: x => x.LeaveTypeID,
                        principalTable: "LeaveTypes",
                        principalColumn: "LeaveTypeID");
                });

            migrationBuilder.CreateTable(
                name: "LeaveRecords",
                columns: table => new
                {
                    LeaveRecordID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LeaveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    LeaveTypeID = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    TotalLeave = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LeaveEnjoyed = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    ApprovedDate = table.Column<DateTime>(type: "date", nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    EntryUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRecords", x => x.LeaveRecordID);
                    table.ForeignKey(
                        name: "FK_LeaveRecords_EmployeeInformations_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LeaveRecords_LeaveTypes_LeaveTypeID",
                        column: x => x.LeaveTypeID,
                        principalTable: "LeaveTypes",
                        principalColumn: "LeaveTypeID");
                });

            migrationBuilder.CreateTable(
                name: "ManualAttendances",
                columns: table => new
                {
                    ManualAttendanceID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AttendanceDate = table.Column<DateTime>(type: "date", nullable: false),
                    AttendanceTime = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    EntryDate = table.Column<DateTime>(type: "date", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    EntryUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OutTime = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManualAttendances", x => x.ManualAttendanceID);
                    table.ForeignKey(
                        name: "FK_ManualAttendances_EmployeeInformations_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OverTimes",
                columns: table => new
                {
                    OverTimeID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OTDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OTStartTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    OTEndTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OverTimes", x => x.OverTimeID);
                    table.ForeignKey(
                        name: "FK_OverTimes_EmployeeInformations_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProximityRecords",
                columns: table => new
                {
                    ProximityRecordID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProximityNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecordDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    OutTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    VerifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProximityRecords", x => x.ProximityRecordID);
                    table.ForeignKey(
                        name: "FK_ProximityRecords_EmployeeInformations_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalaryRecords",
                columns: table => new
                {
                    SalaryRecordID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SalaryStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SalaryEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SalaryStepID = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    JoiningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MonthDays = table.Column<int>(type: "int", nullable: false),
                    PunchDays = table.Column<int>(type: "int", nullable: false),
                    TotalHoliDay = table.Column<int>(type: "int", nullable: false),
                    TotalLeave = table.Column<int>(type: "int", nullable: false),
                    WorkingDays = table.Column<int>(type: "int", nullable: false),
                    Absenteeism = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Gross = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ActualGross = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Basic = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HouseRent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MedicalAllowance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MobileAllowance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OtherAllowances = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LunchAllowance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OtherDeduction = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OTHours = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OTAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ByBankAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ByCashAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetPayable = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ConveyanceAllowance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AttendanceBonus = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SpecialAllowance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SalaryAdvance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FoodCharge = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OTRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TiffinAllowance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Arrear = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SpecialBonus = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LeaveStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoliDayBillAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NightBillAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SalaryID = table.Column<int>(type: "int", nullable: false),
                    LunchBillAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MobileBanking = table.Column<bool>(type: "bit", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProcessDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    DepartmentID = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaryRecords", x => x.SalaryRecordID);
                    table.ForeignKey(
                        name: "FK_SalaryRecords_Departments_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "DepartmentID");
                    table.ForeignKey(
                        name: "FK_SalaryRecords_EmployeeInformations_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalaryRecords_SalarySteps_SalaryStepID",
                        column: x => x.SalaryStepID,
                        principalTable: "SalarySteps",
                        principalColumn: "SalaryStepID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShiftTimes",
                columns: table => new
                {
                    ShiftID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ShiftName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ShiftStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShiftEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConsideredLunchHour = table.Column<int>(type: "int", nullable: true),
                    BreakDuration = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShiftTimes", x => x.ShiftID);
                    table.ForeignKey(
                        name: "FK_ShiftTimes_EmployeeInformations_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID");
                });

            migrationBuilder.CreateTable(
                name: "SpecialEmployees",
                columns: table => new
                {
                    SpecialEmployeeID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FromDate = table.Column<DateTime>(type: "date", nullable: true),
                    ToDate = table.Column<DateTime>(type: "date", nullable: true),
                    AttendanceType = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeInformationsEmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialEmployees", x => x.SpecialEmployeeID);
                    table.ForeignKey(
                        name: "FK_SpecialEmployees_EmployeeInformations_EmployeeInformationsEmployeeID",
                        column: x => x.EmployeeInformationsEmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceBonus_EmployeeID",
                table: "AttendanceBonus",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceRecords_AttendanceConfigurationID",
                table: "AttendanceRecords",
                column: "AttendanceConfigurationID");

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceRecords_AttendanceStatusID",
                table: "AttendanceRecords",
                column: "AttendanceStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceRecords_EmployeeID",
                table: "AttendanceRecords",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_CompanyID",
                table: "Buildings",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_DateWiseOfficeTimes_EmployeeID",
                table: "DateWiseOfficeTimes",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_CompanyID",
                table: "Departments",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_EarlyLeaveInformation_EmployeeID",
                table: "EarlyLeaveInformation",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInformations_CompanyID",
                table: "EmployeeInformations",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInformations_DepartmentID",
                table: "EmployeeInformations",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInformations_DesignationID",
                table: "EmployeeInformations",
                column: "DesignationID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInformations_DivisionID",
                table: "EmployeeInformations",
                column: "DivisionID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInformations_EmploymentTypeID",
                table: "EmployeeInformations",
                column: "EmploymentTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInformations_GradeID",
                table: "EmployeeInformations",
                column: "GradeID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInformations_LineID",
                table: "EmployeeInformations",
                column: "LineID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInformations_SalaryGradeID",
                table: "EmployeeInformations",
                column: "SalaryGradeID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInformations_SalaryStepID",
                table: "EmployeeInformations",
                column: "SalaryStepID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInformations_SectionID",
                table: "EmployeeInformations",
                column: "SectionID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInformations_ShiftEmployeeID",
                table: "EmployeeInformations",
                column: "ShiftEmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInformations_UnitID",
                table: "EmployeeInformations",
                column: "UnitID");

            migrationBuilder.CreateIndex(
                name: "IX_LateApprovals_EmployeeID",
                table: "LateApprovals",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveApprovals_EmployeeInformationsEmployeeID",
                table: "LeaveApprovals",
                column: "EmployeeInformationsEmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveApprovals_LeaveTypeID",
                table: "LeaveApprovals",
                column: "LeaveTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRecords_EmployeeID",
                table: "LeaveRecords",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRecords_LeaveTypeID",
                table: "LeaveRecords",
                column: "LeaveTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_LineInformations_BuildingID",
                table: "LineInformations",
                column: "BuildingID");

            migrationBuilder.CreateIndex(
                name: "IX_LineInformations_CompanyID",
                table: "LineInformations",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_LineInformations_DivisionID",
                table: "LineInformations",
                column: "DivisionID");

            migrationBuilder.CreateIndex(
                name: "IX_LineInformations_SectionsID",
                table: "LineInformations",
                column: "SectionsID");

            migrationBuilder.CreateIndex(
                name: "IX_LineInformations_UnitID",
                table: "LineInformations",
                column: "UnitID");

            migrationBuilder.CreateIndex(
                name: "IX_ManualAttendances_EmployeeID",
                table: "ManualAttendances",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_NightAllowances_EmploymentTypeID",
                table: "NightAllowances",
                column: "EmploymentTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_NightAllowanceTimes_EmploymentTypeID",
                table: "NightAllowanceTimes",
                column: "EmploymentTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_OverTimes_EmployeeID",
                table: "OverTimes",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_ProximityRecords_EmployeeID",
                table: "ProximityRecords",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_SalaryGrades_GradeID",
                table: "SalaryGrades",
                column: "GradeID");

            migrationBuilder.CreateIndex(
                name: "IX_SalaryRecords_DepartmentID",
                table: "SalaryRecords",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_SalaryRecords_EmployeeID",
                table: "SalaryRecords",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_SalaryRecords_SalaryStepID",
                table: "SalaryRecords",
                column: "SalaryStepID");

            migrationBuilder.CreateIndex(
                name: "IX_SalarySteps_GradeID",
                table: "SalarySteps",
                column: "GradeID");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_CompanyID",
                table: "Sections",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_ShiftEmployees_DateWiseOfficeTimeID",
                table: "ShiftEmployees",
                column: "DateWiseOfficeTimeID");

            migrationBuilder.CreateIndex(
                name: "IX_ShiftTimes_EmployeeID",
                table: "ShiftTimes",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_SpecialEmployees_EmployeeInformationsEmployeeID",
                table: "SpecialEmployees",
                column: "EmployeeInformationsEmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_TiffinAllowanceRates_DesignationID",
                table: "TiffinAllowanceRates",
                column: "DesignationID");

            migrationBuilder.CreateIndex(
                name: "IX_TiffinAllowanceTimes_EmploymentTypeID",
                table: "TiffinAllowanceTimes",
                column: "EmploymentTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Units_CompanyID",
                table: "Units",
                column: "CompanyID");

            migrationBuilder.AddForeignKey(
                name: "FK_AttendanceBonus_EmployeeInformations_EmployeeID",
                table: "AttendanceBonus",
                column: "EmployeeID",
                principalTable: "EmployeeInformations",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AttendanceRecords_EmployeeInformations_EmployeeID",
                table: "AttendanceRecords",
                column: "EmployeeID",
                principalTable: "EmployeeInformations",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DateWiseOfficeTimes_EmployeeInformations_EmployeeID",
                table: "DateWiseOfficeTimes",
                column: "EmployeeID",
                principalTable: "EmployeeInformations",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DateWiseOfficeTimes_EmployeeInformations_EmployeeID",
                table: "DateWiseOfficeTimes");

            migrationBuilder.DropTable(
                name: "AttendanceBonus");

            migrationBuilder.DropTable(
                name: "AttendanceRecords");

            migrationBuilder.DropTable(
                name: "EarlyLeaveInformation");

            migrationBuilder.DropTable(
                name: "EmployeeBenefits");

            migrationBuilder.DropTable(
                name: "LateApprovals");

            migrationBuilder.DropTable(
                name: "LeaveApprovals");

            migrationBuilder.DropTable(
                name: "LeaveRecords");

            migrationBuilder.DropTable(
                name: "ManualAttendances");

            migrationBuilder.DropTable(
                name: "NightAllowances");

            migrationBuilder.DropTable(
                name: "NightAllowanceTimes");

            migrationBuilder.DropTable(
                name: "OverTimes");

            migrationBuilder.DropTable(
                name: "ProximityRecords");

            migrationBuilder.DropTable(
                name: "SalaryRecords");

            migrationBuilder.DropTable(
                name: "ShiftTimes");

            migrationBuilder.DropTable(
                name: "SpecialEmployees");

            migrationBuilder.DropTable(
                name: "TiffinAllowanceRates");

            migrationBuilder.DropTable(
                name: "TiffinAllowanceTimes");

            migrationBuilder.DropTable(
                name: "AttendanceConfigurations");

            migrationBuilder.DropTable(
                name: "AttendanceStatuss");

            migrationBuilder.DropTable(
                name: "LeaveTypes");

            migrationBuilder.DropTable(
                name: "EmployeeInformations");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Designations");

            migrationBuilder.DropTable(
                name: "EmploymentTypes");

            migrationBuilder.DropTable(
                name: "LineInformations");

            migrationBuilder.DropTable(
                name: "SalaryGrades");

            migrationBuilder.DropTable(
                name: "SalarySteps");

            migrationBuilder.DropTable(
                name: "ShiftEmployees");

            migrationBuilder.DropTable(
                name: "Buildings");

            migrationBuilder.DropTable(
                name: "Divisions");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "DateWiseOfficeTimes");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
