using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("RemovedItems", Schema = "common")]
public partial class RemovedItem
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string activity { get; set; } = null!;

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(26)]
    public string article { get; set; } = null!;

    [Column(TypeName = "decimal(18, 4)")]
    public decimal quantity { get; set; }

    [Column(TypeName = "money")]
    public decimal unitAmt { get; set; }

    [Column(TypeName = "money")]
    public decimal totalAmount { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("activity")]
    [InverseProperty("RemovedItems")]
    public virtual Activity activityNavigation { get; set; } = null!;

    [ForeignKey("article")]
    [InverseProperty("RemovedItems")]
    public virtual Article articleNavigation { get; set; } = null!;

    [ForeignKey("voucher")]
    [InverseProperty("RemovedItems")]
    public virtual Voucher voucherNavigation { get; set; } = null!;
}
