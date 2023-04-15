using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class SalesReportHeiniken
{
    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string Customer_ID { get; set; } = null!;

    public string Customer_Name { get; set; } = null!;

    [StringLength(30)]
    public string User_Name { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime startTimStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? endTimStamp { get; set; }

    [StringLength(50)]
    public string Machine_Number { get; set; } = null!;

    public string SKU { get; set; } = null!;

    [StringLength(100)]
    public string Brand { get; set; } = null!;

    public string Pack_Type { get; set; } = null!;

    [Column(TypeName = "decimal(18, 4)")]
    public decimal QTY { get; set; }

    [Column(TypeName = "money")]
    public decimal? Price_Before_VAT { get; set; }

    [Column(TypeName = "money")]
    public decimal? VAT { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    public double latitude { get; set; }

    public double longitude { get; set; }

    public string idNumber { get; set; } = null!;

    [StringLength(26)]
    public string? prospect { get; set; }

    public int? vansCount { get; set; }

    public string? org { get; set; }

    public string SEM_ID { get; set; } = null!;

    [StringLength(26)]
    public string? sector { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string trx_type { get; set; } = null!;
}
