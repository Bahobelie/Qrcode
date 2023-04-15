using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_RateAdjustment
{
    [StringLength(50)]
    public string registrationNo { get; set; } = null!;

    public string name { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime? arrivalDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? departureDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime startDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime endDate { get; set; }

    public bool isPercent { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal amount { get; set; }

    [Column(TypeName = "money")]
    public decimal value { get; set; }

    [StringLength(26)]
    public string? organizationUnitDefinition { get; set; }

    public string? reason { get; set; }
}
