using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class Currency
{
    public int Id { get; set; }

    public int Code { get; set; }

    public int? Country { get; set; }

    public string? Description { get; set; }

    public string? Sign { get; set; }

    public string? Abbrivation { get; set; }

    public bool? IsDefault { get; set; }

    public string? Remark { get; set; }

    public virtual ICollection<Consignee> Consignees { get; } = new List<Consignee>();

    public virtual Country? CountryNavigation { get; set; }

    public virtual ICollection<Denomination> Denominations { get; } = new List<Denomination>();

    public virtual ICollection<ExchangeRate> ExchangeRates { get; } = new List<ExchangeRate>();

    public virtual ICollection<TransactionCurrency> TransactionCurrencies { get; } = new List<TransactionCurrency>();
}
