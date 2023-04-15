using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("PackageHeader", Schema = "PMS")]
public partial class PackageHeader
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string article { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [StringLength(26)]
    public string? pakgGroup { get; set; }

    [StringLength(26)]
    public string? type { get; set; }

    [StringLength(26)]
    public string? currencyPreference { get; set; }

    public bool? sellSeparate { get; set; }

    [StringLength(26)]
    public string? postingRhythm { get; set; }

    [StringLength(26)]
    public string? calculationRule { get; set; }

    [StringLength(26)]
    public string? formula { get; set; }

    [StringLength(26)]
    public string? rateApearance { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("packageNavigation")]
    public virtual ICollection<PackageDetail> PackageDetails { get; } = new List<PackageDetail>();

    [InverseProperty("packageHeaderNavigation")]
    public virtual ICollection<PackagesToPost> PackagesToPosts { get; } = new List<PackagesToPost>();

    [InverseProperty("packageHeaderNavigation")]
    public virtual ICollection<PostingSchedule> PostingSchedules { get; } = new List<PostingSchedule>();

    [InverseProperty("packageHeaderNavigation")]
    public virtual ICollection<RateCodePackage> RateCodePackages { get; } = new List<RateCodePackage>();

    [InverseProperty("packageNavigation")]
    public virtual ICollection<RatePackage> RatePackages { get; } = new List<RatePackage>();

    [ForeignKey("article")]
    [InverseProperty("PackageHeaders")]
    public virtual Article articleNavigation { get; set; } = null!;

    [ForeignKey("calculationRule")]
    [InverseProperty("PackageHeadercalculationRuleNavigations")]
    public virtual Lookup? calculationRuleNavigation { get; set; }

    [ForeignKey("currencyPreference")]
    [InverseProperty("PackageHeaders")]
    public virtual Currency? currencyPreferenceNavigation { get; set; }

    [ForeignKey("pakgGroup")]
    [InverseProperty("PackageHeaderpakgGroupNavigations")]
    public virtual Lookup? pakgGroupNavigation { get; set; }

    [ForeignKey("postingRhythm")]
    [InverseProperty("PackageHeaderpostingRhythmNavigations")]
    public virtual Lookup? postingRhythmNavigation { get; set; }

    [ForeignKey("rateApearance")]
    [InverseProperty("PackageHeaderrateApearanceNavigations")]
    public virtual Lookup? rateApearanceNavigation { get; set; }

    [ForeignKey("type")]
    [InverseProperty("PackageHeadertypeNavigations")]
    public virtual Lookup? typeNavigation { get; set; }
}
