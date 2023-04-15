using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("IdSetting", Schema = "common")]
[Index("code", Name = "IX_IdSetting", IsUnique = true)]
public partial class IdSetting
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(26)]
    public string idDefinition { get; set; } = null!;

    public int startFrom { get; set; }

    public bool isFlexible { get; set; }

    [StringLength(26)]
    public string? device { get; set; }

    [StringLength(26)]
    public string? organizationUnit { get; set; }

    public int currentValue { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("device")]
    [InverseProperty("IdSettings")]
    public virtual Device? deviceNavigation { get; set; }

    [ForeignKey("idDefinition")]
    [InverseProperty("IdSettings")]
    public virtual IdDefinition idDefinitionNavigation { get; set; } = null!;

    [ForeignKey("organizationUnit")]
    [InverseProperty("IdSettings")]
    public virtual OrganizationUnit? organizationUnitNavigation { get; set; }

    [ForeignKey("reference")]
    [InverseProperty("IdSettings")]
    public virtual Organization reference1 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("IdSettings")]
    public virtual Person reference2 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("IdSettings")]
    public virtual Article referenceNavigation { get; set; } = null!;
}
