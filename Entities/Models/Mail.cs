using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Mail", Schema = "common")]
[Index("code", Name = "IX_Mail", IsUnique = true)]
public partial class Mail
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    public string to { get; set; } = null!;

    public string? from { get; set; }

    public string? Cc { get; set; }

    public string? bcc { get; set; }

    [StringLength(100)]
    public string? subject { get; set; }

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("voucher")]
    [InverseProperty("Mail")]
    public virtual Voucher voucherNavigation { get; set; } = null!;
}
