using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_Movie
{
    [StringLength(26)]
    public string moviecode { get; set; } = null!;

    [StringLength(26)]
    public string organizationUnit { get; set; } = null!;

    [StringLength(50)]
    public string moviename { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime date { get; set; }

    [Column(TypeName = "money")]
    public decimal pricevalue { get; set; }

    [StringLength(256)]
    public string? url { get; set; }

    [StringLength(50)]
    public string branchName { get; set; } = null!;

    [StringLength(50)]
    public string? brandName { get; set; }

    [StringLength(50)]
    public string tradeName { get; set; } = null!;

    public string? writer { get; set; }

    public string actors { get; set; } = null!;

    public string director { get; set; } = null!;

    [StringLength(26)]
    public string? startTime { get; set; }

    [StringLength(26)]
    public string? rating { get; set; }
}
