using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.TransactionSchema;
public partial class VoucherDTO{
    public int Id { get; set; }
    public string Code { get; set; } = null!;
    public int? Type { get; set; }
    public int? Definition { get; set; }
    public int? OriginConsigneeUnit { get; set; }
    public int? DestinationConsigneeUnit { get; set; }
    public int? Period { get; set; }
    public int? Shift { get; set; }
    public int? Consignee1 { get; set; }
    public int? ConsigneeUnit1 { get; set; }
    public int? Consignee2 { get; set; }
    public int? ConsigneeUnit2 { get; set; }
    public int? Consignee3 { get; set; }
    public int? ConsigneeUnit3 { get; set; }
    public int? Consignee4 { get; set; }
    public int? ConsigneeUnit4 { get; set; }
    public int? Consignee5 { get; set; }
    public int? ConsigneeUnit5 { get; set; }
    public int? Consignee6 { get; set; }
    public int? ConsigneeUnit6 { get; set; }
    public DateTime IssuedDate { get; set; }
    public bool? IsIssued { get; set; }
    public bool? IsVoid { get; set; }
    public int? Date { get; set; }
    public int? Month { get; set; }
    public int? Year { get; set; }
    public decimal? SubTotal { get; set; }
    public decimal? Discount { get; set; }
    public decimal? AdditionalCharge { get; set; }
    public decimal? GrandTotal { get; set; }
    public int? PaymentMethod { get; set; }
    public int? Currency { get; set; }
    public int? ExchangeRate { get; set; }
    public string? Note { get; set; }
    public int? Purpose { get; set; }
    public string? FsNumber { get; set; }
    public string? Mrc { get; set; }
    public int? Cart { get; set; }
    public string? Extension1 { get; set; }
    public string? Extension2 { get; set; }
    public string? Extension3 { get; set; }
    public string? Extension4 { get; set; }
    public DateTime? Extension5 { get; set; }
    public DateTime? Extension6 { get; set; }
    public int? SourceStore { get; set; }
    public int? DestinationStore { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public bool? HasEffect { get; set; }
    public int? LastActivity { get; set; }
    public int? LastUser { get; set; }
    public int? LastDevice { get; set; }
    public int? LastState { get; set; }
    public byte[]? CreatedOn { get; set; }
    public DateTime? LastModified { get; set; }
    public decimal? Latitiude { get; set; }
    public decimal? Longitude { get; set; }
    public bool? Locked { get; set; }
    public string? DefaultImageUrl { get; set; }
    public string? Remark { get; set; }
}
