using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class Subtitle
{
    public int Id { get; set; }

    public int Media { get; set; }

    public int Language { get; set; }

    public string Url { get; set; } = null!;

    public string? Remark { get; set; }

    public virtual Language LanguageNavigation { get; set; } = null!;

    public virtual Cnetmedium MediaNavigation { get; set; } = null!;
}
