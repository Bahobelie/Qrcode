using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class db__vw_RelationDetal
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

    public int? voucherDefn { get; set; }
}
