using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class Message_View
{
    [StringLength(26)]
    public string messageCode { get; set; } = null!;

    [StringLength(26)]
    public string? regNumber { get; set; }

    public string message { get; set; } = null!;

    [StringLength(26)]
    public string? guestCode { get; set; }

    [StringLength(26)]
    public string? destPersonCode { get; set; }

    [StringLength(26)]
    public string typeCode { get; set; } = null!;

    [StringLength(26)]
    public string? senderCode { get; set; }

    [StringLength(30)]
    public string senderName { get; set; } = null!;

    public string destinationName { get; set; } = null!;

    [StringLength(26)]
    public string? destUserCode { get; set; }

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    public bool IsVoid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    public string senderDevice { get; set; } = null!;
}
