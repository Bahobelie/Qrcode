using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class Cnetmedium
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string StreamUrl { get; set; } = null!;

    public int Type { get; set; }

    public int Category { get; set; }

    public string? Article { get; set; }

    public int? Index { get; set; }

    public bool? Active { get; set; }

    public string? Remark { get; set; }

    public virtual SystemConstant CategoryNavigation { get; set; } = null!;

    public virtual ICollection<Movie> Movies { get; } = new List<Movie>();

    public virtual ICollection<Subtitle> Subtitles { get; } = new List<Subtitle>();

    public virtual SystemConstant TypeNavigation { get; set; } = null!;
}
