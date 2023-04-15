using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("CurrencyPreference", Schema = "common")]
public partial class CurrencyPreference
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string Code { get; set; } = null!;

    [StringLength(26)]
    public string Currency { get; set; } = null!;

    [StringLength(26)]
    public string Reference { get; set; } = null!;

    [StringLength(100)]
    public string? Remark { get; set; }

    [ForeignKey("Currency")]
    [InverseProperty("CurrencyPreferences")]
    public virtual Currency CurrencyNavigation { get; set; } = null!;

    [ForeignKey("Reference")]
    [InverseProperty("CurrencyPreferences")]
    public virtual Organization Reference1 { get; set; } = null!;

    [ForeignKey("Reference")]
    [InverseProperty("CurrencyPreferences")]
    public virtual Person Reference2 { get; set; } = null!;

    [ForeignKey("Reference")]
    [InverseProperty("CurrencyPreferences")]
    public virtual Article ReferenceNavigation { get; set; } = null!;
}
