using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_CashDepositView
{
    [StringLength(26)]
    public string voucher { get; set; } = null!;

    public int Quantity { get; set; }

    [Column(TypeName = "money")]
    public decimal Total { get; set; }

    [StringLength(26)]
    public string Denomination { get; set; } = null!;

    [StringLength(26)]
    public string currency { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;
}
