using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_UserRoleWithReportAccessLevel
{
    [StringLength(26)]
    public string UserId { get; set; } = null!;

    [StringLength(30)]
    public string userName { get; set; } = null!;

    [StringLength(26)]
    public string role { get; set; } = null!;

    [StringLength(26)]
    public string person { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(26)]
    public string accessLevel { get; set; } = null!;

    [StringLength(26)]
    public string component { get; set; } = null!;

    [StringLength(50)]
    public string category { get; set; } = null!;

    public string reportType { get; set; } = null!;

    [StringLength(100)]
    public string? customName { get; set; }

    [StringLength(100)]
    public string defaultName { get; set; } = null!;

    public bool IsActive { get; set; }

    [StringLength(100)]
    public string? Vouchertype { get; set; }
}
