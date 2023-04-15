using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class VoucherStoreMapping
{
    public int Id { get; set; }

    public int VoucherDefinition { get; set; }

    public int Store { get; set; }

    public bool IsSource { get; set; }

    public bool IsDefault { get; set; }

    public string? Remark { get; set; }

    public virtual ConsigneeUnit StoreNavigation { get; set; } = null!;

    public virtual SystemConstant VoucherDefinitionNavigation { get; set; } = null!;
}
