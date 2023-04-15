using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_displayOrderSingle
{
    public int id { get; set; }

    [StringLength(26)]
    public string component { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    public int index { get; set; }

    [StringLength(50)]
    public string? remark { get; set; }

    public long? r { get; set; }
}
