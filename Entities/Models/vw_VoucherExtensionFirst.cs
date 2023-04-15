using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_VoucherExtensionFirst
{
    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(26)]
    public string vouchExtOne { get; set; } = null!;

    [StringLength(50)]
    public string vouchExtDescOne { get; set; } = null!;

    [StringLength(26)]
    public string vouchExtNumberOne { get; set; } = null!;

    public byte Index { get; set; }
}
