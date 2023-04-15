using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.ArticleSchema;
public partial class SerialDefinitionDTO{
    public int Id { get; set; }
    public int? Article { get; set; }
    public string? Description { get; set; }
    public bool? IsMandatory { get; set; }
    public string? Remark { get; set; }
}
