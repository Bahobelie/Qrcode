using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.CommonSchema;
public partial class AttachmentDTO{
    public int Id { get; set; }
    public int? Type { get; set; }
    public int? Category { get; set; }
    public int? Index { get; set; }
    public int? Reference { get; set; }
    public string? Description { get; set; }
    public string? Url { get; set; }
    public string? Remark { get; set; }
}
