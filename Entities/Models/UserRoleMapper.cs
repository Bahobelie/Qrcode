using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("UserRoleMapper", Schema = "common")]
[Index("code", Name = "IX_UserRoleMapper", IsUnique = true)]
public partial class UserRoleMapper
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string user { get; set; } = null!;

    [StringLength(26)]
    public string role { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime expiryDate { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("role")]
    [InverseProperty("UserRoleMappers")]
    public virtual RoleActivity roleNavigation { get; set; } = null!;

    [ForeignKey("user")]
    [InverseProperty("UserRoleMappers")]
    public virtual User userNavigation { get; set; } = null!;
}
