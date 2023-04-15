using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class ModificationLogview
{
    [StringLength(26)]
    public string attribute { get; set; } = null!;

    [StringLength(50)]
    public string oldValue { get; set; } = null!;

    [StringLength(50)]
    public string newValue { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [StringLength(26)]
    public string activity { get; set; } = null!;
}
