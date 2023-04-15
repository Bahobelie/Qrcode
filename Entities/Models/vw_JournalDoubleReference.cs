using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_JournalDoubleReference
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string referening { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime jvDate { get; set; }

    [StringLength(26)]
    public string referenced { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime srcDate { get; set; }

    public long? rn { get; set; }
}
