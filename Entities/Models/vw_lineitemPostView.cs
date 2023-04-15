using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_lineitemPostView
{
    [StringLength(26)]
    public string voucherCode { get; set; } = null!;

    [StringLength(26)]
    public string? consignee { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [StringLength(26)]
    public string? period { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    public int voucherDefinition { get; set; }

    [StringLength(100)]
    public string? vdefName { get; set; }

    [StringLength(50)]
    public string reconSumName { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? totalAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? calcCost { get; set; }

    [StringLength(26)]
    public string category { get; set; } = null!;

    [StringLength(26)]
    public string parent { get; set; } = null!;
}
