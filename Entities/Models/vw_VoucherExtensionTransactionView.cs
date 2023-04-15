using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_VoucherExtensionTransactionView
{
    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(50)]
    public string VoucherExtensionDescription { get; set; } = null!;

    [StringLength(26)]
    public string number { get; set; } = null!;

    [StringLength(26)]
    public string voExtensionCode { get; set; } = null!;

    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }
}
