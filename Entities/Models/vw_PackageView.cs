using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_PackageView
{
    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(26)]
    public string? consignee { get; set; }

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    [StringLength(50)]
    public string? lastState { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? arrivalDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? departureDate { get; set; }

    [Column(TypeName = "date")]
    public DateTime? Date { get; set; }

    public int? adult { get; set; }

    public int? child { get; set; }

    [StringLength(26)]
    public string? room { get; set; }

    [StringLength(50)]
    public string? roomDesc { get; set; }

    [StringLength(26)]
    public string? rateCodeDetail { get; set; }

    [Column(TypeName = "money")]
    public decimal? rateAmount { get; set; }

    [StringLength(26)]
    public string? currencyPreference { get; set; }

    [StringLength(150)]
    public string? rateCodeDetDesc { get; set; }

    [StringLength(26)]
    public string article { get; set; } = null!;

    [StringLength(50)]
    public string packageHeaderDesc { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal pakgAmount { get; set; }

    [StringLength(26)]
    public string? pakgGroup { get; set; }

    public string? pakgGroupDesc { get; set; }

    [StringLength(26)]
    public string? type { get; set; }

    public string? typeDesc { get; set; }

    [StringLength(50)]
    public string roomType { get; set; } = null!;

    [StringLength(50)]
    public string? hkStatus { get; set; }

    public string? hkStatusDesc { get; set; }

    public string? TitleDescription { get; set; }

    public string firstName { get; set; } = null!;

    [StringLength(20)]
    public string? middleName { get; set; }

    [StringLength(20)]
    public string? lastName { get; set; }

    public string name { get; set; } = null!;

    [StringLength(50)]
    public string? GslType { get; set; }

    public string? PersonGender { get; set; }

    [StringLength(50)]
    public string? nationalityName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DOB { get; set; }

    [StringLength(50)]
    public string? IdentficationDescription { get; set; }

    [StringLength(20)]
    public string? idNumber { get; set; }

    [StringLength(26)]
    public string? nationality { get; set; }

    public string? PersonTitle { get; set; }

    public string? Address { get; set; }

    public bool IsIssued { get; set; }

    public bool IsVoid { get; set; }
}
