using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Article", Schema = "common")]
[Index("gslType", Name = "GSL_Type_Index")]
[Index("code", Name = "IX_Article", IsUnique = true)]
[Index("code", Name = "_dta_index_Article_5_1139743363__K2_4")]
public partial class Article
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int gslType { get; set; }

    public string name { get; set; } = null!;

    [StringLength(26)]
    public string preference { get; set; } = null!;

    [StringLength(15)]
    public string uom { get; set; } = null!;

    public bool isActive { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("referenceNavigation")]
    public virtual ICollection<AccountMap> AccountMaps { get; } = new List<AccountMap>();

    [InverseProperty("referenceNavigation")]
    public virtual ICollection<Activity> Activities { get; } = new List<Activity>();

    [InverseProperty("referenceNavigation")]
    public virtual ICollection<Attachment> Attachments { get; } = new List<Attachment>();

    [InverseProperty("referenceNavigation")]
    public virtual ICollection<Beginning> Beginnings { get; } = new List<Beginning>();

    [InverseProperty("articleNavigation")]
    public virtual ICollection<CNETMedium> CNETMedia { get; } = new List<CNETMedium>();

    [InverseProperty("referenceNavigation")]
    public virtual ICollection<CommunicationSource> CommunicationSources { get; } = new List<CommunicationSource>();

    [InverseProperty("ReferenceNavigation")]
    public virtual ICollection<CurrencyPreference> CurrencyPreferences { get; } = new List<CurrencyPreference>();

    [InverseProperty("articleNavigation")]
    public virtual ICollection<Device> Devices { get; } = new List<Device>();

    [InverseProperty("ArticleNavigation")]
    public virtual ICollection<DiscountFactor> DiscountFactors { get; } = new List<DiscountFactor>();

    [InverseProperty("referenceNavigation")]
    public virtual ICollection<GSLTax> GSLTaxes { get; } = new List<GSLTax>();

    [InverseProperty("referenceNavigation")]
    public virtual ICollection<IdSetting> IdSettings { get; } = new List<IdSetting>();

    [InverseProperty("referenceNavigation")]
    public virtual ICollection<Identification> Identifications { get; } = new List<Identification>();

    [InverseProperty("referenceNavigation")]
    public virtual ICollection<IndustryInvolved> IndustryInvolveds { get; } = new List<IndustryInvolved>();

    [InverseProperty("referenceNavigation")]
    public virtual ICollection<Lifetime> Lifetimes { get; } = new List<Lifetime>();

    [InverseProperty("articleNavigation")]
    public virtual ICollection<LineItem> LineItems { get; } = new List<LineItem>();

    [InverseProperty("referenceNavigation")]
    public virtual ICollection<Location> Locations { get; } = new List<Location>();

    [InverseProperty("referenceNavigation")]
    public virtual ICollection<ObjectState> ObjectStates { get; } = new List<ObjectState>();

    [InverseProperty("articleNavigation")]
    public virtual ICollection<OptionalCode> OptionalCodes { get; } = new List<OptionalCode>();

    [InverseProperty("articleNavigation")]
    public virtual ICollection<PackageHeader> PackageHeaders { get; } = new List<PackageHeader>();

    [InverseProperty("articleNavigation")]
    public virtual ICollection<PhysicalDimension> PhysicalDimensions { get; } = new List<PhysicalDimension>();

    [InverseProperty("articleNavigation")]
    public virtual ICollection<ProductExtension> ProductExtensions { get; } = new List<ProductExtension>();

    [InverseProperty("referenceObjectNavigation")]
    public virtual ICollection<Relation> Relations { get; } = new List<Relation>();

    [InverseProperty("articleNavigation")]
    public virtual ICollection<RemovedItem> RemovedItems { get; } = new List<RemovedItem>();

    [InverseProperty("articleNavigation")]
    public virtual ICollection<SerialDefinition> SerialDefinitions { get; } = new List<SerialDefinition>();

    [InverseProperty("articleNavigation")]
    public virtual ICollection<Specification> Specifications { get; } = new List<Specification>();

    [InverseProperty("articleNavigation")]
    public virtual ICollection<StockBalance> StockBalances { get; } = new List<StockBalance>();

    [InverseProperty("articleNavigation")]
    public virtual ICollection<StockLevel> StockLevels { get; } = new List<StockLevel>();

    [InverseProperty("articleNavigation")]
    public virtual ICollection<TranRoutingDetail> TranRoutingDetails { get; } = new List<TranRoutingDetail>();

    [InverseProperty("referenceNavigation")]
    public virtual ICollection<TransactionLimit> TransactionLimits { get; } = new List<TransactionLimit>();

    [InverseProperty("referenceNavigation")]
    public virtual ICollection<Translation> Translations { get; } = new List<Translation>();

    [InverseProperty("referenceNavigation")]
    public virtual ICollection<ValueFactor> ValueFactors { get; } = new List<ValueFactor>();

    [InverseProperty("articleNavigation")]
    public virtual ICollection<Value> Values { get; } = new List<Value>();

    [ForeignKey("gslType")]
    [InverseProperty("Articles")]
    public virtual GSLTypeList gslTypeNavigation { get; set; } = null!;

    [ForeignKey("preference")]
    [InverseProperty("Articles")]
    public virtual Preference preferenceNavigation { get; set; } = null!;
}
