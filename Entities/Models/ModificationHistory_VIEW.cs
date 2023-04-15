using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class ModificationHistory_VIEW
{
    public Guid Id { get; set; }

    [StringLength(26)]
    public string Code { get; set; } = null!;

    [StringLength(26)]
    public string activity { get; set; } = null!;

    [StringLength(50)]
    public string attribute_description { get; set; } = null!;

    [StringLength(26)]
    public string attribute { get; set; } = null!;

    [StringLength(50)]
    public string oldValue { get; set; } = null!;

    [StringLength(50)]
    public string newValue { get; set; } = null!;

    [StringLength(100)]
    public string? Remark { get; set; }

    [StringLength(26)]
    public string? device { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime startTimStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime endTimStamp { get; set; }

    [StringLength(50)]
    public string description { get; set; } = null!;
}
