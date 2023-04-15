using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class DocumentAuditView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string? consignee { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [StringLength(26)]
    public string periodCode { get; set; } = null!;

    public bool IsVoid { get; set; }

    [StringLength(100)]
    public string? name { get; set; }

    [StringLength(15)]
    public string journalType { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(26)]
    public string organizationUnitDefinition { get; set; } = null!;

    [StringLength(50)]
    public string organizationUnitName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime start { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime end { get; set; }

    [StringLength(26)]
    public string jvCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? jvIssueDate { get; set; }

    [StringLength(26)]
    public string jvPeriod { get; set; } = null!;

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(26)]
    public string type { get; set; } = null!;
}
