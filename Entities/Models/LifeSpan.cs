using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("LifeSpan", Schema = "common")]
[Index("code", Name = "IX_LifeSpan", IsUnique = true)]
[Index("reference", "code", Name = "_dta_index_LifeSpan_5_1076302994__K4_K2_5_6")]
public partial class LifeSpan
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string component { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime prodDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime expiryDate { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("component")]
    [InverseProperty("LifeSpans")]
    public virtual CNETComponent componentNavigation { get; set; } = null!;
}
