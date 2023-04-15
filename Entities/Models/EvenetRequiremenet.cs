using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("EvenetRequiremenet", Schema = "cnetEvent")]
public partial class EvenetRequiremenet
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? eventDetail { get; set; }

    [StringLength(26)]
    public string? voucher { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("eventDetail")]
    [InverseProperty("EvenetRequiremenets")]
    public virtual EventDetail? eventDetailNavigation { get; set; }

    [ForeignKey("voucher")]
    [InverseProperty("EvenetRequiremenets")]
    public virtual Voucher? voucherNavigation { get; set; }
}
