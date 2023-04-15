using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("GSLTypeList", Schema = "common")]
public partial class GSLTypeList
{
    public Guid id { get; set; }

    [Key]
    public int code { get; set; }

    [StringLength(50)]
    public string description { get; set; } = null!;

    [StringLength(26)]
    public string category { get; set; } = null!;

    public bool? isActive { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("gslTypeNavigation")]
    public virtual ICollection<Article> Articles { get; } = new List<Article>();

    [InverseProperty("gslTypeListNavigation")]
    public virtual ICollection<GSLAcctRequirement> GSLAcctRequirements { get; } = new List<GSLAcctRequirement>();

    [InverseProperty("gslTypeNavigation")]
    public virtual ICollection<Location> Locations { get; } = new List<Location>();

    [InverseProperty("typeNavigation")]
    public virtual ICollection<Organization> Organizations { get; } = new List<Organization>();

    [InverseProperty("typeNavigation")]
    public virtual ICollection<Person> People { get; } = new List<Person>();

    [InverseProperty("gslTypeNavigation")]
    public virtual ICollection<RequiredGSLDetail> RequiredGSLDetails { get; } = new List<RequiredGSLDetail>();
}
