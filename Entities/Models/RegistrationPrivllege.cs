using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("RegistrationPrivllege", Schema = "PMS")]
public partial class RegistrationPrivllege
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    public bool? noPost { get; set; }

    public bool? authorizeDirectBill { get; set; }

    public bool? authorizeKeyReturn { get; set; }

    public bool? preStayCharging { get; set; }

    public bool? postStayCharging { get; set; }

    public bool? AllowLatecheckout { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("voucher")]
    [InverseProperty("RegistrationPrivlleges")]
    public virtual Voucher voucherNavigation { get; set; } = null!;
}
