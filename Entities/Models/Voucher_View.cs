using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class Voucher_View
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string consignee { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    public bool IsIssued { get; set; }

    public bool IsVoid { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    [StringLength(100)]
    public string remark { get; set; } = null!;

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    public string consignee_Description { get; set; } = null!;

    public string period_Name { get; set; } = null!;

    [StringLength(26)]
    public string LastObjectState_color { get; set; } = null!;

    [StringLength(26)]
    public string LastObjectState_font { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal sub_total { get; set; }

    [Column(TypeName = "money")]
    public decimal additionalCharge { get; set; }

    [Column(TypeName = "money")]
    public decimal discount { get; set; }

    [Column(TypeName = "money")]
    public decimal tax_amount { get; set; }

    public int LineItem_Count { get; set; }

    [StringLength(30)]
    public string? prepared_by { get; set; }

    [StringLength(26)]
    public string Object_State_Colour { get; set; } = null!;

    [StringLength(26)]
    public string Object_State_Font { get; set; } = null!;
}
