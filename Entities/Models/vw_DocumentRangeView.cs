using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_DocumentRangeView
{
    public int voucherDefinition { get; set; }

    [StringLength(100)]
    public string? voucherDefnName { get; set; }

    [Column(TypeName = "date")]
    public DateTime? IssuedDate { get; set; }

    [StringLength(26)]
    public string? device { get; set; }

    [StringLength(26)]
    public string? user { get; set; }

    [StringLength(26)]
    public string? period { get; set; }

    [StringLength(26)]
    public string? organizationUnitDef { get; set; }

    [StringLength(60)]
    public string? FSrange { get; set; }

    public int? FScount { get; set; }

    [StringLength(60)]
    public string? voucherRange { get; set; }

    [Column(TypeName = "money")]
    public decimal? voucherTotal { get; set; }

    public int? voucherCount { get; set; }
}
