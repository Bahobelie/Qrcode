using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("NegotiatedRate", Schema = "PMS")]
public partial class NegotiatedRate
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string consignee { get; set; } = null!;

    [StringLength(26)]
    public string rateCode { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("consignee")]
    [InverseProperty("NegotiatedRates")]
    public virtual Person consignee1 { get; set; } = null!;

    [ForeignKey("consignee")]
    [InverseProperty("NegotiatedRates")]
    public virtual Organization consigneeNavigation { get; set; } = null!;

    [ForeignKey("rateCode")]
    [InverseProperty("NegotiatedRates")]
    public virtual RateCodeHeader rateCodeNavigation { get; set; } = null!;
}
