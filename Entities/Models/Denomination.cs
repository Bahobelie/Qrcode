using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Denomination", Schema = "common")]
[Index("code", Name = "IX_Denomination", IsUnique = true)]
public partial class Denomination
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string currency { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal weight { get; set; }

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("currency")]
    [InverseProperty("Denominations")]
    public virtual Currency currencyNavigation { get; set; } = null!;
}
