using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("RoomType", Schema = "PMS")]
public partial class RoomType
{
    public Guid? id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    public int? numberOfRooms { get; set; }

    [StringLength(26)]
    public string? roomClass { get; set; }

    public int? index { get; set; }

    public int? defaultOccupancy { get; set; }

    public int? maxOccupancy { get; set; }

    public int? maxAdults { get; set; }

    public int? maxChildren { get; set; }

    public bool? isPseudoRoom { get; set; }

    [StringLength(26)]
    public string? ComponentRoomType { get; set; }

    public bool? isHousekeeping { get; set; }

    public bool? canBeMeetingRoom { get; set; }

    public bool? autoRoomAssign { get; set; }

    public bool isActive { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? activationDate { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("roomTypeNavigation")]
    public virtual ICollection<RateCodeDetailRoomType> RateCodeDetailRoomTypes { get; } = new List<RateCodeDetailRoomType>();

    [InverseProperty("roomTypeNavigation")]
    public virtual ICollection<RateCodeRoomType> RateCodeRoomTypes { get; } = new List<RateCodeRoomType>();

    [InverseProperty("roomTypeNavigation")]
    public virtual ICollection<RoomDetail> RoomDetails { get; } = new List<RoomDetail>();

    [InverseProperty("referenceNavigation")]
    public virtual ICollection<RoomFeature> RoomFeatures { get; } = new List<RoomFeature>();

    [InverseProperty("roomTypeNavigation")]
    public virtual ICollection<RoomTypeRateStrategy> RoomTypeRateStrategies { get; } = new List<RoomTypeRateStrategy>();

    [ForeignKey("roomClass")]
    [InverseProperty("RoomTypes")]
    public virtual Lookup? roomClassNavigation { get; set; }
}
