using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_transactionRefDetailView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string referedCode { get; set; } = null!;

    public int referingVoDef { get; set; }

    [StringLength(26)]
    public string? consignee { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    public bool IsIssued { get; set; }

    public bool IsVoid { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    [StringLength(2048)]
    public string? note { get; set; }

    [StringLength(50)]
    public string? relationType { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [Column(TypeName = "money")]
    public decimal? value { get; set; }

    public int referedVoDef { get; set; }

    [StringLength(26)]
    public string transactionReferenceCode { get; set; } = null!;

    [StringLength(2048)]
    public string? referedNote { get; set; }

    [StringLength(26)]
    public string? referedConsignee { get; set; }

    public string? referedConsName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime referedIssueDate { get; set; }
}
