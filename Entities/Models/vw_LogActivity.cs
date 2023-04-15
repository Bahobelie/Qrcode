using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_LogActivity
{
    [Column(TypeName = "datetime")]
    public DateTime LogDate { get; set; }

    [StringLength(26)]
    public string? Machine { get; set; }

    [StringLength(113)]
    public string? Message { get; set; }
}
