using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class RateCodeCategoryCurrency_View
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(50)]
    public string Category { get; set; } = null!;

    [StringLength(50)]
    public string Currency { get; set; } = null!;
}
