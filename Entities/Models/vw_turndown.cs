using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_turndown
{
    [StringLength(26)]
    public string trnDnCode { get; set; } = null!;

    [StringLength(26)]
    public string? roomDetail { get; set; }

    [StringLength(50)]
    public string? roomNo { get; set; }

    [StringLength(50)]
    public string RoomType { get; set; } = null!;

    [StringLength(50)]
    public string rmstatus { get; set; } = null!;

    [StringLength(26)]
    public string? employee { get; set; }

    [StringLength(26)]
    public string? color { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? trnDnTime { get; set; }

    [StringLength(26)]
    public string assignmentCode { get; set; } = null!;
}
