using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class ViewGetVoucherExtTran
{
    [StringLength(26)]
    public string transCode { get; set; } = null!;

    [StringLength(26)]
    public string number { get; set; } = null!;

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(26)]
    public string extCode { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(26)]
    public string voucherExtension { get; set; } = null!;

    public byte Index { get; set; }

    public int voucherDefn { get; set; }

    public bool isMandatory { get; set; }
}
