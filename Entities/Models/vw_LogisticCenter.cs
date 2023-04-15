using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_LogisticCenter
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? consigneeCode { get; set; }

    public string? consigneeName { get; set; }

    [StringLength(20)]
    public string? consigneeTIN { get; set; }

    public string? consigneeTelephone { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime startTimStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? endTimStamp { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    [StringLength(26)]
    public string reference { get; set; } = null!;

    public double? latitude { get; set; }

    public double? longitude { get; set; }

    [StringLength(26)]
    public string? user { get; set; }

    [StringLength(30)]
    public string userName { get; set; } = null!;

    [StringLength(62)]
    public string? userFullName { get; set; }

    public string? userTelephone { get; set; }

    [StringLength(256)]
    public string? attachmentURL { get; set; }

    public int? voucherDefinition { get; set; }
}
