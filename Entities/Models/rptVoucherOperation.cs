using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class rptVoucherOperation
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(62)]
    public string? consignee { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? IssuedDate { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    [StringLength(50)]
    public string? description { get; set; }

    [StringLength(26)]
    public string? device { get; set; }

    [StringLength(26)]
    public string? person { get; set; }

    [StringLength(30)]
    public string? userName { get; set; }

    [StringLength(40)]
    public string? devicename { get; set; }

    [StringLength(100)]
    public string? name { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? startTimStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? endTimStamp { get; set; }

    [StringLength(26)]
    public string voucherDefinition { get; set; } = null!;
}
