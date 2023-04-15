using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_discrepancy
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(50)]
    public string? roomNo { get; set; }

    [StringLength(50)]
    public string RoomType { get; set; } = null!;

    [StringLength(50)]
    public string rmstatus { get; set; } = null!;

    [StringLength(50)]
    public string hkval { get; set; } = null!;

    public int? foperson { get; set; }

    [StringLength(26)]
    public string? hkperson { get; set; }

    [StringLength(50)]
    public string discType { get; set; } = null!;

    [StringLength(26)]
    public string? roomDetail { get; set; }

    [StringLength(26)]
    public string? foStatus { get; set; }

    [StringLength(26)]
    public string Expr1 { get; set; } = null!;

    [Column(TypeName = "date")]
    public DateTime? Date { get; set; }
}
