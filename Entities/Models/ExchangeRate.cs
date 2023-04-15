using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("ExchangeRate", Schema = "common")]
[Index("code", Name = "IX_ExchangeRate", IsUnique = true)]
public partial class ExchangeRate
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime date { get; set; }

    [StringLength(26)]
    public string currency { get; set; } = null!;

    [Column(TypeName = "smallmoney")]
    public decimal buying { get; set; }

    [Column(TypeName = "smallmoney")]
    public decimal selling { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("currency")]
    [InverseProperty("ExchangeRates")]
    public virtual Currency currencyNavigation { get; set; } = null!;
}
