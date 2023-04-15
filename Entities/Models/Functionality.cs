using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Functionality", Schema = "common")]
[Index("code", Name = "IX_Functionality", IsUnique = true)]
public partial class Functionality
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string visualComponent { get; set; } = null!;

    [StringLength(26)]
    public string subsystemComponent { get; set; } = null!;

    public string description { get; set; } = null!;

    public string category { get; set; } = null!;

    [StringLength(50)]
    public string function { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("reference2")]
    public virtual ICollection<AccessMatrix> AccessMatrices { get; } = new List<AccessMatrix>();

    [ForeignKey("subsystemComponent")]
    [InverseProperty("FunctionalitysubsystemComponentNavigations")]
    public virtual CNETComponent subsystemComponentNavigation { get; set; } = null!;

    [ForeignKey("visualComponent")]
    [InverseProperty("FunctionalityvisualComponentNavigations")]
    public virtual CNETComponent visualComponentNavigation { get; set; } = null!;
}
