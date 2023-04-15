using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_attendanceExceptionDetail
{
    [StringLength(26)]
    public string? consignee { get; set; }

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string exceptionType { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime date { get; set; }

    [StringLength(26)]
    public string code { get; set; } = null!;

    public string description { get; set; } = null!;

    [StringLength(26)]
    public string sessionType { get; set; } = null!;

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? duration { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? dayPortion { get; set; }

    public bool isCrossDay { get; set; }
}
