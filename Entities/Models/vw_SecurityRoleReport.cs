using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_SecurityRoleReport
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [StringLength(26)]
    public string? parentId { get; set; }

    [StringLength(26)]
    public string accessLevel { get; set; } = null!;

    [StringLength(50)]
    public string category { get; set; } = null!;

    public string reportType { get; set; } = null!;

    [StringLength(100)]
    public string? reference { get; set; }

    [StringLength(100)]
    public string defaultName { get; set; } = null!;

    [StringLength(100)]
    public string? customName { get; set; }

    [StringLength(450)]
    public string ReportDescription { get; set; } = null!;

    public bool IsActive { get; set; }

    [StringLength(256)]
    public string? url { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [StringLength(26)]
    public string ReportCode { get; set; } = null!;

    [StringLength(50)]
    public string component { get; set; } = null!;
}
