using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class RoomInventory_View
{
    [Column(TypeName = "date")]
    public DateTime? Date { get; set; }

    public int? adult { get; set; }

    public int? child { get; set; }

    public int? roomCount { get; set; }

    [StringLength(26)]
    public string? roomType { get; set; }

    [StringLength(26)]
    public string? room { get; set; }

    [Column(TypeName = "money")]
    public decimal? rateAmount { get; set; }

    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string consignee { get; set; } = null!;

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    [StringLength(26)]
    public string? rateCodeDetail { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? arrivalDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? departureDate { get; set; }
}
