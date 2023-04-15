using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Space", Schema = "common")]
public partial class Space
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(200)]
    public string Description { get; set; } = null!;

    [StringLength(26)]
    public string? OrganizationUnitDef { get; set; }

    [StringLength(26)]
    public string? Type { get; set; }

    [StringLength(26)]
    public string? Catagory { get; set; }

    [StringLength(26)]
    public string? Parent { get; set; }

    [StringLength(50)]
    public string? Remark { get; set; }

    [ForeignKey("Catagory")]
    [InverseProperty("SpaceCatagoryNavigations")]
    public virtual Lookup? CatagoryNavigation { get; set; }

    [InverseProperty("ParentNavigation")]
    public virtual ICollection<Space> InverseParentNavigation { get; } = new List<Space>();

    [InverseProperty("spaceNavigation")]
    public virtual ICollection<KeyDefinition> KeyDefinitions { get; } = new List<KeyDefinition>();

    [InverseProperty("Space")]
    public virtual ICollection<Location> Locations { get; } = new List<Location>();

    [ForeignKey("Parent")]
    [InverseProperty("InverseParentNavigation")]
    public virtual Space? ParentNavigation { get; set; }

    [InverseProperty("SpaceNavigation")]
    public virtual ICollection<RestaurantTable> RestaurantTables { get; } = new List<RestaurantTable>();

    [InverseProperty("spaceNavigation")]
    public virtual ICollection<RoomDetail> RoomDetails { get; } = new List<RoomDetail>();

    [InverseProperty("spaceNavigation")]
    public virtual ICollection<RouteSale> RouteSales { get; } = new List<RouteSale>();

    [InverseProperty("spaceNavigation")]
    public virtual ICollection<SpaceCapacity> SpaceCapacities { get; } = new List<SpaceCapacity>();

    [InverseProperty("spaceNavigation")]
    public virtual ICollection<SpaceDirection> SpaceDirections { get; } = new List<SpaceDirection>();

    [ForeignKey("Type")]
    [InverseProperty("SpaceTypeNavigations")]
    public virtual Lookup? TypeNavigation { get; set; }
}
