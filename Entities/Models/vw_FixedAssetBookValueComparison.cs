using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_FixedAssetBookValueComparison
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    public string name { get; set; } = null!;

    [StringLength(26)]
    public string preference { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? lineitemDepreciation { get; set; }

    [Column(TypeName = "money")]
    public decimal bookValue { get; set; }

    [Column(TypeName = "money")]
    public decimal? difference { get; set; }
}
