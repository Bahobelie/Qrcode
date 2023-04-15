using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_PersonWithAccountMap
{
    [StringLength(26)]
    public string personCode { get; set; } = null!;

    public int type { get; set; }

    [StringLength(26)]
    public string accountMapCode { get; set; } = null!;

    [StringLength(20)]
    public string firstName { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [StringLength(26)]
    public string accountCode { get; set; } = null!;

    [StringLength(20)]
    public string? middleName { get; set; }

    [StringLength(26)]
    public string? preference { get; set; }

    [StringLength(26)]
    public string? parentAccount { get; set; }

    [StringLength(20)]
    public string? lastName { get; set; }

    [StringLength(50)]
    public string controlAccount { get; set; } = null!;
}
