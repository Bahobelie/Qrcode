using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_BookedTransactionView
{
    [StringLength(26)]
    public string voucherCode { get; set; } = null!;

    [StringLength(26)]
    public string lineitemcode { get; set; } = null!;

    [StringLength(26)]
    public string voudef { get; set; } = null!;

    [StringLength(26)]
    public string? consigneecode { get; set; }

    [StringLength(62)]
    public string? consignee { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal quantity { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime startDate { get; set; }

    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string Transactioncode { get; set; } = null!;

    [StringLength(26)]
    public string space { get; set; } = null!;

    [StringLength(26)]
    public string scheduleHeader { get; set; } = null!;

    [StringLength(26)]
    public string seatarrangement { get; set; } = null!;

    public bool IsIssued { get; set; }

    public bool IsVoid { get; set; }

    [StringLength(30)]
    public string userName { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }
}
