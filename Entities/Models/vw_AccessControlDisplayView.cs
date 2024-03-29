﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_AccessControlDisplayView
{
    [StringLength(26)]
    public string CardNo { get; set; } = null!;

    [StringLength(26)]
    public string ArticleCode { get; set; } = null!;

    [StringLength(26)]
    public string LogCode { get; set; } = null!;

    [StringLength(26)]
    public string DeviceCode { get; set; } = null!;

    [StringLength(26)]
    public string? ComponentCode { get; set; }

    [StringLength(40)]
    public string DeviceName { get; set; } = null!;

    [StringLength(50)]
    public string reader { get; set; } = null!;

    [StringLength(50)]
    public string? description { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime timeStamp { get; set; }

    [StringLength(20)]
    public string? firstName { get; set; }

    [StringLength(20)]
    public string? middleName { get; set; }

    [StringLength(20)]
    public string? lastName { get; set; }

    [StringLength(26)]
    public string? CustomerCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DOB { get; set; }

    [StringLength(50)]
    public string? Gender { get; set; }

    public byte[]? Picture { get; set; }

    public bool isEntry { get; set; }

    public bool isGranted { get; set; }

    public bool? isClosed { get; set; }

    [StringLength(200)]
    public string? Facility { get; set; }

    [StringLength(26)]
    public string? spaceCode { get; set; }
}
