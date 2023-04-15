using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_RelationDetail
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string referenceObject { get; set; } = null!;

    [StringLength(26)]
    public string referringObject { get; set; } = null!;

    [StringLength(25)]
    public string? relationLevel { get; set; }

    [StringLength(26)]
    public string relationType { get; set; } = null!;

    [Column("operator")]
    public int _operator { get; set; }

    public int? voucherDefn { get; set; }
}
