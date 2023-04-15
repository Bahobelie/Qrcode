using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("BankAccountDetail", Schema = "common")]
public partial class BankAccountDetail
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    /// <summary>
    /// Can Be: BankAccountDetail (common),Person (common)
    /// </summary>
    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(50)]
    public string? description { get; set; }

    [StringLength(50)]
    public string type { get; set; } = null!;

    [StringLength(50)]
    public string? category { get; set; }

    [StringLength(26)]
    public string bank { get; set; } = null!;

    [StringLength(40)]
    public string accountNo { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("reference")]
    [InverseProperty("BankAccountDetails")]
    public virtual Person reference1 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("BankAccountDetails")]
    public virtual Organization referenceNavigation { get; set; } = null!;
}
