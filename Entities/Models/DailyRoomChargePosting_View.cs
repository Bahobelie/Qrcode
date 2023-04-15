using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class DailyRoomChargePosting_View
{
    [StringLength(26)]
    public string registrationNumber { get; set; } = null!;

    [StringLength(26)]
    public string consignee { get; set; } = null!;

    [StringLength(26)]
    public string registrationDetailCode { get; set; } = null!;

    [StringLength(26)]
    public string? room { get; set; }

    public int? adult { get; set; }

    public int? child { get; set; }

    [StringLength(26)]
    public string? rateCodeDetail { get; set; }

    [StringLength(26)]
    public string? roomType { get; set; }

    [Column(TypeName = "money")]
    public decimal? rateAmount { get; set; }

    [StringLength(26)]
    public string? actualRTC { get; set; }

    public bool? isClosed { get; set; }

    [StringLength(26)]
    public string article { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    [Column(TypeName = "date")]
    public DateTime? Date { get; set; }

    [StringLength(26)]
    public string? currencyCode { get; set; }

    [StringLength(20)]
    public string? folioText { get; set; }
}
