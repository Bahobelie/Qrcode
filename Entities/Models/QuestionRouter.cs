using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("QuestionRouter", Schema = "common")]
public partial class QuestionRouter
{
    public Guid? Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? choice { get; set; }

    [StringLength(50)]
    public string? question { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }
}
