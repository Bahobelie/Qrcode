using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.CommonSchema;
public partial class ExchangeRateDTO{
    public int Id { get; set; }
    public int Code { get; set; }
    public int Currency { get; set; }
    public DateTime Date { get; set; }
    public decimal Buying { get; set; }
    public decimal Selling { get; set; }
    public string? Remark { get; set; }
}
