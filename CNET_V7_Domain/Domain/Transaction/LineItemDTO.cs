using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.TransactionSchema;
public partial class LineItemDTO{
    public int Id { get; set; }
    public int? Index { get; set; }
    public int Voucher { get; set; }
    public int Article { get; set; }
    public string? Note { get; set; }
    public bool? Override { get; set; }
    public decimal? UnitAmount { get; set; }
    public int? Uom { get; set; }
    public double? Quantity { get; set; }
    public decimal? TotalAmount { get; set; }
    public decimal? Discount { get; set; }
    public decimal? AddCharge { get; set; }
    public int? Tax { get; set; }
    public decimal? TaxableAmount { get; set; }
    public decimal? TaxAmount { get; set; }
    public decimal? CalculatedCost { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? SerialCode1 { get; set; }
    public string? SerialCode2 { get; set; }
    public string? SerialCode3 { get; set; }
    public string? Extension1 { get; set; }
    public string? Extension2 { get; set; }
    public bool? IsVoid { get; set; }
    public int? Cart { get; set; }
    public byte[]? CreatedOn { get; set; }
    public DateTime? LastModified { get; set; }
    public string? Remark { get; set; }
}
