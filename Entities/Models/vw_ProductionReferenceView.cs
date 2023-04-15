using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_ProductionReferenceView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string batchVoucher { get; set; } = null!;

    public int referencedVD { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [StringLength(26)]
    public string ArticleCode { get; set; } = null!;

    public string articleName { get; set; } = null!;

    [Column(TypeName = "decimal(18, 4)")]
    public decimal quantity { get; set; }

    [StringLength(26)]
    public string referening { get; set; } = null!;

    public int refereingVD { get; set; }

    [StringLength(26)]
    public string referingArticle { get; set; } = null!;

    [Column(TypeName = "decimal(18, 4)")]
    public decimal referingQty { get; set; }
}
