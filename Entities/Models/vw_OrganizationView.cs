using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_OrganizationView
{
    [StringLength(26)]
    public string OrganizationCode { get; set; } = null!;

    public string tradeName { get; set; } = null!;

    public string? brandName { get; set; }

    [StringLength(26)]
    public string? businessType { get; set; }

    public string? businessTypeName { get; set; }

    public int GslType { get; set; }

    public string? name { get; set; }

    [StringLength(50)]
    public string? IdentificationDescription { get; set; }

    [StringLength(20)]
    public string? idNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? issueDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? expiryDate { get; set; }

    [StringLength(26)]
    public string organizationUnitDefinition { get; set; } = null!;

    [StringLength(26)]
    public string OrgUnitDefnType { get; set; } = null!;

    [StringLength(50)]
    public string OrgUnitDefnDescription { get; set; } = null!;

    [StringLength(50)]
    public string? specialization { get; set; }

    public string? specializationName { get; set; }

    [StringLength(26)]
    public string? abbriviation { get; set; }

    [StringLength(26)]
    public string? OrgUnitDefParent { get; set; }

    public string? Address { get; set; }

    public int? tax { get; set; }

    [StringLength(50)]
    public string? TaxDescription { get; set; }

    [Column(TypeName = "money")]
    public decimal? TaxAmount { get; set; }

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
    public string? AddressPreference { get; set; }

    [StringLength(26)]
    public string? identficationType { get; set; }

    [StringLength(26)]
    public string? objectStateDefnCode { get; set; }

    [StringLength(50)]
    public string? objectStateDefnDesc { get; set; }

    [StringLength(26)]
    public string? ObjectStateColor { get; set; }

    [StringLength(26)]
    public string? objectStateFont { get; set; }
}
