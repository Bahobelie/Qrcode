using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class SerialDefinition_View
{
    public Guid id { get; set; }

    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string article { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [StringLength(50)]
    public string serial_description { get; set; } = null!;

    public bool isMandantory { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }
}
