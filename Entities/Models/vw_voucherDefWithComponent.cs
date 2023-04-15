using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_voucherDefWithComponent
{
    public Guid Id { get; set; }

    public int code { get; set; }

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(100)]
    public string? systemName { get; set; }

    [StringLength(100)]
    public string? name { get; set; }

    [StringLength(15)]
    public string? abbriviation { get; set; }

    [StringLength(30)]
    public string? ISODocumentNumber { get; set; }

    public bool IsActive { get; set; }

    [StringLength(15)]
    public string? journalType { get; set; }

    public bool? IsLineItem { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [StringLength(50)]
    public string ComponenetName { get; set; } = null!;
}
