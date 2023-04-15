using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class LanguagePreference
{
    public int Id { get; set; }

    public int Consignee { get; set; }

    public int Language { get; set; }

    public int? Proficiency { get; set; }

    public string? Remark { get; set; }

    public virtual Consignee ConsigneeNavigation { get; set; } = null!;

    public virtual Language LanguageNavigation { get; set; } = null!;
}
