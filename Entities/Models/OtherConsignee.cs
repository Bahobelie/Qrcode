using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("OtherConsignees", Schema = "common")]
[Index("code", Name = "IX_OtherConsignees", IsUnique = true)]
public partial class OtherConsignee
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string requiredGSL { get; set; } = null!;

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(26)]
    public string consignee { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("consignee")]
    [InverseProperty("OtherConsignees")]
    public virtual Person consignee1 { get; set; } = null!;

    [ForeignKey("consignee")]
    [InverseProperty("OtherConsignees")]
    public virtual Organization consigneeNavigation { get; set; } = null!;

    [ForeignKey("requiredGSL")]
    [InverseProperty("OtherConsignees")]
    public virtual RequriedGSL requiredGSLNavigation { get; set; } = null!;

    [ForeignKey("voucher")]
    [InverseProperty("OtherConsignees")]
    public virtual Voucher voucherNavigation { get; set; } = null!;
}
