using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("EscalationDetail", Schema = "Internal")]
public partial class EscalationDetail
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(26)]
    public string module { get; set; } = null!;

    [StringLength(26)]
    public string functionality { get; set; } = null!;

    [Column("case")]
    public string _case { get; set; } = null!;

    public string? solution { get; set; }

    [StringLength(26)]
    public string? assignedTo { get; set; }

    [StringLength(26)]
    public string priority { get; set; } = null!;

    [Column(TypeName = "date")]
    public DateTime? deliveryTime { get; set; }

    public string? remark { get; set; }

    [ForeignKey("assignedTo")]
    [InverseProperty("EscalationDetails")]
    public virtual Person? assignedToNavigation { get; set; }

    [ForeignKey("functionality")]
    [InverseProperty("EscalationDetailfunctionalityNavigations")]
    public virtual Lookup functionalityNavigation { get; set; } = null!;

    [ForeignKey("module")]
    [InverseProperty("EscalationDetails")]
    public virtual CNETComponent moduleNavigation { get; set; } = null!;

    [ForeignKey("priority")]
    [InverseProperty("EscalationDetailpriorityNavigations")]
    public virtual Lookup priorityNavigation { get; set; } = null!;

    [ForeignKey("voucher")]
    [InverseProperty("EscalationDetails")]
    public virtual Voucher voucherNavigation { get; set; } = null!;
}
