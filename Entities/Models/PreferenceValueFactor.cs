using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("PreferenceValueFactor", Schema = "common")]
public partial class PreferenceValueFactor
{
    public Guid? Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? voucher { get; set; }

    [StringLength(26)]
    public string? valueFactorDefinition { get; set; }

    [StringLength(26)]
    public string? preference { get; set; }

    [Column(TypeName = "money")]
    public decimal? amount { get; set; }

    public bool? ispercent { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("preference")]
    [InverseProperty("PreferenceValueFactors")]
    public virtual Preference? preferenceNavigation { get; set; }

    [ForeignKey("valueFactorDefinition")]
    [InverseProperty("PreferenceValueFactors")]
    public virtual ValueFactorDefinition? valueFactorDefinitionNavigation { get; set; }

    [ForeignKey("voucher")]
    [InverseProperty("PreferenceValueFactors")]
    public virtual Voucher? voucherNavigation { get; set; }
}
