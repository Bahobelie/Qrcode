using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("RoomTypeRateStrategy", Schema = "PMS")]
public partial class RoomTypeRateStrategy
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? roomType { get; set; }

    [StringLength(26)]
    public string? rateStrategy { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("rateStrategy")]
    [InverseProperty("RoomTypeRateStrategies")]
    public virtual RateStrategy? rateStrategyNavigation { get; set; }

    [ForeignKey("roomType")]
    [InverseProperty("RoomTypeRateStrategies")]
    public virtual RoomType? roomTypeNavigation { get; set; }
}
