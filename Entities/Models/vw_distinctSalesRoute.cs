using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_distinctSalesRoute
{
    [StringLength(26)]
    public string orgUnit { get; set; } = null!;

    [StringLength(26)]
    public string space { get; set; } = null!;

    public long? r { get; set; }
}
