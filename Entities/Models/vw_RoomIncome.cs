using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_RoomIncome
{
    [StringLength(100)]
    public string? voucher { get; set; }

    [StringLength(26)]
    public string? consignee { get; set; }

    public string GuestName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Date { get; set; }

    [StringLength(26)]
    public string? roomType { get; set; }

    [StringLength(50)]
    public string roomTypeName { get; set; } = null!;

    [StringLength(26)]
    public string? room { get; set; }

    [StringLength(50)]
    public string? roomNo { get; set; }

    [Column(TypeName = "money")]
    public decimal? rateAmount { get; set; }

    [StringLength(26)]
    public string? rateCodeDetail { get; set; }

    [StringLength(150)]
    public string rateType { get; set; } = null!;

    [StringLength(26)]
    public string referening { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [Column(TypeName = "money")]
    public decimal? unitAmt { get; set; }

    [Column(TypeName = "money")]
    public decimal? totalAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal taxableAmount { get; set; }

    public int? tax { get; set; }

    [Column(TypeName = "money")]
    public decimal? taxAmount { get; set; }

    [StringLength(26)]
    public string? valueFactorReference { get; set; }

    public bool? isDiscount { get; set; }

    [Column(TypeName = "money")]
    public decimal valueFactorAmount { get; set; }

    [StringLength(26)]
    public string article { get; set; } = null!;

    public string name { get; set; } = null!;

    [StringLength(26)]
    public string preference { get; set; } = null!;

    [StringLength(100)]
    public string prefDescescription { get; set; } = null!;

    [Column(TypeName = "date")]
    public DateTime? regDate { get; set; }
}
