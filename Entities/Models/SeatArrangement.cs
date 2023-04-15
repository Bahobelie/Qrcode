using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("SeatArrangement", Schema = "cinema")]
public partial class SeatArrangement
{
    public string id { get; set; } = null!;

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string space { get; set; } = null!;

    [StringLength(26)]
    public string type { get; set; } = null!;

    public string name { get; set; } = null!;

    [Column("class")]
    [StringLength(26)]
    public string? _class { get; set; }

    [StringLength(50)]
    public string? zone { get; set; }

    public int X { get; set; }

    public int Y { get; set; }

    public string? remark { get; set; }
}
