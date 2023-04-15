using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("RateCodeDetailGuestCount", Schema = "PMS")]
public partial class RateCodeDetailGuestCount
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string rateCodeDetail { get; set; } = null!;

    public bool isAdult { get; set; }

    public int guestCount { get; set; }

    [Column(TypeName = "money")]
    public decimal amount { get; set; }

    [StringLength(50)]
    public string? remark { get; set; }

    [ForeignKey("rateCodeDetail")]
    [InverseProperty("RateCodeDetailGuestCounts")]
    public virtual RateCodeDetail rateCodeDetailNavigation { get; set; } = null!;
}
