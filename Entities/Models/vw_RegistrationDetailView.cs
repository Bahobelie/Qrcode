using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_RegistrationDetailView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    [StringLength(26)]
    public string? consignee { get; set; }

    [StringLength(64)]
    public string? name { get; set; }

    [StringLength(20)]
    public string? firstName { get; set; }

    [StringLength(20)]
    public string? middleName { get; set; }

    [StringLength(20)]
    public string? lastName { get; set; }

    [StringLength(26)]
    public string? nationality { get; set; }

    [StringLength(20)]
    public string? idNumber { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? arrivalDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? departureDate { get; set; }

    [StringLength(26)]
    public string? resType { get; set; }

    public int? adult { get; set; }

    public int? child { get; set; }

    public int? roomCount { get; set; }

    [StringLength(26)]
    public string? roomType { get; set; }

    [StringLength(26)]
    public string? room { get; set; }

    [StringLength(26)]
    public string rateCodeHeader { get; set; } = null!;

    [StringLength(26)]
    public string? rateCodeDetail { get; set; }

    [Column(TypeName = "money")]
    public decimal? rateAmount { get; set; }

    [StringLength(26)]
    public string? actualRTC { get; set; }

    [StringLength(50)]
    public string? RoomTypeDescription { get; set; }

    [StringLength(50)]
    public string? RoomNumber { get; set; }

    [StringLength(26)]
    public string? OtherConsignee { get; set; }

    [StringLength(26)]
    public string? requiredGSL { get; set; }

    public string? tradeName { get; set; }

    public string? brandName { get; set; }

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string type { get; set; } = null!;

    public string? Market { get; set; }

    public string? PaymentMethod { get; set; }

    [StringLength(26)]
    public string? currencyCode { get; set; }

    [StringLength(8)]
    public string? CurrencyDescription { get; set; }

    public string? PersonGender { get; set; }

    [StringLength(50)]
    public string? nationalityName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DOB { get; set; }

    public string? PersonTitle { get; set; }

    [StringLength(50)]
    public string? PackageDescription { get; set; }

    [StringLength(26)]
    public string? category { get; set; }

    public string? ratePolicy { get; set; }

    [StringLength(26)]
    public string? travelType { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? travelDate { get; set; }
}
