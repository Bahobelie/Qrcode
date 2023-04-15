using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_BankBalanceView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string trxType { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [StringLength(100)]
    public string? voucherDefinitionName { get; set; }

    [StringLength(26)]
    public string? consignee { get; set; }

    public string? tradeName { get; set; }

    public string? brandName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    [StringLength(26)]
    public string organizationUnitDefinition { get; set; } = null!;

    [StringLength(26)]
    public string orgType { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(40)]
    public string? accountNo { get; set; }

    [StringLength(50)]
    public string? bankdescription { get; set; }

    public int? gslType { get; set; }
}
