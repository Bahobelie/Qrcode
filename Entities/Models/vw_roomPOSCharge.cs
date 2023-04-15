using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_roomPOSCharge
{
    [Column(TypeName = "money")]
    public decimal value { get; set; }

    [StringLength(26)]
    public string referening { get; set; } = null!;

    [StringLength(26)]
    public string referenced { get; set; } = null!;

    public int voucherDefinition { get; set; }

    public string? note { get; set; }

    public bool IsIssued { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    public bool IsVoid { get; set; }

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    [StringLength(26)]
    public string? lastActivity { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [StringLength(50)]
    public string? roomType { get; set; }

    [StringLength(26)]
    public string? RoomDetailcode { get; set; }

    [StringLength(50)]
    public string? room { get; set; }

    public string? company { get; set; }

    public string? name { get; set; }
}
