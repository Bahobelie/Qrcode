﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_AttendanceExceptionView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? consignee { get; set; }

    [StringLength(26)]
    public string session { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime date { get; set; }

    public string description { get; set; } = null!;

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? dayPortion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [StringLength(62)]
    public string? fullName { get; set; }

    [StringLength(50)]
    public string branchDescription { get; set; } = null!;

    [StringLength(50)]
    public string department { get; set; } = null!;

    [StringLength(50)]
    public string title { get; set; } = null!;

    [StringLength(26)]
    public string branchCode { get; set; } = null!;

    [StringLength(26)]
    public string deptCode { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? grandTotal { get; set; }
}
