using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class ArticleUser
{
    public int Id { get; set; }

    public int? Type { get; set; }

    public int? Article { get; set; }

    public int? ConsigneeUnit { get; set; }

    public int? Role { get; set; }

    public decimal? Value { get; set; }

    public string? Remark { get; set; }

    public virtual Article? ArticleNavigation { get; set; }

    public virtual ConsigneeUnit? ConsigneeUnitNavigation { get; set; }
}
