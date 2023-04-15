using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class SerialDefinition
{
    public int Id { get; set; }

    public int? Article { get; set; }

    public string? Description { get; set; }

    public bool? IsMandatory { get; set; }

    public string? Remark { get; set; }

    public virtual Article? ArticleNavigation { get; set; }
}
