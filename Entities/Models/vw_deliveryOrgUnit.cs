using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_deliveryOrgUnit
{
    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(26)]
    public string deliveryOrgUnitCode { get; set; } = null!;

    [StringLength(50)]
    public string deliveryOrgUnitDesc { get; set; } = null!;

    public double? latitude { get; set; }

    public double? longitude { get; set; }
}
