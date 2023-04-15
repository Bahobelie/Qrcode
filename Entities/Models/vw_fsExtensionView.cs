using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_fsExtensionView
{
    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(26)]
    public string fsNo { get; set; } = null!;

    [StringLength(26)]
    public string mrsNo { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? value { get; set; }

    [StringLength(26)]
    public string regCode { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [StringLength(2048)]
    public string note { get; set; } = null!;

    public string? remark { get; set; }

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(26)]
    public string code { get; set; } = null!;
}
