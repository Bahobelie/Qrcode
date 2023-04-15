using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class VoucherTerm
{
    public int Id { get; set; }

    public int Voucher { get; set; }

    public int Term { get; set; }

    public string? Value { get; set; }

    public string? Remark { get; set; }

    public virtual TermDefinition TermNavigation { get; set; } = null!;

    public virtual Voucher VoucherNavigation { get; set; } = null!;
}
