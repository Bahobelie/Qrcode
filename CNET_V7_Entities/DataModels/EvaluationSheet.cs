using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class EvaluationSheet
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public int Voucher { get; set; }

    public int? Index { get; set; }

    public int? Question { get; set; }

    public string? Point { get; set; }

    public string? TimeRequired { get; set; }

    public string? IsBonus { get; set; }

    public string? Remark { get; set; }

    public virtual ICollection<AnswerSheet> AnswerSheets { get; } = new List<AnswerSheet>();

    public virtual Question? QuestionNavigation { get; set; }

    public virtual Voucher VoucherNavigation { get; set; } = null!;
}
