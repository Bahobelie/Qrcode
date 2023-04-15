using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class RestaurantTree
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(200)]
    public string? Description { get; set; }

    [StringLength(26)]
    public string? parent { get; set; }
}
