using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.ArticleSchema;
public partial class ConversionDefinitionDTO{
    public int Id { get; set; }
    public int? Article { get; set; }
    public int? Index { get; set; }
    public int? FromUom { get; set; }
    public decimal? FromQty { get; set; }
    public int? ToQty { get; set; }
    public string? Remark { get; set; }
}
