using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("GSLAddressMap", Schema = "common")]
public partial class GSLAddressMap
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int gslType { get; set; }

    [StringLength(26)]
    public string? prefrrence { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }
}
