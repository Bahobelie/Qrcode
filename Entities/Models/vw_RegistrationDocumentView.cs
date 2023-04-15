using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_RegistrationDocumentView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [StringLength(26)]
    public string? foStatus { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? arrivalDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? departureDate { get; set; }

    [StringLength(26)]
    public string? resType { get; set; }

    [StringLength(26)]
    public string? paymentType { get; set; }

    [StringLength(26)]
    public string? OrganizationUnitDefinition { get; set; }

    [Column(TypeName = "date")]
    public DateTime? Date { get; set; }

    public int? adult { get; set; }

    public int? child { get; set; }

    public int? roomCount { get; set; }

    [StringLength(26)]
    public string? roomType { get; set; }

    [StringLength(26)]
    public string? room { get; set; }

    [StringLength(26)]
    public string? rateCodeDetail { get; set; }

    [Column(TypeName = "money")]
    public decimal? rateAmount { get; set; }

    [StringLength(26)]
    public string? actualRTC { get; set; }

    [StringLength(26)]
    public string? OtherConsignee { get; set; }

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(26)]
    public string? requiredGSL { get; set; }

    [StringLength(26)]
    public string? consignee { get; set; }

    [StringLength(26)]
    public string? market { get; set; }

    public bool? ismaster { get; set; }

    [StringLength(26)]
    public string RegHeaderCode { get; set; } = null!;

    [StringLength(100)]
    public string? regHeaderRemark { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [StringLength(26)]
    public string? origin { get; set; }
}
