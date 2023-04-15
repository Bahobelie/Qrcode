using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class ReconciliationDetail
{
    public int Id { get; set; }

    public int ReconSum { get; set; }

    public int VoucherDefinition { get; set; }

    public bool IsDebit { get; set; }

    public string? Remark { get; set; }

    public virtual ReconciliationSummary ReconSumNavigation { get; set; } = null!;

    public virtual SystemConstant VoucherDefinitionNavigation { get; set; } = null!;
}
