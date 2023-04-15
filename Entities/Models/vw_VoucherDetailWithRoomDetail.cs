using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_VoucherDetailWithRoomDetail
{
    [StringLength(50)]
    public string? RoomDescription { get; set; }

    [StringLength(26)]
    public string code { get; set; } = null!;

    public int? RoomDetailMaxOcc { get; set; }

    [StringLength(26)]
    public string RoomTypeCode { get; set; } = null!;

    [StringLength(26)]
    public string? phoneNumber { get; set; }

    public bool? RoomDetailIsActive { get; set; }

    [StringLength(50)]
    public string? RoomLastState { get; set; }

    [StringLength(100)]
    public string? RoomDetailRemark { get; set; }

    [StringLength(50)]
    public string RoomTypeDesc { get; set; } = null!;

    public bool? isPseudoRoom { get; set; }

    [StringLength(26)]
    public string? ComponentRoomType { get; set; }

    public bool? isHousekeeping { get; set; }

    public bool? canBeMeetingRoom { get; set; }

    public bool RoomTypeIsActive { get; set; }

    [StringLength(200)]
    public string? Floor { get; set; }

    public int? maxAdults { get; set; }

    public int? maxChildren { get; set; }

    public int? maxOccupancy { get; set; }

    [StringLength(50)]
    public string? LastStateDesc { get; set; }

    [StringLength(26)]
    public string? color { get; set; }

    [StringLength(26)]
    public string? RoomDetailSpace { get; set; }
}
