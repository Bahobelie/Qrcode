using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Lookup")]
public partial class Lookup1
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int index { get; set; }

    [StringLength(50)]
    public string component { get; set; } = null!;

    [StringLength(75)]
    public string type { get; set; } = null!;

    public string description { get; set; } = null!;

    [StringLength(40)]
    public string? value { get; set; }

    public bool isDefault { get; set; }

    public bool isActive { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }
}
