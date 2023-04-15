using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_PerPrefNoCatagory
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(20)]
    public string firstName { get; set; } = null!;

    [StringLength(20)]
    public string? middleName { get; set; }

    [StringLength(20)]
    public string? lastName { get; set; }

    [StringLength(26)]
    public string? PersonPreferenceCode { get; set; }

    [StringLength(26)]
    public string? preferenceCode { get; set; }
}
