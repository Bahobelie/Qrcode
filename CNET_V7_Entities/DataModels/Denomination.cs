using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class Denomination
{
    public int Id { get; set; }

    public int Code { get; set; }

    public int Currency { get; set; }

    public string Description { get; set; } = null!;

    public decimal Weight { get; set; }

    public string Type { get; set; } = null!;

    public string? Remark { get; set; }

    public virtual Currency CurrencyNavigation { get; set; } = null!;

    public virtual ICollection<DenominationDetail> DenominationDetails { get; } = new List<DenominationDetail>();
}
