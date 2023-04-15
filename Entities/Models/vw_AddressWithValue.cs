using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_AddressWithValue
{
    [StringLength(26)]
    public string prefCode { get; set; } = null!;

    [StringLength(26)]
    public string component { get; set; } = null!;

    [StringLength(100)]
    public string description { get; set; } = null!;

    [StringLength(26)]
    public string? parent { get; set; }

    [StringLength(26)]
    public string? AddCode { get; set; }

    [StringLength(26)]
    public string? reference { get; set; }

    [StringLength(26)]
    public string? preference { get; set; }

    public string? value { get; set; }

    public int? gslType { get; set; }

    public byte index { get; set; }

    [StringLength(100)]
    public string parentDesc { get; set; } = null!;
}
