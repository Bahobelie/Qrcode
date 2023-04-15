using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_LifeSpanDetail
{
    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(79)]
    [Unicode(false)]
    public string? referenceLifeSpan { get; set; }
}
