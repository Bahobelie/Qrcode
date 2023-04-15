using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class RateQuery_View
{
    [StringLength(26)]
    public string rateCodeDetail { get; set; } = null!;

    [StringLength(26)]
    public string roomType { get; set; } = null!;

    public bool isAdult { get; set; }

    public int guestCount { get; set; }

    [Column(TypeName = "money")]
    public decimal amount { get; set; }
}
