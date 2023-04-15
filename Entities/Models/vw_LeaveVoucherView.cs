using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_LeaveVoucherView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? consignee { get; set; }

    [StringLength(26)]
    public string session { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    public int voucherDefinition { get; set; }

    public string LeaveType { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime date { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? dayPortion { get; set; }

    public string description { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    public bool IsIssued { get; set; }

    [Column(TypeName = "money")]
    public decimal? unitAmt { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal quantity { get; set; }

    [Column(TypeName = "money")]
    public decimal? totalAmount { get; set; }

    public bool IsVoid { get; set; }

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

    [StringLength(100)]
    public string? remark { get; set; }

    [StringLength(2048)]
    public string? note { get; set; }

    [StringLength(50)]
    public string title { get; set; } = null!;

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(26)]
    public string deptCode { get; set; } = null!;

    [StringLength(26)]
    public string branchCode { get; set; } = null!;

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? duration { get; set; }

    [StringLength(26)]
    public string sessionType { get; set; } = null!;

    public string? employementType { get; set; }

    [StringLength(26)]
    public string lineItemCode { get; set; } = null!;

    [StringLength(26)]
    public string roleCode { get; set; } = null!;

    [StringLength(26)]
    public string gender { get; set; } = null!;

    [StringLength(62)]
    public string? fullName { get; set; }
}
