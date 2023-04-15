using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("RatePackages", Schema = "PMS")]
public partial class RatePackage
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string rateCode { get; set; } = null!;

    [StringLength(26)]
    public string package { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("package")]
    [InverseProperty("RatePackages")]
    public virtual PackageHeader packageNavigation { get; set; } = null!;

    [ForeignKey("rateCode")]
    [InverseProperty("RatePackages")]
    public virtual RateCodeHeader rateCodeNavigation { get; set; } = null!;
}
