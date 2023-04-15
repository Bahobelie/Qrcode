using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class ControlAccountView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [StringLength(50)]
    public string accType { get; set; } = null!;

    [StringLength(15)]
    public string accCategory { get; set; } = null!;

    public int? gslTypeList { get; set; }

    public bool? isMandatory { get; set; }

    public bool? restrictSelection { get; set; }

    [StringLength(26)]
    public string? contAcct { get; set; }
}
