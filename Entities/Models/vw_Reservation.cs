using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_Reservation
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string? consignee { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    public bool IsIssued { get; set; }

    public bool IsVoid { get; set; }

    [StringLength(50)]
    public string? description { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? startTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? endTimeStamp { get; set; }

    [StringLength(26)]
    public string eventdetailcode { get; set; } = null!;

    [StringLength(26)]
    public string? otherconcode { get; set; }

    [StringLength(26)]
    public string? otherconsigneecode { get; set; }

    [StringLength(26)]
    public string? space { get; set; }

    [StringLength(200)]
    public string Hall { get; set; } = null!;

    [StringLength(26)]
    public string? spacetype { get; set; }

    [StringLength(26)]
    public string? type { get; set; }

    [StringLength(26)]
    public string? spaceArrangment { get; set; }

    public int? noOfPerson { get; set; }

    [StringLength(1000)]
    public string? remark { get; set; }

    [StringLength(26)]
    public string? referening { get; set; }
}
