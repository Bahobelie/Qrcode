using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class Choose
{
    public int Id { get; set; }

    public int? Question { get; set; }

    public string? Symbol { get; set; }

    public string? Description { get; set; }

    public string? Hint { get; set; }

    public string? Point { get; set; }

    public string? Remark { get; set; }

    public virtual Question? QuestionNavigation { get; set; }
}
