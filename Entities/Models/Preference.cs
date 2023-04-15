using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Preference", Schema = "common")]
[Index("code", Name = "IX_Preference", IsUnique = true)]
[Index("description", Name = "_dta_index_Preference_5_24751541__K5_2")]
public partial class Preference
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string component { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(100)]
    public string description { get; set; } = null!;

    public byte index { get; set; }

    [StringLength(26)]
    public string? font { get; set; }

    [StringLength(50)]
    public string? value { get; set; }

    [StringLength(26)]
    public string? parent { get; set; }

    public bool isActive { get; set; }

    [StringLength(26)]
    public string? color { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("roleNavigation")]
    public virtual ICollection<AccessMatrix> AccessMatrices { get; } = new List<AccessMatrix>();

    [InverseProperty("preferenceNavigation")]
    public virtual ICollection<Address> Addresses { get; } = new List<Address>();

    [InverseProperty("preferenceNavigation")]
    public virtual ICollection<Article> Articles { get; } = new List<Article>();

    [InverseProperty("reference5")]
    public virtual ICollection<Attachment> Attachments { get; } = new List<Attachment>();

    [InverseProperty("cartNavigation")]
    public virtual ICollection<CartTransaction> CartTransactions { get; } = new List<CartTransaction>();

    [InverseProperty("preferenceNavigation")]
    public virtual ICollection<Device> Devices { get; } = new List<Device>();

    [InverseProperty("fifthMenuNavigation")]
    public virtual ICollection<MenuDesigner> MenuDesignerfifthMenuNavigations { get; } = new List<MenuDesigner>();

    [InverseProperty("firstMenuNavigation")]
    public virtual ICollection<MenuDesigner> MenuDesignerfirstMenuNavigations { get; } = new List<MenuDesigner>();

    [InverseProperty("fourthMenuNavigation")]
    public virtual ICollection<MenuDesigner> MenuDesignerfourthMenuNavigations { get; } = new List<MenuDesigner>();

    [InverseProperty("secondMenuNavigation")]
    public virtual ICollection<MenuDesigner> MenuDesignersecondMenuNavigations { get; } = new List<MenuDesigner>();

    [InverseProperty("sixthMenuNavigation")]
    public virtual ICollection<MenuDesigner> MenuDesignersixthMenuNavigations { get; } = new List<MenuDesigner>();

    [InverseProperty("thirdMenuNavigation")]
    public virtual ICollection<MenuDesigner> MenuDesignerthirdMenuNavigations { get; } = new List<MenuDesigner>();

    [InverseProperty("preferenceNavigation")]
    public virtual ICollection<OrderStationMap> OrderStationMaps { get; } = new List<OrderStationMap>();

    [InverseProperty("preferenceNavigation")]
    public virtual ICollection<Organization> Organizations { get; } = new List<Organization>();

    [InverseProperty("preferenceNavigation")]
    public virtual ICollection<Person> People { get; } = new List<Person>();

    [InverseProperty("preferenceNavigation")]
    public virtual ICollection<PreferenceAccess> PreferenceAccesses { get; } = new List<PreferenceAccess>();

    [InverseProperty("preferenceNavigation")]
    public virtual ICollection<PreferenceValueFactor> PreferenceValueFactors { get; } = new List<PreferenceValueFactor>();
}
