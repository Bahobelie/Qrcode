using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_MultiCompanyIndustry
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    public string tradeName { get; set; } = null!;

    public string? brandName { get; set; }

    [StringLength(26)]
    public string? industy { get; set; }

    [StringLength(26)]
    public string? TIN { get; set; }

    [StringLength(26)]
    public string branchCode { get; set; } = null!;

    [StringLength(50)]
    public string branchDesc { get; set; } = null!;

    public string? addressValue { get; set; }

    public double? latitude { get; set; }

    public double? longitude { get; set; }

    public string? note { get; set; }

    [StringLength(256)]
    public string? url { get; set; }
}
