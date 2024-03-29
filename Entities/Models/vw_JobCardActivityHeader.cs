﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_JobCardActivityHeader
{
    [StringLength(26)]
    public string voucherCode { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string? equipmentCode { get; set; }

    [StringLength(26)]
    public string? consigneeCode { get; set; }

    public string? consigneeName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    public bool IsIssued { get; set; }

    public bool IsVoid { get; set; }

    [StringLength(56)]
    [Unicode(false)]
    public string? totalStandardTime { get; set; }

    [StringLength(56)]
    [Unicode(false)]
    public string? activityTimeElapsed { get; set; }

    [StringLength(56)]
    [Unicode(false)]
    public string? remainingPerStandardTime { get; set; }

    [StringLength(32)]
    public string? percPerStandardTime { get; set; }

    [StringLength(11)]
    [Unicode(false)]
    public string JobStatus { get; set; } = null!;
}
