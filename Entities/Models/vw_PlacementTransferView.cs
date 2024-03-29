﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_PlacementTransferView
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

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [StringLength(26)]
    public string? period { get; set; }

    [StringLength(26)]
    public string referenced { get; set; } = null!;

    [StringLength(26)]
    public string gender { get; set; } = null!;

    [StringLength(50)]
    public string? oldBranch { get; set; }

    [StringLength(50)]
    public string? pldDepartment { get; set; }

    [StringLength(50)]
    public string? oldRole { get; set; }
}
