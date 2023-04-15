using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("PackageDetail", Schema = "PMS")]
public partial class PackageDetail
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string package { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime beginningDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime endingDate { get; set; }

    [Column(TypeName = "money")]
    public decimal? Price { get; set; }

    [Column(TypeName = "money")]
    public decimal? allowance { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("referenceNavigation")]
    public virtual ICollection<WeekDay> WeekDays { get; } = new List<WeekDay>();

    [ForeignKey("package")]
    [InverseProperty("PackageDetails")]
    public virtual PackageHeader packageNavigation { get; set; } = null!;
}
