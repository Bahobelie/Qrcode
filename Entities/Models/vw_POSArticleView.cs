using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_POSArticleView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    public string artName { get; set; } = null!;

    public string uom { get; set; } = null!;

    [StringLength(26)]
    public string category { get; set; } = null!;

    public bool isActive { get; set; }

    public int gslType { get; set; }

    [StringLength(26)]
    public string catCode { get; set; } = null!;

    [StringLength(100)]
    public string description { get; set; } = null!;

    [StringLength(26)]
    public string? parent { get; set; }

    [StringLength(26)]
    public string objCode { get; set; } = null!;

    [StringLength(15)]
    public string uomCode { get; set; } = null!;

    [StringLength(100)]
    public string? artRemark { get; set; }
}
