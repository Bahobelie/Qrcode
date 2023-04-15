using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class TransactionReferenceVoucherView
{
    [StringLength(26)]
    public string referenceCode { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal referenceTotal { get; set; }

    public int referenceDefn { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime referenceIssueDate { get; set; }

    [StringLength(26)]
    public string referening { get; set; } = null!;

    public int referingDefn { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime referingIssueDate { get; set; }

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    public string periodName { get; set; } = null!;

    [StringLength(50)]
    public string status { get; set; } = null!;

    public bool referingIsIssued { get; set; }

    [StringLength(26)]
    public string? consignee { get; set; }

    [StringLength(26)]
    public string? referencedState { get; set; }

    [StringLength(100)]
    public string? TransactionRemark { get; set; }

    [StringLength(50)]
    public string? relationType { get; set; }
}
