using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class VoucherExtension_View
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string type { get; set; } = null!;

    public int voucherDefn { get; set; }

    [StringLength(26)]
    public string? voucher { get; set; }

    [StringLength(26)]
    public string? number { get; set; }

    [StringLength(50)]
    public string description { get; set; } = null!;
}
