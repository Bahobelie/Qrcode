using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class POS_Artticle_View
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int gslType { get; set; }

    public string name { get; set; } = null!;

    [StringLength(26)]
    public string preference { get; set; } = null!;

    [StringLength(15)]
    public string uom { get; set; } = null!;

    public bool isActive { get; set; }

    [StringLength(26)]
    public string objectStateDefinition { get; set; } = null!;

    [StringLength(26)]
    public string? color { get; set; }

    [StringLength(256)]
    public string? imageURL { get; set; }

    public int? Index { get; set; }
}
