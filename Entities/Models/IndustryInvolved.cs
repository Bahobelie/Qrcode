using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("IndustryInvolved", Schema = "common")]
[Index("code", Name = "IX_IndustryInvolved", IsUnique = true)]
public partial class IndustryInvolved
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int index { get; set; }

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(26)]
    public string industy { get; set; } = null!;

    [StringLength(26)]
    public string? involvment { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("industryNavigation")]
    public virtual ICollection<DefaultIndustrialSetting> DefaultIndustrialSettings { get; } = new List<DefaultIndustrialSetting>();

    [ForeignKey("industy")]
    [InverseProperty("IndustryInvolvedindustyNavigations")]
    public virtual Lookup industyNavigation { get; set; } = null!;

    [ForeignKey("involvment")]
    [InverseProperty("IndustryInvolvedinvolvmentNavigations")]
    public virtual Lookup? involvmentNavigation { get; set; }

    [ForeignKey("reference")]
    [InverseProperty("IndustryInvolveds")]
    public virtual Organization reference1 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("IndustryInvolveds")]
    public virtual Person reference2 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("IndustryInvolveds")]
    public virtual Article referenceNavigation { get; set; } = null!;
}
