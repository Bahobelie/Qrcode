using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class IdSettingAuditView
{
    [StringLength(100)]
    public string? name { get; set; }

    public bool IsActive { get; set; }

    [StringLength(15)]
    public string? journalType { get; set; }

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(26)]
    public string idDefinition { get; set; } = null!;

    public int startFrom { get; set; }

    public bool isFlexible { get; set; }

    [StringLength(26)]
    public string? device { get; set; }

    [StringLength(26)]
    public string? organizationUnit { get; set; }

    public int currentValue { get; set; }

    [StringLength(26)]
    public string component { get; set; } = null!;

    [StringLength(100)]
    public string? description { get; set; }

    [StringLength(8)]
    public string? prefix { get; set; }

    [StringLength(1)]
    public string? prefixSeparator { get; set; }

    public int length { get; set; }

    [StringLength(1)]
    public string? suffixSeparator { get; set; }

    [StringLength(4)]
    public string? suffix { get; set; }
}
