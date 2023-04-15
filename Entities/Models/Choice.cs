using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Choice", Schema = "common")]
public partial class Choice
{
    public Guid? Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(50)]
    public string? question { get; set; }

    [StringLength(50)]
    public string? symbol { get; set; }

    [StringLength(50)]
    public string? description { get; set; }

    [StringLength(50)]
    public string? hint { get; set; }

    [StringLength(50)]
    public string? point { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }
}
