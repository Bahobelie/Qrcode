using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Question", Schema = "common")]
public partial class Question
{
    public Guid? Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int? index { get; set; }

    [StringLength(50)]
    public string? description { get; set; }

    [StringLength(50)]
    public string? category { get; set; }

    [StringLength(50)]
    public string? topic { get; set; }

    [StringLength(50)]
    public string? level { get; set; }

    [StringLength(50)]
    public string? type { get; set; }

    [StringLength(50)]
    public string? appearance { get; set; }

    [StringLength(50)]
    public string? point { get; set; }

    public bool? allowFraction { get; set; }

    [StringLength(50)]
    public string? timeRequired { get; set; }

    [StringLength(50)]
    public string? hint { get; set; }

    [StringLength(50)]
    public string? isActive { get; set; }

    [StringLength(26)]
    public string? lastState { get; set; }

    [StringLength(26)]
    public string? lastActivity { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("codeNavigation")]
    public virtual AnswerKey? AnswerKey { get; set; }
}
