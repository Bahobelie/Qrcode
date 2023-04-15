using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Period", Schema = "common")]
[Index("code", Name = "IX_Period", IsUnique = true)]
public partial class Period
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    public string periodName { get; set; } = null!;

    [StringLength(26)]
    public string type { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime start { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime end { get; set; }

    [StringLength(26)]
    public string? parent { get; set; }

    public int? index { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("periodNavigation")]
    public virtual ICollection<Beginning> Beginnings { get; } = new List<Beginning>();

    [InverseProperty("actualPeriodNavigation")]
    public virtual ICollection<Holiday> HolidayactualPeriodNavigations { get; } = new List<Holiday>();

    [InverseProperty("forecastedPeriodNavigation")]
    public virtual ICollection<Holiday> HolidayforecastedPeriodNavigations { get; } = new List<Holiday>();

    [InverseProperty("periodNavigation")]
    public virtual ICollection<Plan> Plans { get; } = new List<Plan>();

    [InverseProperty("periodNavigation")]
    public virtual ICollection<SeasonalMessage> SeasonalMessages { get; } = new List<SeasonalMessage>();

    [InverseProperty("periodNavigation")]
    public virtual ICollection<StockBalance> StockBalances { get; } = new List<StockBalance>();

    [InverseProperty("periodNavigation")]
    public virtual ICollection<TrialBalance> TrialBalances { get; } = new List<TrialBalance>();

    [InverseProperty("periodNavigation")]
    public virtual ICollection<Voucher> Vouchers { get; } = new List<Voucher>();

    [ForeignKey("type")]
    [InverseProperty("Periods")]
    public virtual Lookup typeNavigation { get; set; } = null!;
}
