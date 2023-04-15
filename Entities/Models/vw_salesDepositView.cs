using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_salesDepositView
{
    [StringLength(26)]
    public string sales { get; set; } = null!;

    [StringLength(26)]
    public string depositReference { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? grandTotal { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime depositDate { get; set; }

    public string? bank { get; set; }

    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string branch { get; set; } = null!;

    [StringLength(40)]
    public string accountNo { get; set; } = null!;
}
