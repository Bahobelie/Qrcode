using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_singleVoucherNote
{
    [StringLength(26)]
    public string voucher { get; set; } = null!;

    public string note { get; set; } = null!;

    public long? r { get; set; }
}
