using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_PersonActivity
{
    [StringLength(26)]
    public string PersonCode { get; set; } = null!;

    [StringLength(26)]
    public string? title { get; set; }

    [StringLength(20)]
    public string firstName { get; set; } = null!;

    [StringLength(20)]
    public string? middleName { get; set; }

    [StringLength(20)]
    public string? lastName { get; set; }

    [StringLength(50)]
    public string? TitleDescription { get; set; }

    [StringLength(64)]
    public string name { get; set; } = null!;

    public int GslType { get; set; }

    [StringLength(26)]
    public string gender { get; set; } = null!;

    [StringLength(50)]
    public string? PersonGender { get; set; }

    [StringLength(26)]
    public string? nationality { get; set; }

    [StringLength(50)]
    public string? nationalityName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DOB { get; set; }

    public bool isActive { get; set; }

    [StringLength(50)]
    public string? PersonTitle { get; set; }

    [StringLength(50)]
    public string? IdentficationDescription { get; set; }

    [StringLength(20)]
    public string? idNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? issueDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? expiryDate { get; set; }

    public string? Address { get; set; }

    public int? tax { get; set; }

    [StringLength(26)]
    public string? preferenceCode { get; set; }

    [StringLength(100)]
    public string? preferenceDesc { get; set; }

    [StringLength(26)]
    public string? prefParentCode { get; set; }

    [StringLength(100)]
    public string? prefParentDesc { get; set; }

    [StringLength(26)]
    public string? AddressPreference { get; set; }

    [StringLength(26)]
    public string? IdentficationType { get; set; }

    [StringLength(26)]
    public string? objectStateDefnCode { get; set; }

    [StringLength(50)]
    public string? objectStateDefnDesc { get; set; }

    [StringLength(26)]
    public string? ObjectStateColor { get; set; }

    [StringLength(26)]
    public string? objectStateFont { get; set; }

    [StringLength(50)]
    public string? activityDef { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? startTimStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? endTimStamp { get; set; }

    [StringLength(26)]
    public string? branchCode { get; set; }

    [StringLength(50)]
    public string? branchName { get; set; }

    [StringLength(26)]
    public string? departmentCode { get; set; }

    [StringLength(50)]
    public string? departmentName { get; set; }
}
