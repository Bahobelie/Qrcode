using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_OrgWithIdentification
{
    [StringLength(26)]
    public string OrganizationCode { get; set; } = null!;

    public string tradeName { get; set; } = null!;

    public string? brandName { get; set; }

    [StringLength(26)]
    public string? businessType { get; set; }

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

    public bool isActive { get; set; }

    [StringLength(26)]
    public string? preference { get; set; }

    [StringLength(26)]
    public string? identficationType { get; set; }
}
