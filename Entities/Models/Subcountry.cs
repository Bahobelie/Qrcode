using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Subcountry", Schema = "common")]
[Index("code", Name = "IX_Subcountry", IsUnique = true)]
public partial class Subcountry
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string country { get; set; } = null!;

    [StringLength(50)]
    public string name { get; set; } = null!;

    [StringLength(50)]
    public string? alternativeName { get; set; }

    [StringLength(26)]
    public string? type { get; set; }

    [StringLength(26)]
    public string? gps { get; set; }

    [StringLength(26)]
    public string? parent { get; set; }

    public int? population { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("parentNavigation")]
    public virtual ICollection<Subcountry> InverseparentNavigation { get; } = new List<Subcountry>();

    [ForeignKey("gps")]
    [InverseProperty("Subcountries")]
    public virtual CNET_GP? gpsNavigation { get; set; }

    [ForeignKey("parent")]
    [InverseProperty("InverseparentNavigation")]
    public virtual Subcountry? parentNavigation { get; set; }

    [ForeignKey("type")]
    [InverseProperty("Subcountries")]
    public virtual Lookup? typeNavigation { get; set; }
}
