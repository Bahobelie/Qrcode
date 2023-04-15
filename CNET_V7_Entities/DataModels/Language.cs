using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class Language
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public int Type { get; set; }

    public int Pointer { get; set; }

    public string Reference { get; set; } = null!;

    public string? Remark { get; set; }

    public virtual ICollection<Consignee> Consignees { get; } = new List<Consignee>();

    public virtual ICollection<LanguagePreference> LanguagePreferences { get; } = new List<LanguagePreference>();

    public virtual SystemConstant PointerNavigation { get; set; } = null!;

    public virtual ICollection<Subtitle> Subtitles { get; } = new List<Subtitle>();

    public virtual Lookup TypeNavigation { get; set; } = null!;
}
