using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_SubscriptionAgingView
{
    [StringLength(26)]
    public string voucherCode { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string? consignee { get; set; }

    public bool IsIssued { get; set; }

    public string articleName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime prodDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime expiryDate { get; set; }

    [StringLength(26)]
    public string articleCode { get; set; } = null!;

    [StringLength(200)]
    public string spaceDescription { get; set; } = null!;

    [StringLength(26)]
    public string spaceCode { get; set; } = null!;

    public string name { get; set; } = null!;

    [StringLength(26)]
    public string lineItemCode { get; set; } = null!;

    [StringLength(100)]
    public string? lineItemRemark { get; set; }

    [StringLength(26)]
    public string? licensePlate { get; set; }

    [StringLength(26)]
    public string? roomNumber { get; set; }
}
