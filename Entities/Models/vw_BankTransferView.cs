using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_BankTransferView
{
    [StringLength(26)]
    public string voucherCode { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string? consignee { get; set; }

    public string? consigneeName { get; set; }

    [StringLength(26)]
    public string bank { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    [StringLength(50)]
    public string description { get; set; } = null!;
}
