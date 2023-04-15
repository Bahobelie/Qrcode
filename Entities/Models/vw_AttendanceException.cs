using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_AttendanceException
{
    [StringLength(26)]
    public string voucherCode { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string? employee { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime date { get; set; }

    public bool IsIssued { get; set; }

    public bool IsVoid { get; set; }

    [StringLength(26)]
    public string? lastActivity { get; set; }

    [StringLength(26)]
    public string exceptionCode { get; set; } = null!;

    [StringLength(26)]
    public string exceptionType { get; set; } = null!;

    [StringLength(26)]
    public string session { get; set; } = null!;

    public string? remark { get; set; }
}
