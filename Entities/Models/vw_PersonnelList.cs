using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_PersonnelList
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? titleCode { get; set; }

    public string? titleDesc { get; set; }

    public string firstName { get; set; } = null!;

    [StringLength(20)]
    public string? middleName { get; set; }

    [StringLength(20)]
    public string? lastName { get; set; }

    [StringLength(26)]
    public string? nationalityCode { get; set; }

    [StringLength(100)]
    public string? nationalityDesc { get; set; }

    [StringLength(26)]
    public string genderCode { get; set; } = null!;

    public string? genderDesc { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DOB { get; set; }

    public int? Age { get; set; }

    public string? mobile { get; set; }

    [StringLength(20)]
    public string? residentID { get; set; }

    public string? employementDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? lastPlacementDate { get; set; }

    [StringLength(26)]
    public string? employementType { get; set; }

    public string? empTypeDesc { get; set; }

    [StringLength(26)]
    public string? branchCode { get; set; }

    [StringLength(50)]
    public string? branchName { get; set; }

    [StringLength(26)]
    public string? departmentCode { get; set; }

    [StringLength(50)]
    public string? departmentName { get; set; }

    [StringLength(26)]
    public string? positionCode { get; set; }

    [StringLength(50)]
    public string? positionName { get; set; }

    [Column(TypeName = "money")]
    public decimal? basicSalary { get; set; }

    [Column(TypeName = "money")]
    public decimal? allowances { get; set; }

    [Column(TypeName = "money")]
    public decimal? grossTotal { get; set; }

    [StringLength(50)]
    public string? lastQualificationLevelCode { get; set; }

    public string? lastQualificationLevelDesc { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? lastQualificationDate { get; set; }

    [StringLength(50)]
    public string? lastQualificationInstituteCode { get; set; }

    public string? lastQualificationInstituteName { get; set; }

    [StringLength(50)]
    public string? lastQualificationFieldCode { get; set; }

    public string? lastQualificationFieldDesc { get; set; }

    public bool isActive { get; set; }

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    [StringLength(50)]
    public string? LastOSDDesc { get; set; }

    [StringLength(26)]
    public string? period { get; set; }
}
