using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("FieldFormat", Schema = "common")]
[Index("code", Name = "IX_FieldFormat", IsUnique = true)]
public partial class FieldFormat
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(100)]
    public string objectComponent { get; set; } = null!;

    /// <summary>
    /// Can Be:GSLTypeList (common),Report (common),Voucher (common)
    /// </summary>
    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(100)]
    public string? viewComponent { get; set; }

    [StringLength(100)]
    public string fieldComponent { get; set; } = null!;

    public byte index { get; set; }

    public int? width { get; set; }

    [StringLength(26)]
    public string? font { get; set; }

    [StringLength(26)]
    public string? color { get; set; }

    [StringLength(40)]
    public string? caption { get; set; }

    public bool isRequired { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("reference")]
    [InverseProperty("FieldFormats")]
    public virtual Voucher referenceNavigation { get; set; } = null!;

    [ForeignKey("type")]
    [InverseProperty("FieldFormats")]
    public virtual Lookup typeNavigation { get; set; } = null!;
}
