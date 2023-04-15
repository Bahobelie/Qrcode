using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.ConsigneeSchema;
public partial class IdentificationDTO{
    public int Id { get; set; }
    public int? Consignee { get; set; }
    public string? Description { get; set; }
    public int? Type { get; set; }
    public string? IdNumber { get; set; }
    public DateTime IssueDate { get; set; }
    public DateTime? ExpiryDate { get; set; }
    public string? Issuer { get; set; }
    public string? Remark { get; set; }
}
