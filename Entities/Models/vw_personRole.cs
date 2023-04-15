using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_personRole
{
    [StringLength(26)]
    public string userCode { get; set; } = null!;

    [StringLength(26)]
    public string personCode { get; set; } = null!;

    [StringLength(30)]
    public string userName { get; set; } = null!;

    public bool isActive { get; set; }

    [StringLength(62)]
    public string? personName { get; set; }

    [StringLength(50)]
    public string RoleDescription { get; set; } = null!;

    [StringLength(26)]
    public string RoleCode { get; set; } = null!;
}
