using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.AccountingSchema;
public partial class GslacctRequirementDTO{
    public int Id { get; set; }
    public int ContAcct { get; set; }
    public int GslTypeList { get; set; }
    public bool IsMandatory { get; set; }
    public bool RestrictSelection { get; set; }
    public string? Remark { get; set; }
}
