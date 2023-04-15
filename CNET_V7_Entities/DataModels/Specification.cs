using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class Specification
{
    public int Id { get; set; }

    public int? Article { get; set; }

    public int? Type { get; set; }

    public int? Category { get; set; }

    public int? Index { get; set; }

    public string? Attribute { get; set; }

    public string? Value { get; set; }

    public string? Font { get; set; }

    public string? Remark { get; set; }

    public virtual Article? ArticleNavigation { get; set; }

    public virtual Preference? CategoryNavigation { get; set; }
}
