using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_UserRoleWithFunctionalityAccessLevel
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

    [StringLength(100)]
    public string description { get; set; } = null!;

    [StringLength(50)]
    public string function { get; set; } = null!;

    [StringLength(26)]
    public string remark { get; set; } = null!;
}
