using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class VoucherDetail_View
{
    [StringLength(13)]
    [Unicode(false)]
    public string DGroup { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(50)]
    public string DKey { get; set; } = null!;

    [StringLength(82)]
    public string? DValue { get; set; }
}
