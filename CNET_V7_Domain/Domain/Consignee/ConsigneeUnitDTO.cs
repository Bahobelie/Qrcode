using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.ConsigneeSchema;
public partial class ConsigneeUnitDTO{
    public int Id { get; set; }
    public int Code { get; set; }
    public int? Consignee { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public int? Type { get; set; }
    public int? IndustryInvolved { get; set; }
    public int? Purpose { get; set; }
    public int? Preference { get; set; }
    public string? Abrivation { get; set; }
    public double? Longitude { get; set; }
    public double? Latitude { get; set; }
    public string? Contact { get; set; }
    public string? Phone1 { get; set; }
    public string? Phone2 { get; set; }
    public string? Email { get; set; }
    public string? Website { get; set; }
    public string? SpecificAddress { get; set; }
    public string? Street { get; set; }
    public string? HouseNumber { get; set; }
    public string? PoBox { get; set; }
    public string? Kebele { get; set; }
    public string? Wereda { get; set; }
    public int? Subcity { get; set; }
    public int? City { get; set; }
    public int? Region { get; set; }
    public int? Country { get; set; }
    public string? AddressLine1 { get; set; }
    public string? AddressLine2 { get; set; }
    public string? AddressLine3 { get; set; }
    public int? ParentId { get; set; }
    public byte[]? CreatedOn { get; set; }
    public DateTime? LastModified { get; set; }
    public bool? IsActive { get; set; }
    public bool? Locked { get; set; }
    public bool? IsOnline { get; set; }
    public string? DefaultImageUrl { get; set; }
    public string? Remark { get; set; }
}
