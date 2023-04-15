using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("VoucherTerm", Schema = "common")]
[Index("code", Name = "IX_VoucherTerm", IsUnique = true)]
public partial class VoucherTerm
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(26)]
    public string term { get; set; } = null!;

    public string? value { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("term")]
    [InverseProperty("VoucherTerms")]
    public virtual TermList termNavigation { get; set; } = null!;

    [ForeignKey("voucher")]
    [InverseProperty("VoucherTerms")]
    public virtual Voucher voucherNavigation { get; set; } = null!;
}
