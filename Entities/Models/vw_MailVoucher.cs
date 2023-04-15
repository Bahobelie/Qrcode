using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_MailVoucher
{
    [StringLength(26)]
    public string voucher { get; set; } = null!;

    public string to { get; set; } = null!;

    public string? Sender { get; set; }

    public string? Cc { get; set; }

    public string? bcc { get; set; }

    [StringLength(100)]
    public string? subject { get; set; }

    [StringLength(2048)]
    public string note { get; set; } = null!;

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [StringLength(100)]
    public string? description { get; set; }

    [StringLength(26)]
    public string? hasAttachment { get; set; }

    [StringLength(26)]
    public string? consignee { get; set; }

    public string? name { get; set; }
}
