using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_deliveryDispatchView
{
    [StringLength(26)]
    public string orderNumber { get; set; } = null!;

    [StringLength(26)]
    public string voucherType { get; set; } = null!;

    [StringLength(26)]
    public string? consignee { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    [StringLength(26)]
    public string? objectState { get; set; }

    public int voucherDefinition { get; set; }

    public string? supplierName { get; set; }

    public string? tin { get; set; }

    [StringLength(26)]
    public string? otherConsigneeCode { get; set; }

    [StringLength(26)]
    public string? pickupOrgUnitCode { get; set; }

    [StringLength(50)]
    public string? pickupOrgUnitDesc { get; set; }

    public double? pickupLatitude { get; set; }

    public double? pickupLongitude { get; set; }

    [StringLength(26)]
    public string? deliveryOrgUnitCode { get; set; }

    [StringLength(50)]
    public string? deliveryOrgUnitDesc { get; set; }

    public double? deliveryLatitude { get; set; }

    public double? deliveryLongitude { get; set; }
}
