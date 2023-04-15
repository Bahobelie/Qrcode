using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_RateComponent
{
    [StringLength(26)]
    public string regNo { get; set; } = null!;

    [Column(TypeName = "date")]
    public DateTime? Date { get; set; }

    public int? adult { get; set; }

    public int? child { get; set; }

    public int? roomCount { get; set; }

    [StringLength(26)]
    public string? room { get; set; }

    [StringLength(26)]
    public string? roomType { get; set; }

    [StringLength(26)]
    public string? rateCodeDetail { get; set; }

    [Column(TypeName = "money")]
    public decimal? rateAmount { get; set; }

    [StringLength(26)]
    public string? actualRTC { get; set; }

    [StringLength(26)]
    public string? market { get; set; }

    [StringLength(26)]
    public string rateCodeHeader { get; set; } = null!;

    [StringLength(26)]
    public string? consignee { get; set; }

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    [StringLength(20)]
    public string firstName { get; set; } = null!;

    [StringLength(20)]
    public string? middleName { get; set; }

    [StringLength(20)]
    public string? lastName { get; set; }

    [StringLength(62)]
    public string? Name { get; set; }

    [StringLength(50)]
    public string? roomNo { get; set; }

    [StringLength(50)]
    public string? hkStatus { get; set; }

    [StringLength(50)]
    public string roomTypeDesc { get; set; } = null!;

    [StringLength(26)]
    public string rateComponent { get; set; } = null!;
}
