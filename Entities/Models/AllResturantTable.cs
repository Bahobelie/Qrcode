using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class AllResturantTable
{
    [StringLength(26)]
    public string tablecode { get; set; } = null!;

    [StringLength(50)]
    public string? TableName { get; set; }

    [StringLength(26)]
    public string buldingCode { get; set; } = null!;

    [StringLength(26)]
    public string typeCode { get; set; } = null!;

    [StringLength(50)]
    public string Type { get; set; } = null!;

    [StringLength(26)]
    public string? Parent { get; set; }

    public int? maxOccupancy { get; set; }

    [StringLength(36)]
    public string? shapeid { get; set; }
}
