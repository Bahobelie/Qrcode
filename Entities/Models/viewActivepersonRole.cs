using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class viewActivepersonRole
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string person { get; set; } = null!;

    [StringLength(66)]
    public string? FullName { get; set; }

    [StringLength(30)]
    public string userName { get; set; } = null!;
}
