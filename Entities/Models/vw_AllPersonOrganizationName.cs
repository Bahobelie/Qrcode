using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_AllPersonOrganizationName
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    public string? name { get; set; }

    public int gslType { get; set; }
}
