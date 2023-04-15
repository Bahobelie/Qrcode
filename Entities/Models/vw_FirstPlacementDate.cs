using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_FirstPlacementDate
{
    [StringLength(26)]
    public string? code { get; set; }

    [StringLength(26)]
    public string? consignee { get; set; }

    [StringLength(26)]
    public string term { get; set; } = null!;

    public string description { get; set; } = null!;

    public string? value { get; set; }
}
