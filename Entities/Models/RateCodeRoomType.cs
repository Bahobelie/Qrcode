using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("RateCodeRoomTypes", Schema = "PMS")]
public partial class RateCodeRoomType
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string roomType { get; set; } = null!;

    [StringLength(26)]
    public string rateCode { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("rateCode")]
    [InverseProperty("RateCodeRoomTypes")]
    public virtual RateCodeHeader rateCodeNavigation { get; set; } = null!;

    [ForeignKey("roomType")]
    [InverseProperty("RateCodeRoomTypes")]
    public virtual RoomType roomTypeNavigation { get; set; } = null!;
}
