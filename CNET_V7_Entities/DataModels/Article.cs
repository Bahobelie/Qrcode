using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class Article
{
    public int Id { get; set; }

    public string? LocalCode { get; set; }

    public string? BarCode { get; set; }

    public int GslType { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int? Uom { get; set; }

    public int? Preference { get; set; }

    public decimal? Length { get; set; }

    public decimal? Width { get; set; }

    public decimal? Height { get; set; }

    public decimal? Weight { get; set; }

    public string? Color { get; set; }

    public string? Size { get; set; }

    public int? Brand { get; set; }

    public string? Generic { get; set; }

    public string? Model { get; set; }

    public string? Manufacturer { get; set; }

    public int? DefaultSupplier { get; set; }

    public int? CountryOrigin { get; set; }

    public int? DefaultCurrency { get; set; }

    public decimal? DefaultValue { get; set; }

    public decimal? PreviousValue { get; set; }

    public bool? NeedsUomconversion { get; set; }

    public int? LifetimeFactor { get; set; }

    public decimal? LifetimeValue { get; set; }

    public int? PackageForm { get; set; }

    public int? User { get; set; }

    public byte[]? CreatedOn { get; set; }

    public DateTime? LastModified { get; set; }

    public int? ParentId { get; set; }

    public string? DefaultImageUrl { get; set; }

    public bool? IsActive { get; set; }

    public bool? Locked { get; set; }

    public string? Remark { get; set; }

    public virtual ICollection<ArticleUser> ArticleUsers { get; } = new List<ArticleUser>();

    public virtual ICollection<ConversionDefinition> ConversionDefinitions { get; } = new List<ConversionDefinition>();

    public virtual Country? CountryOriginNavigation { get; set; }

    public virtual ICollection<Device> Devices { get; } = new List<Device>();

    public virtual ICollection<DiscountFactor> DiscountFactors { get; } = new List<DiscountFactor>();

    public virtual SystemConstant GslTypeNavigation { get; set; } = null!;

    public virtual ICollection<Gsluser> Gslusers { get; } = new List<Gsluser>();

    public virtual ICollection<Article> InverseParent { get; } = new List<Article>();

    public virtual ICollection<LineItem> LineItems { get; } = new List<LineItem>();

    public virtual Article? Parent { get; set; }

    public virtual Preference? PreferenceNavigation { get; set; }

    public virtual ICollection<SerialDefinition> SerialDefinitions { get; } = new List<SerialDefinition>();

    public virtual ICollection<Specification> Specifications { get; } = new List<Specification>();

    public virtual ICollection<StockBalance> StockBalances { get; } = new List<StockBalance>();

    public virtual ICollection<StockLevel> StockLevels { get; } = new List<StockLevel>();

    public virtual Lookup? UomNavigation { get; set; }

    public virtual ICollection<ValueChangeLog> ValueChangeLogs { get; } = new List<ValueChangeLog>();

    public virtual ICollection<Value> Values { get; } = new List<Value>();
}
