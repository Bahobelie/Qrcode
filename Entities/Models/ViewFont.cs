using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class ViewFont
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(50)]
    public string Font { get; set; } = null!;

    [StringLength(40)]
    public string Face { get; set; } = null!;

    [StringLength(50)]
    public string Style { get; set; } = null!;

    public byte Font_Size { get; set; }

    public bool isDefault { get; set; }
}
