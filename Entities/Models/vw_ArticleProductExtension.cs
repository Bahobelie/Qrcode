using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_ArticleProductExtension
{
    [StringLength(26)]
    public string articleCode { get; set; } = null!;

    public int gslType { get; set; }

    public string articleName { get; set; } = null!;

    [StringLength(26)]
    public string articleChildCode { get; set; } = null!;

    [StringLength(100)]
    public string articleChildDesc { get; set; } = null!;

    [StringLength(26)]
    public string referringObject { get; set; } = null!;

    [StringLength(100)]
    public string? brand { get; set; }

    [StringLength(100)]
    public string? generic { get; set; }

    [StringLength(100)]
    public string model { get; set; } = null!;

    [StringLength(25)]
    public string? size { get; set; }

    [StringLength(50)]
    public string? color { get; set; }

    [StringLength(26)]
    public string? country { get; set; }

    [StringLength(100)]
    public string? manufacturer { get; set; }
}
