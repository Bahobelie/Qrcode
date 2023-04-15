using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class Question
{
    public int Id { get; set; }

    public int Code { get; set; }

    public int? Index { get; set; }

    public string? Description { get; set; }

    public int? Category { get; set; }

    public string? Topic { get; set; }

    public string? Level { get; set; }

    public string? Type { get; set; }

    public string? Appearance { get; set; }

    public string? Point { get; set; }

    public bool? AllowFraction { get; set; }

    public string? TimeRequired { get; set; }

    public string? Hint { get; set; }

    public bool? IsActive { get; set; }

    public int? LastState { get; set; }

    public DateTime? LastUpdate { get; set; }

    public virtual ICollection<AnswerKey> AnswerKeys { get; } = new List<AnswerKey>();

    public virtual ICollection<BlankFill> BlankFills { get; } = new List<BlankFill>();

    public virtual SystemConstant? CategoryNavigation { get; set; }

    public virtual ICollection<Choose> Chooses { get; } = new List<Choose>();

    public virtual ICollection<EvaluationSheet> EvaluationSheets { get; } = new List<EvaluationSheet>();

    public virtual ICollection<QuestionDetail> QuestionDetails { get; } = new List<QuestionDetail>();

    public virtual ICollection<QuestionRouter> QuestionRouters { get; } = new List<QuestionRouter>();

    public virtual ICollection<WriteUp> WriteUps { get; } = new List<WriteUp>();
}
