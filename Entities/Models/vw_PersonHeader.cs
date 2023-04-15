using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_PersonHeader
{
    [StringLength(26)]
    public string PersonCode { get; set; } = null!;

    [StringLength(26)]
    public string? title { get; set; }

    public string? TitleDescription { get; set; }

    public string firstName { get; set; } = null!;

    [StringLength(20)]
    public string? middleName { get; set; }

    [StringLength(20)]
    public string? lastName { get; set; }

    public string name { get; set; } = null!;

    public int GslType { get; set; }

    [StringLength(26)]
    public string? genderCode { get; set; }

    public string? genderDesc { get; set; }

    [StringLength(26)]
    public string? nationality { get; set; }

    [StringLength(50)]
    public string? nationalityName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DOB { get; set; }

    public int? age { get; set; }

    public bool isActive { get; set; }

    [StringLength(20)]
    public string? TIN { get; set; }

    [StringLength(20)]
    public string bioId { get; set; } = null!;

    public string? Telephone { get; set; }

    public int taxTypeCode { get; set; }

    public string? taxTypeDesc { get; set; }

    public int taxTypeAmount { get; set; }

    [StringLength(26)]
    public string? preferenceCode { get; set; }

    [StringLength(100)]
    public string? preferenceDesc { get; set; }

    [StringLength(26)]
    public string? prefParentCode { get; set; }

    [StringLength(100)]
    public string? prefParentDesc { get; set; }

    [StringLength(26)]
    public string? objectStateDefnCode { get; set; }

    public string? objectStateDefnDesc { get; set; }

    [StringLength(26)]
    public string? ObjectStateColor { get; set; }

    [StringLength(26)]
    public string? objectStateFont { get; set; }

    public string? cityAddress { get; set; }

    public string? countryAddress { get; set; }

    [StringLength(26)]
    public string? departmentCode { get; set; }

    [StringLength(50)]
    public string? departmentDesc { get; set; }

    public string? activityDef { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? startTimStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? endTimStamp { get; set; }

    public int? displayOrder { get; set; }

    public double? latitude { get; set; }

    public double? longitude { get; set; }
}
