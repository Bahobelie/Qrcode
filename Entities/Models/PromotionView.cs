using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class PromotionView
{
    [StringLength(26)]
    public string oldPlacementVoucher { get; set; } = null!;

    [StringLength(26)]
    public string oldArticle { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? oldAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal oldGrandTotal { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime referenceIssueDate { get; set; }

    [StringLength(26)]
    public string oldOUD { get; set; } = null!;

    [StringLength(26)]
    public string newPlacementVoucher { get; set; } = null!;

    public int referingDefn { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime referingIssueDate { get; set; }

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    [Column(TypeName = "money")]
    public decimal newGrandTotal { get; set; }

    [StringLength(26)]
    public string newOUD { get; set; } = null!;

    public string? oldPlacementDate { get; set; }

    public string? newPlacementDate { get; set; }
}
