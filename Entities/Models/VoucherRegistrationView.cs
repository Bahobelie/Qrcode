using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class VoucherRegistrationView
{
    [StringLength(26)]
    public string? room { get; set; }

    [Column(TypeName = "date")]
    public DateTime? Date { get; set; }

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(26)]
    public string? LastObjectState { get; set; }
}
