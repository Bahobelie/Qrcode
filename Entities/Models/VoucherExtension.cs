using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("VoucherExtension", Schema = "common")]
[Index("code", Name = "IX_VoucherExtension", IsUnique = true)]
[Index("voucherDefn", Name = "VoucherExt_Vdef_Index")]
public partial class VoucherExtension
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int voucherDefn { get; set; }

    [StringLength(50)]
    public string description { get; set; } = null!;

    public byte Index { get; set; }

    public bool IsMandatory { get; set; }

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(20)]
    public string? ExDataType { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("voucherExtensionNavigation")]
    public virtual ICollection<LineItemExtension> LineItemExtensions { get; } = new List<LineItemExtension>();

    [InverseProperty("voucherExtensionNavigation")]
    public virtual ICollection<VoucherExtensionTransaction> VoucherExtensionTransactions { get; } = new List<VoucherExtensionTransaction>();

    [ForeignKey("type")]
    [InverseProperty("VoucherExtensions")]
    public virtual Lookup typeNavigation { get; set; } = null!;

    [ForeignKey("voucherDefn")]
    [InverseProperty("VoucherExtensions")]
    public virtual VoucherDefinition voucherDefnNavigation { get; set; } = null!;
}
