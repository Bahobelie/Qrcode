using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_Industry
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    public string tradeName { get; set; } = null!;

    public string? brandName { get; set; }

    [StringLength(26)]
    public string? preference { get; set; }

    [StringLength(100)]
    public string? classification { get; set; }

    [StringLength(26)]
    public string industry { get; set; } = null!;

    public string TIN { get; set; } = null!;

    [StringLength(256)]
    public string? url { get; set; }

    public string connectionString { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? issueDate { get; set; }

    public string? rating { get; set; }

    public int ratingCount { get; set; }
}
