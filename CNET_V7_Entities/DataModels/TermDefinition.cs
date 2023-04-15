using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class TermDefinition
{
    public int Id { get; set; }

    public int? VoucherDefn { get; set; }

    public int? Category { get; set; }

    public string? Description { get; set; }

    public string? DefaultValue { get; set; }

    public bool? IsMandatory { get; set; }

    public string? Remark { get; set; }

    public virtual SystemConstant? CategoryNavigation { get; set; }

    public virtual SystemConstant? VoucherDefnNavigation { get; set; }

    public virtual ICollection<VoucherTerm> VoucherTerms { get; } = new List<VoucherTerm>();
}
