using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_ConsigneeView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int gslType { get; set; }

    [StringLength(64)]
    public string name { get; set; } = null!;

    public string? Address { get; set; }

    [StringLength(20)]
    public string? idNumber { get; set; }

    public bool IsActive { get; set; }

    [StringLength(26)]
    public string? IdentficationType { get; set; }
}
