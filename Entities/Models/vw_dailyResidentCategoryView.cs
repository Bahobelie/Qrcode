using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_dailyResidentCategoryView
{
    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(26)]
    public string? reference { get; set; }

    [StringLength(26)]
    public string? consigneecode { get; set; }

    [StringLength(26)]
    public string guest { get; set; } = null!;

    [StringLength(26)]
    public string? preference { get; set; }

    [StringLength(26)]
    public string? company { get; set; }

    [StringLength(26)]
    public string room { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal roomRevenue { get; set; }

    [Column(TypeName = "money")]
    public decimal package { get; set; }

    [Column(TypeName = "money")]
    public decimal vat { get; set; }

    [Column(TypeName = "money")]
    public decimal serviceCharge { get; set; }

    [Column(TypeName = "money")]
    public decimal roomTotal { get; set; }

    [Column(TypeName = "money")]
    public decimal toDateTotal { get; set; }

    [Column(TypeName = "money")]
    public decimal discount { get; set; }

    [Column(TypeName = "money")]
    public decimal payment { get; set; }

    [Column(TypeName = "money")]
    public decimal paidout { get; set; }

    [Column(TypeName = "money")]
    public decimal bcf { get; set; }

    [Column(TypeName = "money")]
    public decimal outstanding { get; set; }

    public int type { get; set; }
}
