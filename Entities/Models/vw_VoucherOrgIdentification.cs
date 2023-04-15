using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_VoucherOrgIdentification
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string consignee { get; set; } = null!;

    [StringLength(50)]
    public string tradeName { get; set; } = null!;

    [StringLength(50)]
    public string? description { get; set; }

    [StringLength(20)]
    public string idNumber { get; set; } = null!;
}
