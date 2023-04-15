using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_SecurityUserRoleMembership
{
    [StringLength(26)]
    public string? parentId { get; set; }

    [StringLength(26)]
    public string RoleCode { get; set; } = null!;

    [StringLength(50)]
    public string RoleName { get; set; } = null!;

    [StringLength(26)]
    public string user { get; set; } = null!;

    [StringLength(30)]
    public string userName { get; set; } = null!;

    [StringLength(62)]
    public string? Name { get; set; }
}
