using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("FiscalExtension", Schema = "pos")]
public partial class FiscalExtension
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(26)]
    public string fsNo { get; set; } = null!;

    [StringLength(26)]
    public string mrsNo { get; set; } = null!;

    public string? remark { get; set; }
}
