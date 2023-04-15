using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class viewOrgPersonByType
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int type { get; set; }

    [StringLength(62)]
    public string? description { get; set; }
}
