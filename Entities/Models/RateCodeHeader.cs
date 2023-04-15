using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("RateCodeHeader", Schema = "PMS")]
public partial class RateCodeHeader
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [StringLength(26)]
    public string article { get; set; } = null!;

    [StringLength(26)]
    public string? category { get; set; }

    [Column(TypeName = "date")]
    public DateTime? startDate { get; set; }

    [Column(TypeName = "date")]
    public DateTime? endDate { get; set; }

    [StringLength(20)]
    public string? folioText { get; set; }

    [StringLength(26)]
    public string? market { get; set; }

    [StringLength(26)]
    public string? source { get; set; }

    [Column(TypeName = "money")]
    public decimal? commission { get; set; }

    public int? minOccupancy { get; set; }

    public int? maxOccupancy { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? addition { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? multiplication { get; set; }

    [StringLength(26)]
    public string? currencyCode { get; set; }

    [StringLength(26)]
    public string? exchangeRule { get; set; }

    public string? remark { get; set; }

    [InverseProperty("rateCodeNavigation")]
    public virtual ICollection<NegotiatedRate> NegotiatedRates { get; } = new List<NegotiatedRate>();

    [InverseProperty("rateCodeHeaderNavigation")]
    public virtual ICollection<RateCodeDetail> RateCodeDetails { get; } = new List<RateCodeDetail>();

    [InverseProperty("rateCodeHeaderNavigation")]
    public virtual ICollection<RateCodePackage> RateCodePackages { get; } = new List<RateCodePackage>();

    [InverseProperty("rateCodeNavigation")]
    public virtual ICollection<RateCodeRateStrategy> RateCodeRateStrategies { get; } = new List<RateCodeRateStrategy>();

    [InverseProperty("rateCodeNavigation")]
    public virtual ICollection<RateCodeRoomType> RateCodeRoomTypes { get; } = new List<RateCodeRoomType>();

    [InverseProperty("rateCodeNavigation")]
    public virtual ICollection<RateComponent> RateComponents { get; } = new List<RateComponent>();

    [InverseProperty("rateCodeNavigation")]
    public virtual ICollection<RatePackage> RatePackages { get; } = new List<RatePackage>();

    [InverseProperty("rateCodeNavigation")]
    public virtual ICollection<Rate> Rates { get; } = new List<Rate>();

    [InverseProperty("reference1")]
    public virtual ICollection<WeekDay> WeekDays { get; } = new List<WeekDay>();
}
