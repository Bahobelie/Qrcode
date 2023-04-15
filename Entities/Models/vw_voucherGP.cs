using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_voucherGP
{
    [StringLength(26)]
    public string voucher { get; set; } = null!;

    public double? latitude { get; set; }

    public double? longitude { get; set; }

    public long? r { get; set; }
}
