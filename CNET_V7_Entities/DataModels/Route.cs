using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class Route
{
    public int Id { get; set; }

    public int TransportType { get; set; }

    public string? Carrier { get; set; }

    public int? ObjectState { get; set; }

    public int FromCity { get; set; }

    public int FromStation { get; set; }

    public int ToCity { get; set; }

    public int ToStation { get; set; }

    public decimal? Distance { get; set; }

    public decimal? Duration { get; set; }

    public string? Remark { get; set; }

    public virtual SubCountry FromCityNavigation { get; set; } = null!;

    public virtual SystemConstant FromStationNavigation { get; set; } = null!;

    public virtual ObjectStateDefinition? ObjectStateNavigation { get; set; }

    public virtual SubCountry ToCityNavigation { get; set; } = null!;

    public virtual SystemConstant ToStationNavigation { get; set; } = null!;

    public virtual SystemConstant TransportTypeNavigation { get; set; } = null!;
}
