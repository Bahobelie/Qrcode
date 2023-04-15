using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class SeatArrangement
{
    public int Id { get; set; }

    public int Space { get; set; }

    public string Type { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Class { get; set; }

    public string? Zone { get; set; }

    public int X { get; set; }

    public int Y { get; set; }

    public string? Remark { get; set; }

    public virtual ICollection<SeatTransaction> SeatTransactions { get; } = new List<SeatTransaction>();

    public virtual Space SpaceNavigation { get; set; } = null!;
}
