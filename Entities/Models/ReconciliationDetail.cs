using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("ReconciliationDetail", Schema = "common")]
[Index("code", Name = "IX_ReconciliationDetail", IsUnique = true)]
public partial class ReconciliationDetail
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string reconSum { get; set; } = null!;

    public int voucherDefnition { get; set; }

    public bool isDebit { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("reconSum")]
    [InverseProperty("ReconciliationDetails")]
    public virtual ReconciliationSummary reconSumNavigation { get; set; } = null!;

    [ForeignKey("voucherDefnition")]
    [InverseProperty("ReconciliationDetails")]
    public virtual VoucherDefinition voucherDefnitionNavigation { get; set; } = null!;
}
