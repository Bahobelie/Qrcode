using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.QuestionarySchema;
public partial class AnswerSheetDTO{
    public int Id { get; set; }
    public int? Voucher { get; set; }
    public int? EvaluationSheet { get; set; }
    public string? Answer { get; set; }
    public string? PointObtained { get; set; }
    public string? Remark { get; set; }
}
