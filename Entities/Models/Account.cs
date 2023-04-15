using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Account", Schema = "common")]
[Index("code", Name = "IX_Account", IsUnique = true)]
public partial class Account
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string controlAccount { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    public bool isActive { get; set; }

    [StringLength(26)]
    public string? parentAccount { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("AccountNavigation")]
    public virtual ICollection<AccountAction> AccountActions { get; } = new List<AccountAction>();

    [InverseProperty("parentAccountNavigation")]
    public virtual ICollection<Account> InverseparentAccountNavigation { get; } = new List<Account>();

    [ForeignKey("parentAccount")]
    [InverseProperty("InverseparentAccountNavigation")]
    public virtual Account? parentAccountNavigation { get; set; }
}
