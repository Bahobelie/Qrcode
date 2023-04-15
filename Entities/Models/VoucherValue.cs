using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("VoucherValues", Schema = "common")]
[Index("code", Name = "IX_VoucherValues", IsUnique = true)]
[Index("voucher", "code", Name = "_dta_index_VoucherValues_5_1624392856__K3_K2_4_5")]
public partial class VoucherValue
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? discount { get; set; }

    [Column(TypeName = "money")]
    public decimal? subTotal { get; set; }

    [Column(TypeName = "money")]
    public decimal? additionalCharge { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("voucher")]
    [InverseProperty("VoucherValues")]
    public virtual Voucher voucherNavigation { get; set; } = null!;
}
