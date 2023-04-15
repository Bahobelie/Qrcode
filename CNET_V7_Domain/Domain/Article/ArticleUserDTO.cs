using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.ArticleSchema;
public partial class ArticleUserDTO{
    public int Id { get; set; }
    public int? Type { get; set; }
    public int? Article { get; set; }
    public int? ConsigneeUnit { get; set; }
    public int? Role { get; set; }
    public decimal? Value { get; set; }
    public string? Remark { get; set; }
}
