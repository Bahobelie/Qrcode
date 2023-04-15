using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class HolidayDefinition
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public string Type { get; set; } = null!;

    public bool IsFixed { get; set; }

    public bool WillClose { get; set; }

    public int? AlertBefore { get; set; }

    public string? Remark { get; set; }

    public virtual ICollection<Holiday> Holidays { get; } = new List<Holiday>();
}
