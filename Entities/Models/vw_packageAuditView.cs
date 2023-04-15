using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_packageAuditView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string referenced { get; set; } = null!;

    [StringLength(100)]
    public string? pkgHeaderCode { get; set; }

    [StringLength(50)]
    public string pkgDesc { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    public bool IsIssued { get; set; }

    public bool IsVoid { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    [StringLength(26)]
    public string? foStatus { get; set; }

    [StringLength(50)]
    public string? RoomNumber { get; set; }

    [StringLength(26)]
    public string? room { get; set; }

    [StringLength(26)]
    public string? roomType { get; set; }

    [StringLength(50)]
    public string? RoomTypeDescription { get; set; }

    [StringLength(50)]
    public string? currency { get; set; }

    public int? adult { get; set; }

    public int? child { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? arrivalDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? departureDate { get; set; }

    [StringLength(26)]
    public string? actualRTC { get; set; }

    public string? name { get; set; }
}
