using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_EmployeeView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int type { get; set; }

    [StringLength(50)]
    public string? description { get; set; }

    [StringLength(20)]
    public string firstName { get; set; } = null!;

    [StringLength(20)]
    public string? middleName { get; set; }

    [StringLength(20)]
    public string? lastName { get; set; }

    [StringLength(62)]
    public string? fullName { get; set; }

    [StringLength(26)]
    public string branchCode { get; set; } = null!;

    [StringLength(50)]
    public string branchDescription { get; set; } = null!;

    [StringLength(26)]
    public string deptCode { get; set; } = null!;

    [StringLength(50)]
    public string department { get; set; } = null!;

    [StringLength(26)]
    public string branchType { get; set; } = null!;

    [StringLength(50)]
    public string title { get; set; } = null!;

    [StringLength(26)]
    public string? relationType { get; set; }

    [StringLength(26)]
    public string gender { get; set; } = null!;

    [StringLength(50)]
    public string? employementType { get; set; }
}
