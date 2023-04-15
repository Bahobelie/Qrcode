using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_consolidated_product_company_review_view
{
    public string? companyTin { get; set; }

    [StringLength(26)]
    public string voucherCode { get; set; } = null!;

    public bool IsIssued { get; set; }

    public int voucherDefinition { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    [StringLength(26)]
    public string? consignee_code { get; set; }

    public string? consignee_name { get; set; }

    public string? note { get; set; }

    public string? Mobilephone { get; set; }

    [StringLength(26)]
    public string? firstArticleCode { get; set; }

    public string? firstArticleName { get; set; }

    [StringLength(26)]
    public string? branch { get; set; }

    public long? r { get; set; }
}
