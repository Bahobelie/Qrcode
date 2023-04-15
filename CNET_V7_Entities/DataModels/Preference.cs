using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class Preference
{
    public int Id { get; set; }

    public int Code { get; set; }

    public int Pointer { get; set; }

    public int Reference { get; set; }

    public string Description { get; set; } = null!;

    public int Index { get; set; }

    public string? Font { get; set; }

    public int? Value { get; set; }

    public int? Parent { get; set; }

    public bool IsActive { get; set; }

    public string? Color { get; set; }

    public string? Remark { get; set; }

    public virtual ICollection<Article> Articles { get; } = new List<Article>();

    public virtual ICollection<ConsigneeUnit> ConsigneeUnits { get; } = new List<ConsigneeUnit>();

    public virtual ICollection<Consignee> Consignees { get; } = new List<Consignee>();

    public virtual ICollection<Preference> InverseParentNavigation { get; } = new List<Preference>();

    public virtual ICollection<OrderStationMap> OrderStationMaps { get; } = new List<OrderStationMap>();

    public virtual Preference? ParentNavigation { get; set; }

    public virtual SystemConstant PointerNavigation { get; set; } = null!;

    public virtual ICollection<PreferenceAccess> PreferenceAccesses { get; } = new List<PreferenceAccess>();

    public virtual ICollection<PreferentialValueFactor> PreferentialValueFactors { get; } = new List<PreferentialValueFactor>();

    public virtual SystemConstant ReferenceNavigation { get; set; } = null!;

    public virtual ICollection<Specification> Specifications { get; } = new List<Specification>();
}
