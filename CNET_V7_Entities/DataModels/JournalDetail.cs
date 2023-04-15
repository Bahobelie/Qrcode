using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class JournalDetail
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public int? Voucher { get; set; }

    public string? Account { get; set; }

    public decimal? Debit { get; set; }

    public decimal? Credit { get; set; }

    public int? Cart { get; set; }

    public byte[]? TimeStamp { get; set; }

    public int? IsReconciled { get; set; }

    public int? ReconPeriod { get; set; }

    public int? Locked { get; set; }

    public string? Remark { get; set; }

    public virtual Period? ReconPeriodNavigation { get; set; }

    public virtual Voucher? VoucherNavigation { get; set; }
}
