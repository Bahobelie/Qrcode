using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.QuestionarySchema;
public partial class QuestionRouterDTO{
    public int Id { get; set; }
    public int? QuestionDetail { get; set; }
    public int? Question { get; set; }
    public string? Remark { get; set; }
}
