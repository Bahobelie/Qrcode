using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_VoucherHeaderWithRoomNo
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? consignee { get; set; }

    public string? name { get; set; }

    [StringLength(26)]
    public string companycode { get; set; } = null!;

    public string company { get; set; } = null!;

    public int gslType { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    public bool IsIssued { get; set; }

    public bool IsVoid { get; set; }

    public int voucherDefinition { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [StringLength(26)]
    public string? period { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    [StringLength(26)]
    public string voType { get; set; } = null!;

    public string voTypeDesc { get; set; } = null!;

    [StringLength(26)]
    public string? device { get; set; }

    [StringLength(26)]
    public string? user { get; set; }

    [StringLength(30)]
    public string? userName { get; set; }

    public string? deviceName { get; set; }

    [StringLength(26)]
    public string? OrgUnitDef { get; set; }

    [StringLength(50)]
    public string? OrgUnitDefDescription { get; set; }

    [StringLength(50)]
    public string LastObjectStateDesc { get; set; } = null!;

    [StringLength(26)]
    public string? color { get; set; }

    [StringLength(26)]
    public string? font { get; set; }

    public string? periodName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? periodStart { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? periodEnd { get; set; }

    [Column(TypeName = "money")]
    public decimal? subTotal { get; set; }

    [Column(TypeName = "money")]
    public decimal additionalCharge { get; set; }

    [Column(TypeName = "money")]
    public decimal discount { get; set; }

    public string? note { get; set; }

    [Column(TypeName = "money")]
    public decimal taxAmount { get; set; }

    public int taxType { get; set; }

    [StringLength(26)]
    public string? voExtTranNumber { get; set; }

    [StringLength(26)]
    public string? voExtType { get; set; }

    [StringLength(50)]
    public string? voExtDesc { get; set; }

    [StringLength(50)]
    public string? RoomNumber { get; set; }

    [StringLength(26)]
    public string? room { get; set; }

    public string? tradeName { get; set; }

    [StringLength(26)]
    public string? actualRTC { get; set; }

    [StringLength(26)]
    public string? foStatus { get; set; }

    [StringLength(26)]
    public string? RegNumber { get; set; }

    [StringLength(50)]
    public string? RoomTypeDescription { get; set; }

    public string? PaymentMethod { get; set; }

    [StringLength(50)]
    public string? relationType { get; set; }

    [Column(TypeName = "money")]
    public decimal tranRefValue { get; set; }

    [StringLength(100)]
    public string? tranRefRemark { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? arrivalDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? departureDate { get; set; }
}
