using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("GSLTax", Schema = "common")]
[Index("code", Name = "IX_GSLTax", IsUnique = true)]
public partial class GSLTax
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    /// <summary>
    /// Can Be:Article (common),Organization (common),Person (common),Tax (common)
    /// </summary>
    [StringLength(26)]
    public string reference { get; set; } = null!;

    public int tax { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("reference")]
    [InverseProperty("GSLTaxes")]
    public virtual Organization reference1 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("GSLTaxes")]
    public virtual Person reference2 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("GSLTaxes")]
    public virtual Article referenceNavigation { get; set; } = null!;

    [ForeignKey("tax")]
    [InverseProperty("GSLTaxes")]
    public virtual Tax taxNavigation { get; set; } = null!;
}
