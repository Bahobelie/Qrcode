using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_LicenseVoucher
{
    public Guid Id { get; set; }

    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? consignee { get; set; }

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string article { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string component { get; set; } = null!;

    [StringLength(26)]
    public string? organizationUnitDef { get; set; }

    [StringLength(26)]
    public string? device { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string expiryDate { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string licenseKey { get; set; } = null!;

    [StringLength(50)]
    public string? compName { get; set; }

    public string? deviceName { get; set; }

    [StringLength(50)]
    public string? orgUniDefDesc { get; set; }
}
