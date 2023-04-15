using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class Voucher_Relation_View
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string referringObject { get; set; } = null!;

    [StringLength(26)]
    public string referenceObject { get; set; } = null!;

    [StringLength(26)]
    public string relationType { get; set; } = null!;

    [StringLength(100)]
    public string? reference { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string state { get; set; } = null!;

    [StringLength(20)]
    public string? type { get; set; }
}
