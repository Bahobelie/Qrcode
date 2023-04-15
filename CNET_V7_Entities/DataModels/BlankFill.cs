using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class BlankFill
{
    public int Id { get; set; }

    public int Question { get; set; }

    public int? NoOfBlanks { get; set; }

    public int? CharLength { get; set; }

    public string? Remark { get; set; }

    public virtual Question QuestionNavigation { get; set; } = null!;
}
