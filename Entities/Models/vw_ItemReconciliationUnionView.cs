using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_ItemReconciliationUnionView
{
    [StringLength(26)]
    public string orderVoucherCode { get; set; } = null!;

    [StringLength(26)]
    public string? consignee { get; set; }

    public string? consigneeName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime orderDate { get; set; }

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    [StringLength(50)]
    public string lastState { get; set; } = null!;

    [StringLength(26)]
    public string articleCode { get; set; } = null!;

    public string articleName { get; set; } = null!;

    [StringLength(26)]
    public string? sr_user_code { get; set; }

    [StringLength(30)]
    public string sr_user_name { get; set; } = null!;

    [Column(TypeName = "decimal(18, 4)")]
    public decimal orderQuantity { get; set; }

    [Column(TypeName = "money")]
    public decimal? orderUnitAmt { get; set; }

    [Column(TypeName = "money")]
    public decimal? orderTotal { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? invoiceQty { get; set; }

    [Column(TypeName = "money")]
    public decimal? invoiceUnitAmt { get; set; }

    [Column(TypeName = "money")]
    public decimal? invoiceTotal { get; set; }

    [StringLength(26)]
    public string? invoiceVoucherCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? deliveryDate { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? value { get; set; }

    [StringLength(26)]
    public string? vsm_user_code { get; set; }

    [StringLength(30)]
    public string? vsm_user_name { get; set; }

    [StringLength(50)]
    public string? machine_number { get; set; }

    [Column(TypeName = "money")]
    public decimal? price_before_vat { get; set; }

    [Column(TypeName = "money")]
    public decimal? vat { get; set; }

    public string? sem_id { get; set; }

    public string? distributer { get; set; }
}
