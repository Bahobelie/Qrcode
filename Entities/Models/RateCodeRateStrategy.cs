using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("RateCodeRateStrategy", Schema = "PMS")]
public partial class RateCodeRateStrategy
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? rateCode { get; set; }

    [StringLength(26)]
    public string? rateStrategy { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("rateCode")]
    [InverseProperty("RateCodeRateStrategies")]
    public virtual RateCodeHeader? rateCodeNavigation { get; set; }

    [ForeignKey("rateStrategy")]
    [InverseProperty("RateCodeRateStrategies")]
    public virtual RateStrategy? rateStrategyNavigation { get; set; }
}
