using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class organizationAddressView
{
    [StringLength(26)]
    public string orgCode { get; set; } = null!;

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [StringLength(26)]
    public string? parentId { get; set; }

    [StringLength(50)]
    public string? specialization { get; set; }

    [StringLength(26)]
    public string? addCode { get; set; }

    [StringLength(40)]
    public string? value { get; set; }

    [StringLength(26)]
    public string? distCode { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    public bool? use { get; set; }
}
