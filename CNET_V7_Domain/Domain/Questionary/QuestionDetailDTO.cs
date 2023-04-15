using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.QuestionarySchema;
public partial class QuestionDetailDTO{
    public int Id { get; set; }
    public int Question { get; set; }
    public string? Symbol { get; set; }
    public string? Description { get; set; }
    public string? Hint { get; set; }
    public string? Point { get; set; }
    public string? Remark { get; set; }
}
