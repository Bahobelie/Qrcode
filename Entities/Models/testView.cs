using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class testView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int gslType { get; set; }
}
