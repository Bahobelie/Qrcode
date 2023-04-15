using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("WriteUp", Schema = "common")]
public partial class WriteUp
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? question { get; set; }

    public int? NoOfBlank { get; set; }

    public int? CharacterLength { get; set; }

    [StringLength(50)]
    public string? remark { get; set; }
}
