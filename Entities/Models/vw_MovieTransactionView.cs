using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_MovieTransactionView
{
    [StringLength(26)]
    public string voucherCode { get; set; } = null!;

    [StringLength(26)]
    public string voudef { get; set; } = null!;

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

    [StringLength(26)]
    public string? user { get; set; }

    [StringLength(26)]
    public string ActivityDefn { get; set; } = null!;
}
