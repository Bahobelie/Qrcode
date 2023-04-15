using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class viewPriceTag
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(17)]
    [Unicode(false)]
    public string tableName { get; set; } = null!;

    [StringLength(64)]
    public string? description { get; set; }
}
