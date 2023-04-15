using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class Lookup
{
    public int Id { get; set; }

    public int Index { get; set; }

    public string Component { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? Value { get; set; }

    public bool IsDefault { get; set; }

    public bool IsActive { get; set; }

    public string? Remark { get; set; }

    public virtual ICollection<Article> Articles { get; } = new List<Article>();

    public virtual ICollection<Attachment> AttachmentCategoryNavigations { get; } = new List<Attachment>();

    public virtual ICollection<Attachment> AttachmentTypeNavigations { get; } = new List<Attachment>();

    public virtual ICollection<Language> Languages { get; } = new List<Language>();

    public virtual ICollection<StockBalance> StockBalances { get; } = new List<StockBalance>();
}
