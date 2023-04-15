using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("VoucherNote", Schema = "common")]
[Index("code", Name = "IX_VoucherNote", IsUnique = true)]
public partial class VoucherNote
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    public string note { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("voucher")]
    [InverseProperty("VoucherNotes")]
    public virtual Voucher voucherNavigation { get; set; } = null!;
}
