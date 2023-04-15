using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.ConsigneeSchema;
public partial class LanguagePreferenceDTO{
    public int Id { get; set; }
    public int Consignee { get; set; }
    public int Language { get; set; }
    public int? Proficiency { get; set; }
    public string? Remark { get; set; }
}
