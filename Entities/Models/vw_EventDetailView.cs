using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_EventDetailView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? OrganizationUnitDefinition { get; set; }

    [StringLength(26)]
    public string? voucher { get; set; }

    [StringLength(26)]
    public string? type { get; set; }

    [StringLength(50)]
    public string? description { get; set; }

    [StringLength(26)]
    public string? space { get; set; }

    [StringLength(26)]
    public string? spaceArrangment { get; set; }

    public int? noOfPerson { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? startTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? endTime { get; set; }

    [StringLength(1000)]
    public string? remark { get; set; }

    public string typeDesc { get; set; } = null!;

    public string spaceArrangeDesc { get; set; } = null!;

    [StringLength(200)]
    public string spaceDesc { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime? startDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? EndDate { get; set; }

    [StringLength(200)]
    public string floor { get; set; } = null!;
}
