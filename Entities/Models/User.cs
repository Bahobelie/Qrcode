using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("User", Schema = "common")]
[Index("code", Name = "IX_User", IsUnique = true)]
public partial class User
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    public bool isActive { get; set; }

    [StringLength(26)]
    public string person { get; set; } = null!;

    [StringLength(30)]
    public string userName { get; set; } = null!;

    [StringLength(200)]
    public string passWord { get; set; } = null!;

    public int? loggedInStatus { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("userNavigation")]
    public virtual ICollection<Activity> Activities { get; } = new List<Activity>();

    [InverseProperty("DelegatedNavigation")]
    public virtual ICollection<Delegate> DelegateDelegatedNavigations { get; } = new List<Delegate>();

    [InverseProperty("DelegatingNavigation")]
    public virtual ICollection<Delegate> DelegateDelegatingNavigations { get; } = new List<Delegate>();

    [InverseProperty("userNavigation")]
    public virtual ICollection<UserRoleMapper> UserRoleMappers { get; } = new List<UserRoleMapper>();

    [ForeignKey("person")]
    [InverseProperty("Users")]
    public virtual Person personNavigation { get; set; } = null!;
}
