using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_CaseVoucherView
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

    [StringLength(26)]
    public string? parentCategoryCode { get; set; }

    [StringLength(100)]
    public string? parentCategoryDesc { get; set; }

    public string? consigneeTelephone { get; set; }

    [StringLength(20)]
    public string? consigneeTIN { get; set; }

    [StringLength(26)]
    public string branchCode { get; set; } = null!;

    [StringLength(50)]
    public string branch { get; set; } = null!;

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
    public string contactPersonCode { get; set; } = null!;

    public string? contactPersonName { get; set; }

    [StringLength(26)]
    public string moduleCode { get; set; } = null!;

    [StringLength(50)]
    public string moduleDesc { get; set; } = null!;

    [StringLength(26)]
    public string issueCode { get; set; } = null!;

    public string issueDesc { get; set; } = null!;

    [StringLength(26)]
    public string causeCode { get; set; } = null!;

    public string causeDesc { get; set; } = null!;

    [StringLength(26)]
    public string solutionCode { get; set; } = null!;

    public string solutionDesc { get; set; } = null!;

    public string resultDesc { get; set; } = null!;

    [StringLength(26)]
    public string resultCode { get; set; } = null!;

    [StringLength(26)]
    public string supportType { get; set; } = null!;

    public string? recommendationDesc { get; set; }

    public string recommendationCode { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    public string? specificLocation { get; set; }

    [StringLength(26)]
    public string? otherConsigneeCode { get; set; }

    public string? otherConsigneeTwoName { get; set; }

    [StringLength(26)]
    public string? otherConsigneeTwo { get; set; }

    [StringLength(2048)]
    public string? note { get; set; }
}
