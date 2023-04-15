using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_ClientsLicense
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(26)]
    public string component { get; set; } = null!;

    [StringLength(26)]
    public string? device { get; set; }

    public string tradeName { get; set; } = null!;

    [StringLength(50)]
    public string? description { get; set; }

    public string? deviceName { get; set; }

    [StringLength(30)]
    public string? user_name { get; set; }

    [StringLength(50)]
    public string CompDescription { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime expiryDate { get; set; }

    public string? brandName { get; set; }

    [StringLength(26)]
    public string? preference { get; set; }

    [StringLength(100)]
    public string licenseKey { get; set; } = null!;

    public string? remark { get; set; }

    [StringLength(40)]
    public string? deviceValue { get; set; }

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(26)]
    public string? user { get; set; }

    [StringLength(20)]
    public string idNumber { get; set; } = null!;

    [StringLength(26)]
    public string? organizationUnitDefinition { get; set; }

    [StringLength(26)]
    public string? consignee { get; set; }

    [StringLength(50)]
    public string? objectState { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }
}
