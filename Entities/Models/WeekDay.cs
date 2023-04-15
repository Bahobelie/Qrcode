using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("WeekDays", Schema = "PMS")]
public partial class WeekDay
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(10)]
    public string day { get; set; } = null!;

    [StringLength(26)]
    public string component { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(50)]
    public string? remark { get; set; }

    [ForeignKey("component")]
    [InverseProperty("WeekDays")]
    public virtual CNETComponent componentNavigation { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("WeekDays")]
    public virtual RateCodeHeader reference1 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("WeekDays")]
    public virtual RateStrategy reference2 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("WeekDays")]
    public virtual PackageDetail referenceNavigation { get; set; } = null!;
}
