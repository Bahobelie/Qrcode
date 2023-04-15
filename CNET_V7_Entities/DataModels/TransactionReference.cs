using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class TransactionReference
{
    public int Id { get; set; }

    public int? Referring { get; set; }

    public int? ReferencingVoucherDefn { get; set; }

    public int? Referenced { get; set; }

    public int? ReferencedVoucherDefn { get; set; }

    public decimal? Value { get; set; }

    public int? RelationType { get; set; }

    public string? Remark { get; set; }

    public virtual Voucher? ReferencedNavigation { get; set; }

    public virtual SystemConstant? ReferencedVoucherDefnNavigation { get; set; }

    public virtual SystemConstant? ReferencingVoucherDefnNavigation { get; set; }

    public virtual Voucher? ReferringNavigation { get; set; }

    public virtual SystemConstant? RelationTypeNavigation { get; set; }
}
