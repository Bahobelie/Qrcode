using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("GSLUser", Schema = "common")]
public partial class GSLUser
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string Code { get; set; } = null!;

    [StringLength(26)]
    public string Reference { get; set; } = null!;

    [StringLength(26)]
    public string Role { get; set; } = null!;

    [StringLength(26)]
    public string Type { get; set; } = null!;

    [StringLength(100)]
    public string? Remark { get; set; }

    [ForeignKey("Role")]
    [InverseProperty("GSLUsers")]
    public virtual OrganizationUnitDefinition RoleNavigation { get; set; } = null!;

    [ForeignKey("Type")]
    [InverseProperty("GSLUsers")]
    public virtual Lookup TypeNavigation { get; set; } = null!;
}
