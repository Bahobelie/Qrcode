using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_ArticleComponentWithDescription
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string article { get; set; } = null!;

    public string name { get; set; } = null!;

    [StringLength(26)]
    public string component { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    public string? remark { get; set; }
}
