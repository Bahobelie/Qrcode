using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("DisplayOrder", Schema = "pos")]
public partial class DisplayOrder
{
    [Key]
    public int id { get; set; }

    [StringLength(26)]
    public string Component { get; set; } = null!;

    [StringLength(26)]
    public string Reference { get; set; } = null!;

    public int Index { get; set; }

    [StringLength(50)]
    public string? Remark { get; set; }
}
