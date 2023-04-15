using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_agingIssuedTransactionReference
{
    [StringLength(26)]
    public string referening { get; set; } = null!;

    [StringLength(26)]
    public string referenced { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? value { get; set; }
}
