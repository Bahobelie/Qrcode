using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("TimeSheet", Schema = "common")]
public partial class TimeSheet
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(26)]
    public string shift { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    public string? comment { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("reference")]
    [InverseProperty("TimeSheetreferenceNavigations")]
    public virtual Voucher referenceNavigation { get; set; } = null!;

    [ForeignKey("voucher")]
    [InverseProperty("TimeSheetvoucherNavigations")]
    public virtual Voucher voucherNavigation { get; set; } = null!;
}
