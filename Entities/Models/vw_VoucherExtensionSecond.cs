using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_VoucherExtensionSecond
{
    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(26)]
    public string vouchExtSecond { get; set; } = null!;

    [StringLength(50)]
    public string vouchExtDescSecond { get; set; } = null!;

    [StringLength(26)]
    public string vouchExtNumberSecond { get; set; } = null!;

    public byte Index { get; set; }
}
