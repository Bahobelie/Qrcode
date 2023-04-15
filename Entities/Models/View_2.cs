using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class View_2
{
    public string name { get; set; } = null!;

    [StringLength(26)]
    public string article { get; set; } = null!;
}
