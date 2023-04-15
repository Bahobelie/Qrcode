using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_DeliverDriver
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(64)]
    public string name { get; set; } = null!;

    [StringLength(26)]
    public string gender { get; set; } = null!;
}
