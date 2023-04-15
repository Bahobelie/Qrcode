using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("RateCodePackages", Schema = "PMS")]
public partial class RateCodePackage
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string Code { get; set; } = null!;

    [StringLength(26)]
    public string rateCodeHeader { get; set; } = null!;

    [StringLength(26)]
    public string packageHeader { get; set; } = null!;

    public bool packageIncluded { get; set; }

    public double quantity { get; set; }

    [StringLength(50)]
    public string? remark { get; set; }

    [ForeignKey("packageHeader")]
    [InverseProperty("RateCodePackages")]
    public virtual PackageHeader packageHeaderNavigation { get; set; } = null!;

    [ForeignKey("rateCodeHeader")]
    [InverseProperty("RateCodePackages")]
    public virtual RateCodeHeader rateCodeHeaderNavigation { get; set; } = null!;
}
