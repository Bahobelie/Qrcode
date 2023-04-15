using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Configuration", Schema = "common")]
[Index("code", Name = "IX_Configuration", IsUnique = true)]
public partial class Configuration
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    /// <summary>
    /// Can be:
    /// </summary>
    [StringLength(26)]
    public string preference { get; set; } = null!;

    /// <summary>
    /// Can Be:Component (common),Device (common),GSLTypeList (common),Voucher (common)
    /// </summary>
    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(100)]
    public string attribute { get; set; } = null!;

    public string currentValue { get; set; } = null!;

    [StringLength(100)]
    public string? previousValue { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("reference")]
    [InverseProperty("Configurations")]
    public virtual Device reference1 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("Configurations")]
    public virtual Voucher reference2 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("Configurations")]
    public virtual CNETComponent referenceNavigation { get; set; } = null!;
}
