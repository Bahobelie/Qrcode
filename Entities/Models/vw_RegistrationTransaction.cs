using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_RegistrationTransaction
{
    [StringLength(26)]
    public string regNo { get; set; } = null!;

    public int? voucherDefinition { get; set; }

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(26)]
    public string? consignee { get; set; }

    [StringLength(26)]
    public string? regState { get; set; }

    [StringLength(26)]
    public string? title { get; set; }

    public string? name { get; set; }

    public string firstName { get; set; } = null!;

    [StringLength(20)]
    public string? middleName { get; set; }

    [StringLength(20)]
    public string? lastName { get; set; }

    [StringLength(26)]
    public string? room { get; set; }

    [Column(TypeName = "date")]
    public DateTime? Date { get; set; }

    [StringLength(50)]
    public string? roomNo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? arrivalDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? departureDate { get; set; }

    [StringLength(26)]
    public string? resType { get; set; }

    public string? resTypeDesc { get; set; }

    [StringLength(26)]
    public string? paymentType { get; set; }

    public string? paymentTypeDesc { get; set; }

    [StringLength(26)]
    public string? paymentProcesser { get; set; }

    [StringLength(26)]
    public string? company { get; set; }

    public string? tradeName { get; set; }

    public string? brandName { get; set; }

    [StringLength(26)]
    public string? payment { get; set; }

    public bool? IsVoid { get; set; }

    public bool? IsIssued { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? IssuedDate { get; set; }

    [Column(TypeName = "money")]
    public decimal? grandTotal { get; set; }

    public string? note { get; set; }

    [StringLength(26)]
    public string? paymentMethod { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? NonCashIssueData { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? maturityDate { get; set; }

    [StringLength(50)]
    public string? number { get; set; }

    [StringLength(26)]
    public string? currencyCode { get; set; }

    [Column(TypeName = "money")]
    public decimal? rate { get; set; }

    [Column(TypeName = "money")]
    public decimal? amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? total { get; set; }

    [StringLength(26)]
    public string? referening { get; set; }
}
