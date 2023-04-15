using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_AddressDetailView
{
    [StringLength(26)]
    public string employee { get; set; } = null!;

    [StringLength(26)]
    public string relation { get; set; } = null!;

    [StringLength(20)]
    public string firstName { get; set; } = null!;

    [StringLength(20)]
    public string? middleName { get; set; }

    [StringLength(20)]
    public string? lastName { get; set; }

    [StringLength(26)]
    public string relationTypeCode { get; set; } = null!;

    [StringLength(75)]
    public string relationTypeDescription { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;
}
