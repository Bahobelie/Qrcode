using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_usersView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string PersonCode { get; set; } = null!;

    [StringLength(30)]
    public string userName { get; set; } = null!;

    public string person { get; set; } = null!;

    [StringLength(200)]
    public string passWord { get; set; } = null!;

    public bool isActive { get; set; }

    [StringLength(21)]
    [Unicode(false)]
    public string loggedInStatus { get; set; } = null!;

    [StringLength(100)]
    public string remark { get; set; } = null!;
}
