using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class Period
{
    public int Id { get; set; }

    public string PeriodName { get; set; } = null!;

    public int Type { get; set; }

    public int? Category { get; set; }

    public DateTime Start { get; set; }

    public DateTime End { get; set; }

    public string? Parent { get; set; }

    public int? Index { get; set; }

    public string? Remark { get; set; }

    public virtual ICollection<Activity> Activities { get; } = new List<Activity>();

    public virtual ICollection<BeginingBalance> BeginingBalances { get; } = new List<BeginingBalance>();

    public virtual ICollection<Holiday> HolidayActualPeriodNavigations { get; } = new List<Holiday>();

    public virtual ICollection<Holiday> HolidayForecastedPeriodNavigations { get; } = new List<Holiday>();

    public virtual ICollection<JournalDetail> JournalDetails { get; } = new List<JournalDetail>();

    public virtual ICollection<ReportHistory> ReportHistories { get; } = new List<ReportHistory>();

    public virtual ICollection<SeasonalMessage> SeasonalMessages { get; } = new List<SeasonalMessage>();

    public virtual ICollection<StockBalance> StockBalances { get; } = new List<StockBalance>();

    public virtual ICollection<TrialBalance> TrialBalances { get; } = new List<TrialBalance>();

    public virtual SystemConstant TypeNavigation { get; set; } = null!;

    public virtual ICollection<Voucher> VoucherPeriodNavigations { get; } = new List<Voucher>();

    public virtual ICollection<Voucher> VoucherShiftNavigations { get; } = new List<Voucher>();
}
