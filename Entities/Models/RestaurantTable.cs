using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("RestaurantTable", Schema = "pos")]
public partial class RestaurantTable
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string Space { get; set; } = null!;

    [StringLength(50)]
    public string? description { get; set; }

    public int? maxOccupancy { get; set; }

    [StringLength(26)]
    public string? shape { get; set; }

    [StringLength(26)]
    public string? grade { get; set; }

    [StringLength(50)]
    public string? remark { get; set; }

    [ForeignKey("Space")]
    [InverseProperty("RestaurantTables")]
    public virtual Space SpaceNavigation { get; set; } = null!;
}
