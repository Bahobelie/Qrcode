using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.QuestionarySchema;
public partial class QuestionDTO{
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
}
