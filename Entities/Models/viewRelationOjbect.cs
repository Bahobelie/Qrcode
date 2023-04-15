using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class viewRelationOjbect
{
    [StringLength(26)]
    public string RelationCode { get; set; } = null!;

    [StringLength(26)]
    public string relationType { get; set; } = null!;

    [StringLength(26)]
    public string referenceObject { get; set; } = null!;

    [StringLength(26)]
    public string referringObject { get; set; } = null!;

    [StringLength(25)]
    public string? relationLevel { get; set; }

    [StringLength(26)]
    public string RelationalStateCode { get; set; } = null!;

    [StringLength(26)]
    public string relation { get; set; } = null!;

    [StringLength(26)]
    public string state { get; set; } = null!;

    [StringLength(20)]
    public string? criteria { get; set; }
}
