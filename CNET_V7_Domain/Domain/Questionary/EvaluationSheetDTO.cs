using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.QuestionarySchema;
public partial class EvaluationSheetDTO{
    public int Id { get; set; }
    public string Code { get; set; } = null!;
    public int Voucher { get; set; }
    public int? Index { get; set; }
    public int? Question { get; set; }
    public string? Point { get; set; }
    public string? TimeRequired { get; set; }
    public string? IsBonus { get; set; }
    public string? Remark { get; set; }
}
