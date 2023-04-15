using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.ArticleSchema;
public partial class ValueChangeLogDTO{
    public int Id { get; set; }
    public int? Article { get; set; }
    public decimal? PreviousValue { get; set; }
    public decimal? NewValue { get; set; }
    public byte[]? TimeStamp { get; set; }
    public int? Activity { get; set; }
    public string? Remark { get; set; }
}
