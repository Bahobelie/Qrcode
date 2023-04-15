using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class RelationDetail_View
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string relationType { get; set; } = null!;

    [StringLength(26)]
    public string referenceObject { get; set; } = null!;

    [StringLength(26)]
    public string referringObject { get; set; } = null!;

    [StringLength(25)]
    public string? relationLevel { get; set; }

    [StringLength(50)]
    public string description { get; set; } = null!;

    public int gslCode { get; set; }

    [StringLength(26)]
    public string lookupCode { get; set; } = null!;
}
