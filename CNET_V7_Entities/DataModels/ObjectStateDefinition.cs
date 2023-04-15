using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class ObjectStateDefinition
{
    public int Id { get; set; }

    public int Code { get; set; }

    public int? Type { get; set; }

    public string? Description { get; set; }

    public string? Color { get; set; }

    public int? Font { get; set; }

    public string? Remark { get; set; }

    public virtual ObjectState? ObjectState { get; set; }

    public virtual ICollection<RelationalState> RelationalStates { get; } = new List<RelationalState>();

    public virtual ICollection<RequiredGsldetail> RequiredGsldetails { get; } = new List<RequiredGsldetail>();

    public virtual ICollection<Route> Routes { get; } = new List<Route>();

    public virtual SystemConstant? TypeNavigation { get; set; }

    public virtual ICollection<Voucher> Vouchers { get; } = new List<Voucher>();
}
