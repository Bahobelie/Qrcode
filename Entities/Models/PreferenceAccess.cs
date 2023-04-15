using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("PreferenceAccess", Schema = "common")]
[Index("code", Name = "IX_PreferenceAccess", IsUnique = true)]
[Index("voucherDefn", Name = "Pref_Access_Vdef_Index")]
public partial class PreferenceAccess
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    public int voucherDefn { get; set; }

    [StringLength(26)]
    public string preference { get; set; } = null!;

    [StringLength(26)]
    public string device { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("device")]
    [InverseProperty("PreferenceAccesses")]
    public virtual Device deviceNavigation { get; set; } = null!;

    [ForeignKey("preference")]
    [InverseProperty("PreferenceAccesses")]
    public virtual Preference preferenceNavigation { get; set; } = null!;

    [ForeignKey("voucherDefn")]
    [InverseProperty("PreferenceAccesses")]
    public virtual VoucherDefinition voucherDefnNavigation { get; set; } = null!;
}
