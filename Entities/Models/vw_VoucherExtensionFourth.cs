using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_VoucherExtensionFourth
{
    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(26)]
    public string vouchExtFourth { get; set; } = null!;

    [StringLength(50)]
    public string vouchExtDescFourth { get; set; } = null!;

    [StringLength(26)]
    public string vouchExtNumberFourth { get; set; } = null!;

    public byte Index { get; set; }
}
