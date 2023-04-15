using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class DenominationDetail
{
    public int Id { get; set; }

    public int? Code { get; set; }

    public int? TransactionCurrencyRef { get; set; }

    public int? Denomination { get; set; }

    public int? Quantity { get; set; }

    public decimal? Total { get; set; }

    public string? Remark { get; set; }

    public virtual Denomination? DenominationNavigation { get; set; }

    public virtual TransactionCurrency? TransactionCurrencyRefNavigation { get; set; }
}
