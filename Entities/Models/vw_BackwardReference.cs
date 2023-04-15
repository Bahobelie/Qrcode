using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_BackwardReference
{
    [StringLength(26)]
    public string voucherCode { get; set; } = null!;

    public string? backwardReferences { get; set; }
}
