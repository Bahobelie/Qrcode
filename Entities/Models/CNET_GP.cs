using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("CNET_GPS", Schema = "common")]
[Index("code", Name = "IX_GPS", IsUnique = true)]
public partial class CNET_GP
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    /// <summary>
    /// Can Be:ModificationHistory (common),OrganizationUnit (common),Person (common),Subcountry (common)
    /// </summary>
    [StringLength(26)]
    public string reference { get; set; } = null!;

    public double? latitude { get; set; }

    public double? longitude { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("gpsNavigation")]
    public virtual ICollection<Subcountry> Subcountries { get; } = new List<Subcountry>();

    [ForeignKey("reference")]
    [InverseProperty("CNET_GPs")]
    public virtual OrganizationUnit reference1 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("CNET_GPs")]
    public virtual Person reference2 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("CNET_GPs")]
    public virtual ModificationHistory referenceNavigation { get; set; } = null!;
}
