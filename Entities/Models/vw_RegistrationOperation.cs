using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_RegistrationOperation
{
    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    [StringLength(50)]
    public string? lastObjectStateDesc { get; set; }

    [StringLength(26)]
    public string? consignee { get; set; }

    [Column(TypeName = "date")]
    public DateTime? Date { get; set; }

    public int? adult { get; set; }

    public int? child { get; set; }

    public int? roomCount { get; set; }

    [StringLength(26)]
    public string? room { get; set; }

    [StringLength(50)]
    public string? roomNo { get; set; }

    [StringLength(100)]
    public string prevRoom { get; set; } = null!;

    [StringLength(26)]
    public string? roomType { get; set; }

    [StringLength(50)]
    public string? roomTypeDesc { get; set; }

    [StringLength(26)]
    public string? rateCodeDetail { get; set; }

    [StringLength(150)]
    public string? rateCodeDetailDesc { get; set; }

    [Column(TypeName = "money")]
    public decimal? rateAmount { get; set; }

    [StringLength(26)]
    public string? actualRTC { get; set; }

    [StringLength(50)]
    public string? actualRTCdesc { get; set; }

    [StringLength(26)]
    public string? market { get; set; }

    [StringLength(50)]
    public string? marketDes { get; set; }

    [StringLength(26)]
    public string? paymentType { get; set; }

    [StringLength(50)]
    public string? paymentTypeDesc { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? arrivalDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? departureDate { get; set; }

    [StringLength(26)]
    public string? component { get; set; }

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? endTimStamp { get; set; }

    [StringLength(26)]
    public string? device { get; set; }

    [StringLength(26)]
    public string? user { get; set; }

    [StringLength(30)]
    public string? userName { get; set; }

    [StringLength(20)]
    public string? firstName { get; set; }

    [StringLength(20)]
    public string? middleName { get; set; }

    [StringLength(20)]
    public string? lastName { get; set; }

    [StringLength(26)]
    public string? activitiyDefinition { get; set; }

    [StringLength(50)]
    public string? activityDefinitionDesc { get; set; }
}
