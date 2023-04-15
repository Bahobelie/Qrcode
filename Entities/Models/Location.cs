using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Location", Schema = "common")]
[Index("code", Name = "IX_Location", IsUnique = true)]
public partial class Location
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(26)]
    public string? SpaceId { get; set; }

    public int? gslType { get; set; }

    [StringLength(26)]
    public string? type { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("SpaceId")]
    [InverseProperty("Locations")]
    public virtual Space? Space { get; set; }

    [ForeignKey("gslType")]
    [InverseProperty("Locations")]
    public virtual GSLTypeList? gslTypeNavigation { get; set; }

    [ForeignKey("reference")]
    [InverseProperty("Locations")]
    public virtual Article referenceNavigation { get; set; } = null!;

    [ForeignKey("type")]
    [InverseProperty("Locations")]
    public virtual Lookup? typeNavigation { get; set; }
}
