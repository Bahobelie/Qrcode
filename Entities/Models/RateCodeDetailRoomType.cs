using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("RateCodeDetailRoomType", Schema = "PMS")]
public partial class RateCodeDetailRoomType
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string rateCodeDetail { get; set; } = null!;

    [StringLength(26)]
    public string roomType { get; set; } = null!;

    [StringLength(50)]
    public string? remark { get; set; }

    [ForeignKey("rateCodeDetail")]
    [InverseProperty("RateCodeDetailRoomTypes")]
    public virtual RateCodeDetail rateCodeDetailNavigation { get; set; } = null!;

    [ForeignKey("roomType")]
    [InverseProperty("RateCodeDetailRoomTypes")]
    public virtual RoomType roomTypeNavigation { get; set; } = null!;
}
