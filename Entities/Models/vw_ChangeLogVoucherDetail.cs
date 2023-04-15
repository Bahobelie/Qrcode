using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_ChangeLogVoucherDetail
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string? consignee { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    public bool IsVoid { get; set; }

    public bool IsIssued { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [StringLength(26)]
    public string referenced { get; set; } = null!;

    [StringLength(50)]
    public string? relationType { get; set; }

    [StringLength(26)]
    public string referening { get; set; } = null!;

    [StringLength(26)]
    public string pType { get; set; } = null!;

    public int pVoucherDefinition { get; set; }

    public bool pIsVoid { get; set; }

    [Column(TypeName = "money")]
    public decimal pGrandTotal { get; set; }

    [StringLength(26)]
    public string? pLastObjectState { get; set; }

    public bool pIsIssued { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime pIssuedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime tExpiryDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime tProdDate { get; set; }

    [StringLength(26)]
    public string tLifeSpanCode { get; set; } = null!;

    [StringLength(26)]
    public string? pVoucherConsignee { get; set; }

    [StringLength(2048)]
    public string? note { get; set; }

    [StringLength(100)]
    public string? pRemark { get; set; }
}
