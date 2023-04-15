using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.ArticleSchema;
public partial class SpecificationDTO{
    public int Id { get; set; }
    public int? Article { get; set; }
    public int? Type { get; set; }
    public int? Category { get; set; }
    public int? Index { get; set; }
    public string? Attribute { get; set; }
    public string? Value { get; set; }
    public string? Font { get; set; }
    public string? Remark { get; set; }
}
