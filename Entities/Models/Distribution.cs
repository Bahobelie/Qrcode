using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Distribution", Schema = "common")]
[Index("code", Name = "IX_Distribution", IsUnique = true)]
public partial class Distribution
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    /// <summary>
    /// Can Be:GSLTypeList (common),VoucherDefinition (common)
    /// </summary>
    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(26)]
    public string indexs { get; set; } = null!;

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(50)]
    public string? description { get; set; }

    [StringLength(26)]
    public string component { get; set; } = null!;

    [StringLength(26)]
    public string destination { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("component")]
    [InverseProperty("Distributions")]
    public virtual CNETComponent componentNavigation { get; set; } = null!;

    [ForeignKey("destination")]
    [InverseProperty("Distributions")]
    public virtual OrganizationUnit destination1 { get; set; } = null!;

    [ForeignKey("destination")]
    [InverseProperty("Distributions")]
    public virtual Device destinationNavigation { get; set; } = null!;

    [ForeignKey("type")]
    [InverseProperty("Distributions")]
    public virtual Lookup typeNavigation { get; set; } = null!;
}
