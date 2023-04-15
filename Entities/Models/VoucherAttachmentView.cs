using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class VoucherAttachmentView
{
    [StringLength(26)]
    public string voucherCode { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string attachment { get; set; } = null!;

    [StringLength(26)]
    public string catagory { get; set; } = null!;

    [StringLength(26)]
    public string type { get; set; } = null!;
}
