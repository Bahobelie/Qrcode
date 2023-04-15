using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.QuestionarySchema;
public partial class AnswerKeyDTO{
    public int Id { get; set; }
    public int? Question { get; set; }
    public string? Answer { get; set; }
    public string? Remark { get; set; }
}
