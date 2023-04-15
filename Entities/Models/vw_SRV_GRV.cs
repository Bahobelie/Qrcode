using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_SRV_GRV
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string storeTransaction { get; set; } = null!;

    [StringLength(26)]
    public string? source { get; set; }

    [StringLength(50)]
    public string? sourceDescription { get; set; }

    [StringLength(26)]
    public string? destination { get; set; }

    [StringLength(50)]
    public string? destinationDescription { get; set; }

    [StringLength(26)]
    public string materialcode { get; set; } = null!;

    public string materialDescription { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? unitAmt { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal quantity { get; set; }

    [StringLength(26)]
    public string? UOM { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [StringLength(26)]
    public string? consignee { get; set; }

    public string? TagNumber { get; set; }

    public string? SerialNumber { get; set; }

    [StringLength(26)]
    public string? vouchExtOne { get; set; }

    [StringLength(50)]
    public string? vouchExtDescOne { get; set; }

    [StringLength(26)]
    public string? vouchExtNumberOne { get; set; }

    [StringLength(26)]
    public string? vouchExtFourth { get; set; }

    [StringLength(50)]
    public string? vouchExtDescFourth { get; set; }

    [StringLength(26)]
    public string? vouchExtNumberFourth { get; set; }

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
    public string? referenced { get; set; }
}
