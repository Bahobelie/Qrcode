using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("AnswerKey", Schema = "common")]
public partial class AnswerKey
{
    public Guid? id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int? index { get; set; }

    [StringLength(26)]
    public string? question { get; set; }

    [StringLength(50)]
    public string? answer { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("code")]
    [InverseProperty("AnswerKey")]
    public virtual Question codeNavigation { get; set; } = null!;
}
