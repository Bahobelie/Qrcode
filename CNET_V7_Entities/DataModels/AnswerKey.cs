using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class AnswerKey
{
    public int Id { get; set; }

    public int? Question { get; set; }

    public string? Answer { get; set; }

    public string? Remark { get; set; }

    public virtual Question? QuestionNavigation { get; set; }
}
