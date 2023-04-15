using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_VoucherValuePeriodView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [StringLength(26)]
    public string? period { get; set; }

    public int year { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime start { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime end { get; set; }

    [Column(TypeName = "money")]
    public decimal? subTotal { get; set; }
}
