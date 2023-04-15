using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.CommonSchema;
public partial class BeginingBalanceDTO{
    public int Id { get; set; }
    public int Code { get; set; }
    public int? Reference { get; set; }
    public int? Period { get; set; }
    public decimal? Value { get; set; }
    public bool? IsProvisional { get; set; }
    public string? Remark { get; set; }
}
