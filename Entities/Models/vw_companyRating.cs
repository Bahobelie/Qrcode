using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_companyRating
{
    public string? tin { get; set; }

    [Column(TypeName = "money")]
    public decimal? rating { get; set; }

    public int? ratingCount { get; set; }
}
