using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class RequiredGsl
{
    public int Id { get; set; }

    public int? VoucherDefn { get; set; }

    public int? Type { get; set; }

    public int? Index { get; set; }

    public string? Description { get; set; }

    public bool? IsMandatory { get; set; }

    public string? Remark { get; set; }

    public virtual ICollection<RequiredGsldetail> RequiredGsldetails { get; } = new List<RequiredGsldetail>();

    public virtual SystemConstant? TypeNavigation { get; set; }

    public virtual SystemConstant? VoucherDefnNavigation { get; set; }
}
