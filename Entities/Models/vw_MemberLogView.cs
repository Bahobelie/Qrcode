using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_MemberLogView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(102)]
    public string? name { get; set; }

    public int gslType { get; set; }

    [StringLength(40)]
    public string? Address { get; set; }

    [StringLength(26)]
    public string? IdentficationType { get; set; }

    [StringLength(20)]
    public string? idNumber { get; set; }

    [StringLength(26)]
    public string card { get; set; } = null!;

    [StringLength(26)]
    public string component { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(26)]
    public string logsCode { get; set; } = null!;

    [StringLength(26)]
    public string logscard { get; set; } = null!;

    [StringLength(26)]
    public string acDevice { get; set; } = null!;

    [StringLength(50)]
    public string reader { get; set; } = null!;

    [StringLength(50)]
    public string? description { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime timeStamp { get; set; }

    public int year { get; set; }

    public int month { get; set; }

    public int date { get; set; }

    public bool isEntry { get; set; }

    public bool isGranted { get; set; }

    public bool? isClosed { get; set; }
}
