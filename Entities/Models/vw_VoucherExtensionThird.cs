using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_VoucherExtensionThird
{
    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(26)]
    public string vouchExtThird { get; set; } = null!;

    [StringLength(50)]
    public string vouchExtDescThird { get; set; } = null!;

    [StringLength(26)]
    public string vouchExtNumberThird { get; set; } = null!;

    public byte Index { get; set; }
}
