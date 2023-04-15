using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class IdDefinationView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string component { get; set; } = null!;

    [StringLength(100)]
    public string? description { get; set; }

    public int length { get; set; }

    [StringLength(8)]
    public string? prefix { get; set; }

    [StringLength(1)]
    public string? prefixSeparator { get; set; }

    [StringLength(4)]
    public string? suffix { get; set; }

    [StringLength(1)]
    public string? suffixSeparator { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [StringLength(100)]
    public string? VDefAssignedTo { get; set; }

    [StringLength(50)]
    public string? GSLAssginedTo { get; set; }
}
