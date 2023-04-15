using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class voucherActivity_View
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string voucherDefinition { get; set; } = null!;

    [StringLength(26)]
    public string consignee { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime issuedDate { get; set; }

    [StringLength(26)]
    public string? device { get; set; }

    [StringLength(26)]
    public string? user { get; set; }
}
