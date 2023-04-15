using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_EventDisplayView
{
    [StringLength(26)]
    public string EventDetailCode { get; set; } = null!;

    [StringLength(26)]
    public string? EventDetailType { get; set; }

    public string? EventDetailTypeDescription { get; set; }

    [StringLength(50)]
    public string? EventDetailDescription { get; set; }

    [StringLength(26)]
    public string? space { get; set; }

    [StringLength(200)]
    public string? HallDescription { get; set; }

    [StringLength(26)]
    public string? spaceArrangment { get; set; }

    public string? SpaceArrangementDes { get; set; }

    public int? noOfPerson { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? startTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? endTimeStamp { get; set; }

    [StringLength(26)]
    public string code { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string VoucherType { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    [StringLength(26)]
    public string? period { get; set; }

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    public string? name { get; set; }

    [StringLength(26)]
    public string? consignee { get; set; }

    public bool IsIssued { get; set; }

    public bool IsVoid { get; set; }

    public string? EventDescription { get; set; }

    [StringLength(200)]
    public string? floor { get; set; }
}
