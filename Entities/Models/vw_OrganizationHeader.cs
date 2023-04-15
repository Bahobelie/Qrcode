using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_OrganizationHeader
{
    public int GslType { get; set; }

    [StringLength(26)]
    public string OrganizationCode { get; set; } = null!;

    public string tradeName { get; set; } = null!;

    public string? brandName { get; set; }

    public string? name { get; set; }

    public bool isActive { get; set; }

    [StringLength(26)]
    public string? preferenceCode { get; set; }

    [StringLength(100)]
    public string? preferenceDesc { get; set; }

    [StringLength(26)]
    public string? prefParentCode { get; set; }

    [StringLength(100)]
    public string? prefParentDesc { get; set; }

    [StringLength(26)]
    public string? businessType { get; set; }

    public string? businessTypeName { get; set; }

    public int taxType { get; set; }

    public string? taxTypeDesc { get; set; }

    public int taxTypeAmount { get; set; }

    [StringLength(26)]
    public string? objectStateDefnCode { get; set; }

    public string? objectStateDefnDesc { get; set; }

    [StringLength(26)]
    public string? ObjectStateColor { get; set; }

    [StringLength(26)]
    public string? objectStateFont { get; set; }

    [StringLength(20)]
    public string? TIN { get; set; }

    public string? PhoneNumber { get; set; }

    public string? cityAddress { get; set; }

    public string? countryAddress { get; set; }

    public string? contactPerson { get; set; }

    public string? assignedPerson { get; set; }

    public string? representative { get; set; }

    public string? owners { get; set; }

    public int? OrgUnitCount { get; set; }

    public int? NoOfEmployee { get; set; }

    public int? NoOfRepresentative { get; set; }

    public int? NoOfAssignedPrsn { get; set; }

    public int? NoOfOwner { get; set; }

    public string? activityDef { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? startTimStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? endTimStamp { get; set; }

    public int? displayOrder { get; set; }

    [StringLength(20)]
    public string? semID { get; set; }

    [StringLength(26)]
    public string? sectorCode { get; set; }

    [StringLength(200)]
    public string? sector { get; set; }

    public double? latitude { get; set; }

    public double? longitude { get; set; }
}
