using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class ExchangeRate
{
    public int Id { get; set; }

    public int Code { get; set; }

    public int Currency { get; set; }

    public DateTime Date { get; set; }

    public decimal Buying { get; set; }

    public decimal Selling { get; set; }

    public string? Remark { get; set; }

    public virtual Currency CurrencyNavigation { get; set; } = null!;
}
