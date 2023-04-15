using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("RateComponents", Schema = "PMS")]
public partial class RateComponent
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string component { get; set; } = null!;

    [StringLength(26)]
    public string rateCode { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("component")]
    [InverseProperty("RateComponents")]
    public virtual Lookup componentNavigation { get; set; } = null!;

    [ForeignKey("rateCode")]
    [InverseProperty("RateComponents")]
    public virtual RateCodeHeader rateCodeNavigation { get; set; } = null!;
}
