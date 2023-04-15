using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_EventView
{
    [StringLength(26)]
    public string parentCode { get; set; } = null!;

    public string parentDescription { get; set; } = null!;

    public int parentGsl { get; set; }

    [StringLength(15)]
    public string parentUom { get; set; } = null!;

    [StringLength(26)]
    public string parentPreference { get; set; } = null!;

    [StringLength(26)]
    public string? childCode { get; set; }

    public string? childDescription { get; set; }

    [StringLength(26)]
    public string? childPrefence { get; set; }

    [StringLength(15)]
    public string? childUom { get; set; }

    public int? childGsl { get; set; }

    [StringLength(26)]
    public string? relationType { get; set; }

    public string? note { get; set; }

    [StringLength(26)]
    public string valuecode { get; set; } = null!;

    [StringLength(50)]
    public string? description { get; set; }

    [Column(TypeName = "money")]
    public decimal value { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? min { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? max { get; set; }

    [StringLength(256)]
    public string? url { get; set; }

    [StringLength(26)]
    public string objectStateDefinition { get; set; } = null!;
}
