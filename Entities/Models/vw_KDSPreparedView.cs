using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_KDSPreparedView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [StringLength(26)]
    public string article { get; set; } = null!;

    public string name { get; set; } = null!;

    [Column(TypeName = "decimal(18, 4)")]
    public decimal quantity { get; set; }

    [StringLength(26)]
    public string? UOM { get; set; }

    [StringLength(26)]
    public string posDevice { get; set; } = null!;

    [StringLength(26)]
    public string preference { get; set; } = null!;

    [StringLength(26)]
    public string stationDevice { get; set; } = null!;

    [StringLength(26)]
    public string? waiter { get; set; }

    [StringLength(26)]
    public string? table { get; set; }

    [StringLength(26)]
    public string? cover { get; set; }

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    [StringLength(26)]
    public string? lastActivity { get; set; }

    [StringLength(26)]
    public string? articleModfier { get; set; }

    [StringLength(50)]
    public string? description { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [StringLength(100)]
    public string? LineItemRemark { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? preparedTime { get; set; }
}
