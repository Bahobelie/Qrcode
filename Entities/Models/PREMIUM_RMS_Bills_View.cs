using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class PREMIUM_RMS_Bills_View
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string type { get; set; } = null!;

    public bool IsVoid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    [StringLength(26)]
    public string article { get; set; } = null!;

    public int state { get; set; }

    [StringLength(26)]
    public string? waiter { get; set; }

    [StringLength(26)]
    public string? table { get; set; }

    [StringLength(26)]
    public string? device { get; set; }

    [StringLength(26)]
    public string? userCode { get; set; }
}
