using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class ValueChangeLog
{
    public int Id { get; set; }

    public int? Article { get; set; }

    public decimal? PreviousValue { get; set; }

    public decimal? NewValue { get; set; }

    public byte[]? TimeStamp { get; set; }

    public int? Activity { get; set; }

    public string? Remark { get; set; }

    public virtual Article? ArticleNavigation { get; set; }
}
