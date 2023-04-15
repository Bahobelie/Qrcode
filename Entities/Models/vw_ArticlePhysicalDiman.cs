using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_ArticlePhysicalDiman
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    public string name { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal length { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal width { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal height { get; set; }

    [StringLength(50)]
    public string description { get; set; } = null!;
}
