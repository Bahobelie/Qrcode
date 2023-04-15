using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("DefaultIndustrialSetting", Schema = "common")]
public partial class DefaultIndustrialSetting
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string industry { get; set; } = null!;

    [StringLength(26)]
    public string configuration { get; set; } = null!;

    [StringLength(15)]
    public string? DefaultValue { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("industry")]
    [InverseProperty("DefaultIndustrialSettings")]
    public virtual IndustryInvolved industryNavigation { get; set; } = null!;
}
