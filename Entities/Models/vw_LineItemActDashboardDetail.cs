using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_LineItemActDashboardDetail
{
    [StringLength(26)]
    public string lineItemCode { get; set; } = null!;

    [StringLength(26)]
    public string? voucherCode { get; set; }

    public int? voucherDefinition { get; set; }

    [StringLength(26)]
    public string? consigneeCode { get; set; }

    public string? consigneeName { get; set; }

    [StringLength(20)]
    public string? TIN { get; set; }

    public string? telephone { get; set; }

    [StringLength(26)]
    public string? vouchExtOne { get; set; }

    [StringLength(50)]
    public string? vouchExtDescOne { get; set; }

    [StringLength(26)]
    public string? vouchExtNumberOne { get; set; }

    [StringLength(26)]
    public string? vouchExtSecond { get; set; }

    [StringLength(50)]
    public string? vouchExtDescSecond { get; set; }

    [StringLength(26)]
    public string? vouchExtNumberSecond { get; set; }

    [StringLength(26)]
    public string? vouchExtThird { get; set; }

    [StringLength(50)]
    public string? vouchExtDescThird { get; set; }

    [StringLength(26)]
    public string? vouchExtNumberThird { get; set; }

    [StringLength(26)]
    public string? vouchExtFourth { get; set; }

    [StringLength(50)]
    public string? vouchExtDescFourth { get; set; }

    [StringLength(26)]
    public string? vouchExtNumberFourth { get; set; }

    [StringLength(26)]
    public string articleCode { get; set; } = null!;

    public string articleName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? startTimStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? endTimStamp { get; set; }

    public int standardTimeValue { get; set; }

    [StringLength(56)]
    [Unicode(false)]
    public string? standardTimeFactor { get; set; }

    [StringLength(68)]
    [Unicode(false)]
    public string? TotalTime { get; set; }

    [StringLength(26)]
    public string? userCode { get; set; }

    [StringLength(30)]
    public string? userName { get; set; }

    [StringLength(115)]
    public string? technicianName { get; set; }

    [StringLength(100)]
    public string? reason { get; set; }

    [StringLength(26)]
    public string? voucher { get; set; }

    [StringLength(26)]
    public string? lineItemExtOne { get; set; }

    [StringLength(50)]
    public string? lineItemExtDescOne { get; set; }

    public string? lineItemExtNumberOne { get; set; }

    [StringLength(26)]
    public string? lineItemExtSecond { get; set; }

    [StringLength(50)]
    public string? lineItemExtDescSecond { get; set; }

    public string? lineItemExtNumberSecond { get; set; }

    [StringLength(26)]
    public string? lineItemExtThird { get; set; }

    [StringLength(50)]
    public string? lineItemExtDescThird { get; set; }

    public string? lineItemExtNumberThird { get; set; }

    [StringLength(26)]
    public string? lineItemExtFourth { get; set; }

    [StringLength(50)]
    public string? lineItemExtDescFourth { get; set; }

    public string? lineItemExtNumberFourth { get; set; }
}
