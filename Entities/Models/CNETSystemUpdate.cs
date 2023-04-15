using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("CNETSystemUpdate", Schema = "Internal")]
public partial class CNETSystemUpdate
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    public string? customer { get; set; }

    [StringLength(26)]
    public string tin { get; set; } = null!;

    [StringLength(26)]
    public string? organizationunit { get; set; }

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(50)]
    public string version { get; set; } = null!;

    [StringLength(50)]
    public string? user { get; set; }

    [StringLength(100)]
    public string devicename { get; set; } = null!;

    [StringLength(100)]
    public string? manufacturer { get; set; }

    [StringLength(100)]
    public string? os { get; set; }

    public string? mac { get; set; }

    [StringLength(100)]
    public string? processor { get; set; }

    [StringLength(100)]
    public string? memory { get; set; }

    [StringLength(100)]
    public string? storage { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime starttimestamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime endtimestamp { get; set; }

    [StringLength(100)]
    public string status { get; set; } = null!;

    public bool DB { get; set; }

    public bool service { get; set; }

    public bool backoffice { get; set; }

    public bool emc { get; set; }

    public bool pms { get; set; }

    public bool pos { get; set; }

    public string? note { get; set; }

    public string? remark { get; set; }
}
