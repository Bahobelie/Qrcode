using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("MobileTransaction", Schema = "pos")]
public partial class MobileTransaction
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string CreditShortCode { get; set; } = null!;

    [StringLength(50)]
    public string ReceivingIdentityName { get; set; } = null!;

    [StringLength(26)]
    public string InitiatingMSISDN { get; set; } = null!;

    [StringLength(50)]
    public string InitiatingIdentityName { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal TransactionAmount { get; set; }

    [StringLength(50)]
    public string TimeStamp { get; set; } = null!;

    public int IsPrint { get; set; }
}
