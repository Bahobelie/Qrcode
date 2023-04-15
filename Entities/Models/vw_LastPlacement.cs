using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_LastPlacement
{
    [StringLength(26)]
    public string? lastVoucherTermConsignee { get; set; }

    public string? lastPlacementDate { get; set; }

    [StringLength(26)]
    public string? branchCode { get; set; }

    [StringLength(50)]
    public string? branchName { get; set; }

    [StringLength(26)]
    public string? departmentCode { get; set; }

    [StringLength(50)]
    public string? departmentName { get; set; }

    [StringLength(26)]
    public string? positionCode { get; set; }

    [StringLength(50)]
    public string? positionName { get; set; }

    [StringLength(26)]
    public string employementType { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? basicSalary { get; set; }

    [Column(TypeName = "money")]
    public decimal? allowances { get; set; }

    [Column(TypeName = "money")]
    public decimal grossTotal { get; set; }

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    [StringLength(26)]
    public string? period { get; set; }
}
