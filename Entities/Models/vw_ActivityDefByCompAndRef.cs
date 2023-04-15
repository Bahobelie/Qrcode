using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_ActivityDefByCompAndRef
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string description { get; set; } = null!;

    [StringLength(26)]
    public string? reference { get; set; }

    [StringLength(26)]
    public string? component { get; set; }

    [StringLength(50)]
    public string ActivityDefnitionName { get; set; } = null!;

    public byte Index { get; set; }

    public bool isManual { get; set; }
}
