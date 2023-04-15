using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_EscalationVoucherView
{
    [StringLength(26)]
    public string voucherCode { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string transactionType { get; set; } = null!;

    public string transactionTypeDescription { get; set; } = null!;

    [StringLength(26)]
    public string? consigneeCode { get; set; }

    public string? consigneeName { get; set; }

    public string? consigneeTelephone { get; set; }

    [StringLength(20)]
    public string? consigneeTIN { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    public bool IsIssued { get; set; }

    public bool IsVoid { get; set; }

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    [StringLength(50)]
    public string LastObjectStateDesc { get; set; } = null!;

    [StringLength(26)]
    public string? color { get; set; }

    [StringLength(26)]
    public string? lastActivity { get; set; }

    [StringLength(26)]
    public string? userCode { get; set; }

    [StringLength(30)]
    public string? userName { get; set; }

    [StringLength(26)]
    public string deviceCode { get; set; } = null!;

    public string deviceName { get; set; } = null!;

    [StringLength(26)]
    public string assignedToCode { get; set; } = null!;

    [StringLength(62)]
    public string? asignedToDesc { get; set; }

    public string caseDesc { get; set; } = null!;

    public string? solutionDesc { get; set; }

    [Column(TypeName = "date")]
    public DateTime? deliveryTime { get; set; }

    [StringLength(26)]
    public string moduleCode { get; set; } = null!;

    [StringLength(50)]
    public string moduleDesc { get; set; } = null!;

    [StringLength(26)]
    public string functionalityCode { get; set; } = null!;

    public string functionalityDesc { get; set; } = null!;

    [StringLength(26)]
    public string priorityCode { get; set; } = null!;

    public string priorityDesc { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    public string? escalationRemark { get; set; }
}
