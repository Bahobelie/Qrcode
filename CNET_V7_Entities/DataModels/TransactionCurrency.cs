using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class TransactionCurrency
{
    public int Id { get; set; }

    public int Voucher { get; set; }

    public int Currency { get; set; }

    public decimal? Rate { get; set; }

    public decimal? Amount { get; set; }

    public decimal? Total { get; set; }

    public string? Remark { get; set; }

    public virtual Currency CurrencyNavigation { get; set; } = null!;

    public virtual ICollection<DenominationDetail> DenominationDetails { get; } = new List<DenominationDetail>();

    public virtual Voucher VoucherNavigation { get; set; } = null!;
}
