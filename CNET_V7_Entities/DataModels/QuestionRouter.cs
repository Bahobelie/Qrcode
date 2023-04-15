using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class QuestionRouter
{
    public int Id { get; set; }

    public int? QuestionDetail { get; set; }

    public int? Question { get; set; }

    public string? Remark { get; set; }

    public virtual QuestionDetail? QuestionDetailNavigation { get; set; }

    public virtual Question? QuestionNavigation { get; set; }
}
