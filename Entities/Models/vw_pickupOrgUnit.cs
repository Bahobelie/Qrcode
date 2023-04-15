using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_pickupOrgUnit
{
    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(26)]
    public string pickupOrgUnitCode { get; set; } = null!;

    [StringLength(50)]
    public string pickupOrgUnitDesc { get; set; } = null!;

    public double? latitude { get; set; }

    public double? longitude { get; set; }
}
