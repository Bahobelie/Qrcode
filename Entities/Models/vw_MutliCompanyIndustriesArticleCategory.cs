using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_MutliCompanyIndustriesArticleCategory
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    public string name { get; set; } = null!;

    [StringLength(26)]
    public string prefCode { get; set; } = null!;

    [StringLength(100)]
    public string prefDesc { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal priceValue { get; set; }

    public string? note { get; set; }

    [StringLength(256)]
    public string? url { get; set; }
}
