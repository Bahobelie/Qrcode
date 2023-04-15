using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_TaskIssueDetail
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string type { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string? consignee { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    public bool IsVoid { get; set; }

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    public bool IsIssued { get; set; }

    [StringLength(2048)]
    public string? note { get; set; }

    [StringLength(26)]
    public string? noteCode { get; set; }

    [StringLength(26)]
    public string caseCode { get; set; } = null!;

    [StringLength(26)]
    public string module { get; set; } = null!;

    [StringLength(26)]
    public string issue { get; set; } = null!;

    [StringLength(26)]
    public string cause { get; set; } = null!;

    [StringLength(26)]
    public string solution { get; set; } = null!;

    [StringLength(26)]
    public string result { get; set; } = null!;

    public string recommendation { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    public string? name { get; set; }

    [StringLength(20)]
    public string? idNumber { get; set; }

    [StringLength(26)]
    public string? childPrefCode { get; set; }

    [StringLength(100)]
    public string childCategory { get; set; } = null!;

    [StringLength(26)]
    public string? parentCategory { get; set; }

    [StringLength(26)]
    public string articleCode { get; set; } = null!;

    public string articleName { get; set; } = null!;

    [StringLength(26)]
    public string taskCode { get; set; } = null!;

    public int taskDefinition { get; set; }

    [StringLength(26)]
    public string? user { get; set; }

    public string IssueDescription { get; set; } = null!;

    public string CauseDescription { get; set; } = null!;

    public string SolutionDescription { get; set; } = null!;

    public string RecommendationDescription { get; set; } = null!;
}
