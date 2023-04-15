using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.ArticleSchema;
public partial class ValueDTO{
    public int Id { get; set; }
    public int? Article { get; set; }
    public string? Description { get; set; }
    public int? ConsigneeUnit { get; set; }
    public int? Schedule { get; set; }
    public decimal? MinCount { get; set; }
    public decimal? MaxCount { get; set; }
    public DateTime? StartTimeStamp { get; set; }
    public DateTime? EndTimeStamp { get; set; }
    public int? Currency { get; set; }
    public decimal? OldValue { get; set; }
    public decimal? NewValue { get; set; }
    public bool? IsDefault { get; set; }
    public int? Priority { get; set; }
    public DateTime? CreatedTimeStamp { get; set; }
    public DateTime? LastModified { get; set; }
    public bool? Locked { get; set; }
    public string? Remark { get; set; }
}
