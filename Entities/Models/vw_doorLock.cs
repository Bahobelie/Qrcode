using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_doorLock
{
    [StringLength(26)]
    public string keyDefCode { get; set; } = null!;

    [StringLength(26)]
    public string space { get; set; } = null!;

    [StringLength(26)]
    public string? keyCode { get; set; }

    [StringLength(26)]
    public string roomDetail { get; set; } = null!;

    [StringLength(26)]
    public string keyOptionCode { get; set; } = null!;

    [StringLength(50)]
    public string? roomNum { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }
}
