using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_PromotionReportView
{
    [StringLength(26)]
    public string empCode { get; set; } = null!;

    [StringLength(62)]
    public string? fullName { get; set; }

    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? branchCode { get; set; }

    [StringLength(50)]
    public string? branch { get; set; }

    [StringLength(50)]
    public string? department { get; set; }

    [StringLength(26)]
    public string? deptCode { get; set; }

    [StringLength(26)]
    public string? roleCode { get; set; }

    [StringLength(50)]
    public string? role { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [StringLength(26)]
    public string? period { get; set; }

    [StringLength(26)]
    public string referenced { get; set; } = null!;

    [StringLength(26)]
    public string gender { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal oldGrandTotal { get; set; }

    [StringLength(10)]
    public string? AsOfDate { get; set; }

    [StringLength(50)]
    public string? oldBranch { get; set; }

    [StringLength(50)]
    public string? oldDepartment { get; set; }

    [StringLength(50)]
    public string? oldRole { get; set; }
}
