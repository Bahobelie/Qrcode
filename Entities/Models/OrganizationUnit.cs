using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("OrganizationUnit", Schema = "common")]
[Index("code", Name = "IX_OrganizationUnit", IsUnique = true)]
public partial class OrganizationUnit
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? component { get; set; }

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(26)]
    public string organizationUnitDefinition { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("reference1")]
    public virtual ICollection<CNET_GP> CNET_GPs { get; } = new List<CNET_GP>();

    [InverseProperty("destination1")]
    public virtual ICollection<Distribution> Distributions { get; } = new List<Distribution>();

    [InverseProperty("organizationUnitNavigation")]
    public virtual ICollection<IdSetting> IdSettings { get; } = new List<IdSetting>();

    [InverseProperty("consignee1")]
    public virtual ICollection<NonCashTransaction> NonCashTransactions { get; } = new List<NonCashTransaction>();

    [ForeignKey("organizationUnitDefinition")]
    [InverseProperty("OrganizationUnits")]
    public virtual OrganizationUnitDefinition organizationUnitDefinitionNavigation { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("OrganizationUnits")]
    public virtual Organization referenceNavigation { get; set; } = null!;
}
