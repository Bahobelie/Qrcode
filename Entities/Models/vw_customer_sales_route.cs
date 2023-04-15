using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_customer_sales_route
{
    [StringLength(100)]
    public string? custCode { get; set; }

    [StringLength(26)]
    public string sectorCode { get; set; } = null!;

    [StringLength(200)]
    public string sector { get; set; } = null!;

    public long? r { get; set; }
}
