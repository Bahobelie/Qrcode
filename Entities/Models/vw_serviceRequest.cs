using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_serviceRequest
{
    public Guid? Id { get; set; }

    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? consignee { get; set; }

    [StringLength(62)]
    public string? assignedPerson { get; set; }

    [StringLength(26)]
    public string? servLukCode { get; set; }

    [StringLength(2048)]
    public string? note { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    [Column(TypeName = "money")]
    public decimal? value { get; set; }

    public string? servLukDesc { get; set; }

    [StringLength(26)]
    public string? regNum { get; set; }

    [StringLength(50)]
    public string? room { get; set; }

    [StringLength(50)]
    public string? roomType { get; set; }

    [StringLength(26)]
    public string? regState { get; set; }

    public string? guestName { get; set; }

    [StringLength(30)]
    public string? userName { get; set; }

    public string? DeviceName { get; set; }

    public string? actDefDesc { get; set; }

    [StringLength(26)]
    public string actDefLuk { get; set; } = null!;
}
