using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Rate", Schema = "PMS")]
public partial class Rate
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime? startDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? endDate { get; set; }

    [StringLength(26)]
    public string rateCode { get; set; } = null!;

    public int? isAdult { get; set; }

    public int? guestCount { get; set; }

    [Column("rate", TypeName = "money")]
    public decimal rate1 { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("rateCode")]
    [InverseProperty("Rates")]
    public virtual RateCodeHeader rateCodeNavigation { get; set; } = null!;
}
