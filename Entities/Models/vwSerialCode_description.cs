using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vwSerialCode_description
{
    public Guid Id { get; set; }

    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string lineItem { get; set; } = null!;

    [StringLength(20)]
    public string number { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [StringLength(26)]
    public string serialDefCode { get; set; } = null!;

    [StringLength(26)]
    public string lookupcode { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;
}
