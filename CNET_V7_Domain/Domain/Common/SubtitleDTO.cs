using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.CommonSchema;
public partial class SubtitleDTO{
    public int Id { get; set; }
    public int Media { get; set; }
    public int Language { get; set; }
    public string Url { get; set; } = null!;
    public string? Remark { get; set; }
}
