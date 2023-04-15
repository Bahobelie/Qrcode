using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Value", Schema = "common")]
[Index("code", Name = "IX_Value", IsUnique = true)]
public partial class Value
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string article { get; set; } = null!;

    [StringLength(50)]
    public string? description { get; set; }

    [StringLength(26)]
    public string? component { get; set; }

    [StringLength(26)]
    public string? reference { get; set; }

    [Column(TypeName = "money")]
    public decimal priceValue { get; set; }

    public bool isDefault { get; set; }

    [StringLength(26)]
    public string currency { get; set; } = null!;

    public byte priority { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("article")]
    [InverseProperty("Values")]
    public virtual Article articleNavigation { get; set; } = null!;

    [ForeignKey("currency")]
    [InverseProperty("Values")]
    public virtual Currency currencyNavigation { get; set; } = null!;
}
