using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("PhysicalDimension", Schema = "common")]
[Index("code", Name = "IX_PhysicalDimension", IsUnique = true)]
public partial class PhysicalDimension
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string article { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal length { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal width { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal height { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal weight { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("article")]
    [InverseProperty("PhysicalDimensions")]
    public virtual Article articleNavigation { get; set; } = null!;
}
