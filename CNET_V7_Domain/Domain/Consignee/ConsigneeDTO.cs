using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.ConsigneeSchema;
public partial class ConsigneeDTO{
    public int Id { get; set; }
    public string Code { get; set; } = null!;
    public int GslType { get; set; }
    public string? IdNumber { get; set; }
    public string? Tin { get; set; }
    public int? Title { get; set; }
    public string? FirstName { get; set; }
    public string? SecondName { get; set; }
    public string? ThirdName { get; set; }
    public int? Gender { get; set; }
    public int? BusinessType { get; set; }
    public int? Preference { get; set; }
    public DateTime? StartDate { get; set; }
    public int? Nationality { get; set; }
    public bool? IsActive { get; set; }
    public int? MaritalStatus { get; set; }
    public string? Note { get; set; }
    public byte[]? CreatedOn { get; set; }
    public DateTime? LastModified { get; set; }
    public int? MainConsigneeUnit { get; set; }
    public int? ParentId { get; set; }
    public int? ComminicationSource { get; set; }
    public int? DefaultLanguage { get; set; }
    public int? DefaultCurrency { get; set; }
    public string? DefaultImageUrl { get; set; }
    public bool? Locked { get; set; }
    public string? Remark { get; set; }
}
