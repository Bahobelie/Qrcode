using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class WriteUp
{
    public int Id { get; set; }

    public int? Question { get; set; }

    public int? NoOfBlank { get; set; }

    public int? CharacterLength { get; set; }

    public string? Remark { get; set; }

    public virtual Question? QuestionNavigation { get; set; }
}
