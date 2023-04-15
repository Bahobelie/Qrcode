using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("ValueFactorDefinition", Schema = "common")]
[Index("code", Name = "IX_ValueFactorDefinition", IsUnique = true)]
public partial class ValueFactorDefinition
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    public bool isPercent { get; set; }

    public double value { get; set; }

    public int? typeList { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("ValueFactorDefinitionNavigation")]
    public virtual ICollection<DiscountFactor> DiscountFactors { get; } = new List<DiscountFactor>();

    [InverseProperty("valueFactorDefinitionNavigation")]
    public virtual ICollection<PreferenceValueFactor> PreferenceValueFactors { get; } = new List<PreferenceValueFactor>();

    [InverseProperty("valueFactorDefinitionNavigation")]
    public virtual ICollection<ValueFactorSetup> ValueFactorSetups { get; } = new List<ValueFactorSetup>();
}
