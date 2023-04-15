using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_rating_identification
{
    [StringLength(26)]
    public string reference { get; set; } = null!;

    public string rating { get; set; } = null!;

    [StringLength(100)]
    public string? ratingCount { get; set; }

    public long? r { get; set; }
}
