using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_ArticleWithAccountMap
{
    [StringLength(26)]
    public string articleCode { get; set; } = null!;

    public int gslType { get; set; }

    public string itemName { get; set; } = null!;

    [StringLength(26)]
    public string preference { get; set; } = null!;

    [StringLength(26)]
    public string accountMapCode { get; set; } = null!;

    [StringLength(26)]
    public string accountCode { get; set; } = null!;

    [StringLength(50)]
    public string controlAccount { get; set; } = null!;

    [StringLength(50)]
    public string accountDescription { get; set; } = null!;

    [StringLength(26)]
    public string? parentAccount { get; set; }
}
