using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("OrganizationUnitDefinition", Schema = "common")]
[Index("code", Name = "IX_OrganizationUnitDefinition", IsUnique = true)]
public partial class OrganizationUnitDefinition
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [StringLength(26)]
    public string? parentId { get; set; }

    [StringLength(50)]
    public string? specialization { get; set; }

    [StringLength(26)]
    public string? abbriviation { get; set; }

    public string? remark { get; set; }

    [InverseProperty("organizationUnitDefNavigation")]
    public virtual ICollection<Activity> Activities { get; } = new List<Activity>();

    [InverseProperty("RoleNavigation")]
    public virtual ICollection<GSLUser> GSLUsers { get; } = new List<GSLUser>();

    [InverseProperty("organizationUnitDefinitionNavigation")]
    public virtual ICollection<OrganizationUnit> OrganizationUnits { get; } = new List<OrganizationUnit>();

    [InverseProperty("guestNavigation")]
    public virtual ICollection<ResidentSummary> ResidentSummaries { get; } = new List<ResidentSummary>();

    [InverseProperty("orgUnitNavigation")]
    public virtual ICollection<RouteSale> RouteSales { get; } = new List<RouteSale>();

    [InverseProperty("storeNavigation")]
    public virtual ICollection<StockBalance> StockBalances { get; } = new List<StockBalance>();

    [InverseProperty("storeNavigation")]
    public virtual ICollection<StockLevel> StockLevels { get; } = new List<StockLevel>();

    [InverseProperty("destinationNavigation")]
    public virtual ICollection<StoreTransaction> StoreTransactiondestinationNavigations { get; } = new List<StoreTransaction>();

    [InverseProperty("sourceNavigation")]
    public virtual ICollection<StoreTransaction> StoreTransactionsourceNavigations { get; } = new List<StoreTransaction>();

    [InverseProperty("storeNavigation")]
    public virtual ICollection<VoucherStoreMapping> VoucherStoreMappings { get; } = new List<VoucherStoreMapping>();

    [ForeignKey("type")]
    [InverseProperty("OrganizationUnitDefinitions")]
    public virtual Lookup typeNavigation { get; set; } = null!;
}
