using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_ArtPrefNoCatagory
{
    [StringLength(26)]
    public string ArticleCode { get; set; } = null!;

    public string PreferenceName { get; set; } = null!;

    [StringLength(26)]
    public string ArticlePrefenceCode { get; set; } = null!;

    [StringLength(26)]
    public string? PrefCode { get; set; }
}
