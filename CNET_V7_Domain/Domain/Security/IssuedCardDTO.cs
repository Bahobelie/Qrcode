using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.SecuritySchema;
public partial class IssuedCardDTO{
    public int Id { get; set; }
    public int Card { get; set; }
    public int? Consignee { get; set; }
    public string? Remark { get; set; }
}
