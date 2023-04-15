using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.QuestionarySchema;
public partial class BlankFillDTO{
    public int Id { get; set; }
    public int Question { get; set; }
    public int? NoOfBlanks { get; set; }
    public int? CharLength { get; set; }
    public string? Remark { get; set; }
}
