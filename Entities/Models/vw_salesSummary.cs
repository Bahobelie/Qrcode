using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_salesSummary
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [StringLength(26)]
    public string? organizationUnitDefinition { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    [StringLength(26)]
    public string? RegCode { get; set; }

    public string? firstName { get; set; }

    [StringLength(20)]
    public string? lastName { get; set; }

    public string? customer { get; set; }

    [Column(TypeName = "money")]
    public decimal taxableAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal taxAmount { get; set; }

    public int? taxType { get; set; }

    [Column(TypeName = "money")]
    public decimal? serviceCharge { get; set; }

    [Column(TypeName = "money")]
    public decimal? discount { get; set; }

    [StringLength(50)]
    public string? room { get; set; }

    [StringLength(26)]
    public string? foStatus { get; set; }

    [StringLength(26)]
    public string? roomType { get; set; }

    public string? note { get; set; }
}
