using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("ClosedRelation", Schema = "common")]
[Index("code", Name = "IX_ClosedRelation", IsUnique = true)]
public partial class ClosedRelation
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime timeStamp { get; set; }

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    public int referredVoucherDefn { get; set; }

    public int referringVoucherDefn { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("referredVoucherDefn")]
    [InverseProperty("ClosedRelationreferredVoucherDefnNavigations")]
    public virtual VoucherDefinition referredVoucherDefnNavigation { get; set; } = null!;

    [ForeignKey("referringVoucherDefn")]
    [InverseProperty("ClosedRelationreferringVoucherDefnNavigations")]
    public virtual VoucherDefinition referringVoucherDefnNavigation { get; set; } = null!;

    [ForeignKey("voucher")]
    [InverseProperty("ClosedRelations")]
    public virtual Voucher voucherNavigation { get; set; } = null!;
}
