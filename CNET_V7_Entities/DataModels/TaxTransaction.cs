using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class TaxTransaction
{
    public int Id { get; set; }

    public int Voucher { get; set; }

    public int? TaxType { get; set; }

    public decimal? TaxableAmount { get; set; }

    public decimal? TaxAmount { get; set; }

    public string? Remark { get; set; }

    public virtual Tax? TaxTypeNavigation { get; set; }

    public virtual Voucher VoucherNavigation { get; set; } = null!;
}
