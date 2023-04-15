using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_OvertimeView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    public string description { get; set; } = null!;

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? dayPortion { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? duration { get; set; }

    [StringLength(26)]
    public string VoucherCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime date { get; set; }

    [StringLength(26)]
    public string session { get; set; } = null!;

    [StringLength(26)]
    public string? consignee { get; set; }

    [StringLength(50)]
    public string SectionDescription { get; set; } = null!;

    [StringLength(26)]
    public string state { get; set; } = null!;

    public TimeSpan inTime { get; set; }

    public TimeSpan outTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [StringLength(20)]
    public string firstName { get; set; } = null!;

    [StringLength(20)]
    public string? middleName { get; set; }

    [StringLength(20)]
    public string? lastName { get; set; }

    [StringLength(50)]
    public string branchDescription { get; set; } = null!;

    [StringLength(50)]
    public string department { get; set; } = null!;

    [StringLength(50)]
    public string title { get; set; } = null!;

    [StringLength(2048)]
    public string? note { get; set; }

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(26)]
    public string branchCode { get; set; } = null!;

    [StringLength(26)]
    public string deptCode { get; set; } = null!;
}
