using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_PersionNationalityView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int gslType { get; set; }

    [StringLength(62)]
    public string name { get; set; } = null!;

    public bool isActive { get; set; }

    [StringLength(20)]
    public string? idNumber { get; set; }

    [StringLength(26)]
    public string? IdentficationType { get; set; }

    [StringLength(26)]
    public string? objectStateDefinition { get; set; }

    [StringLength(50)]
    public string? objectStateDefnDesc { get; set; }

    public string? Address { get; set; }

    [StringLength(26)]
    public string? nationalityCode { get; set; }

    [StringLength(50)]
    public string? nationality { get; set; }
}
