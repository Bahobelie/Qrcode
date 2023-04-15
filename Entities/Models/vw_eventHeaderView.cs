using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_eventHeaderView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [StringLength(26)]
    public string? OrganizationUnitDefinition { get; set; }

    public bool IsIssued { get; set; }

    public bool IsVoid { get; set; }

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? startDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? endDate { get; set; }

    [StringLength(26)]
    public string? bookingType { get; set; }

    [StringLength(26)]
    public string? eventCateg { get; set; }

    public string eventDesc { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [StringLength(50)]
    public string osdDesc { get; set; } = null!;

    [StringLength(26)]
    public string? color { get; set; }

    public string bookingTypeDesc { get; set; } = null!;

    public string eventCategDesc { get; set; } = null!;

    public string? consigneeName { get; set; }

    public int? gslType { get; set; }

    [StringLength(26)]
    public string? consignee { get; set; }
}
