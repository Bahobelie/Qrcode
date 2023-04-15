using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Specification", Schema = "common")]
[Index("code", Name = "IX_Specification", IsUnique = true)]
public partial class Specification
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string article { get; set; } = null!;

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(26)]
    public string category { get; set; } = null!;

    public int index { get; set; }

    [StringLength(50)]
    public string attribute { get; set; } = null!;

    [StringLength(50)]
    public string? value { get; set; }

    [StringLength(26)]
    public string? font { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("article")]
    [InverseProperty("Specifications")]
    public virtual Article articleNavigation { get; set; } = null!;

    [ForeignKey("category")]
    [InverseProperty("SpecificationcategoryNavigations")]
    public virtual Lookup categoryNavigation { get; set; } = null!;

    [ForeignKey("type")]
    [InverseProperty("SpecificationtypeNavigations")]
    public virtual Lookup typeNavigation { get; set; } = null!;
}
