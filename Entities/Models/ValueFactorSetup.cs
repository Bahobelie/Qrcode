using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("ValueFactorSetup", Schema = "common")]
[Index("Id", Name = "Value_Factor_Setup_Vdef_Index")]
public partial class ValueFactorSetup
{
    public Guid Id { get; set; }

    [StringLength(26)]
    public string Code { get; set; } = null!;

    [StringLength(26)]
    public string valueFactorDefinition { get; set; } = null!;

    [Key]
    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string? source { get; set; }

    [StringLength(26)]
    public string? destination { get; set; }

    [StringLength(100)]
    public string? Remark { get; set; }

    [ForeignKey("valueFactorDefinition")]
    [InverseProperty("ValueFactorSetups")]
    public virtual ValueFactorDefinition valueFactorDefinitionNavigation { get; set; } = null!;

    [ForeignKey("voucherDefinition")]
    [InverseProperty("ValueFactorSetup")]
    public virtual VoucherDefinition voucherDefinitionNavigation { get; set; } = null!;
}
