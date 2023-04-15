using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class Space
{
    public int Id { get; set; }

    public int Code { get; set; }

    public int? Category { get; set; }

    public string? Description { get; set; }

    public int? Type { get; set; }

    public int? Parent { get; set; }

    public int? OrganizationalUnit { get; set; }

    public string? Remark { get; set; }

    public virtual SystemConstant? CategoryNavigation { get; set; }

    public virtual ICollection<Space> InverseParentNavigation { get; } = new List<Space>();

    public virtual ICollection<Location> Locations { get; } = new List<Location>();

    public virtual ICollection<MovieSchedule> MovieSchedules { get; } = new List<MovieSchedule>();

    public virtual ConsigneeUnit? OrganizationalUnitNavigation { get; set; }

    public virtual Space? ParentNavigation { get; set; }

    public virtual ICollection<RouteAssignment> RouteAssignments { get; } = new List<RouteAssignment>();

    public virtual ICollection<SeatArrangement> SeatArrangements { get; } = new List<SeatArrangement>();

    public virtual ICollection<SpaceDirection> SpaceDirections { get; } = new List<SpaceDirection>();

    public virtual SystemConstant? TypeNavigation { get; set; }
}
