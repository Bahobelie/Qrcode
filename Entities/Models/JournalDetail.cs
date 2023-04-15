using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("JournalDetail", Schema = "common")]
[Index("code", Name = "IX_JournalDetail", IsUnique = true)]
public partial class JournalDetail
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(26)]
    public string account { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal debit { get; set; }

    [Column(TypeName = "money")]
    public decimal credit { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("journalDetailNavigation")]
    public virtual ICollection<JournalDetailReconcilation> JournalDetailReconcilations { get; } = new List<JournalDetailReconcilation>();

    [ForeignKey("voucher")]
    [InverseProperty("JournalDetails")]
    public virtual Voucher voucherNavigation { get; set; } = null!;
}
