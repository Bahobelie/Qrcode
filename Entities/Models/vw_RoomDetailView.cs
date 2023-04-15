using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_RoomDetailView
{
    [StringLength(26)]
    public string? LastObjectState { get; set; }

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [Column(TypeName = "date")]
    public DateTime? Date { get; set; }

    [StringLength(50)]
    public string? description { get; set; }

    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? space { get; set; }

    public int? maxOccupancy { get; set; }

    [StringLength(26)]
    public string roomType { get; set; } = null!;

    [StringLength(26)]
    public string? phoneNumber { get; set; }

    [StringLength(26)]
    public string? area { get; set; }

    public bool? isActive { get; set; }

    [StringLength(50)]
    public string? lastState { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [StringLength(50)]
    public string Expr1 { get; set; } = null!;

    public int? numberOfRooms { get; set; }

    public int? maxAdults { get; set; }

    public int? maxChildren { get; set; }

    public int? Expr2 { get; set; }

    public int? defaultOccupancy { get; set; }

    public bool? isPseudoRoom { get; set; }

    [StringLength(26)]
    public string? ComponentRoomType { get; set; }

    public bool? isHousekeeping { get; set; }

    public bool? canBeMeetingRoom { get; set; }

    public bool Expr3 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? activationDate { get; set; }

    [StringLength(200)]
    public string Expr4 { get; set; } = null!;
}
