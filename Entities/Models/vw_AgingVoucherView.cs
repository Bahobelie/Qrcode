using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_AgingVoucherView
{
    [StringLength(26)]
    public string mainVoucherCode { get; set; } = null!;

    [StringLength(26)]
    public string? mainConsigneeCode { get; set; }

    public string? consigeeName { get; set; }

    public int mainVoucherDefn { get; set; }

    [Column(TypeName = "money")]
    public decimal baseAmount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime mainIssueDate { get; set; }

    [StringLength(26)]
    public string referening { get; set; } = null!;

    [StringLength(26)]
    public string referenced { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal settledAmount { get; set; }

    [StringLength(26)]
    public string code { get; set; } = null!;

    public int SettlingVoucherDefn { get; set; }

    [StringLength(26)]
    public string settlingConsignee { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    public int vouDefCode { get; set; }

    [StringLength(100)]
    public string settlingVoucherDefnDes { get; set; } = null!;

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    public string dueDate { get; set; } = null!;
}
