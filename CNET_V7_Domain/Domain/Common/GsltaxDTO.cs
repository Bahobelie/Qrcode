using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.CommonSchema;
public partial class GsltaxDTO{
    public int Id { get; set; }
    public int Code { get; set; }
    public int Reference { get; set; }
    public int Tax { get; set; }
    public string? Remark { get; set; }
}
