using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class Vw_ModificationHistory
{
    [StringLength(26)]
    public string reference { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime startTimStamp { get; set; }

    [StringLength(50)]
    public string oldValue { get; set; } = null!;

    [StringLength(50)]
    public string newValue { get; set; } = null!;

    [StringLength(26)]
    public string attribute { get; set; } = null!;

    [StringLength(100)]
    public string? Remark { get; set; }

    public string name { get; set; } = null!;

    [StringLength(30)]
    public string userName { get; set; } = null!;
}
