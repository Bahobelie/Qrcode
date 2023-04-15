using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class GetSerialDefAndCodeDetail_View
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(20)]
    public string number { get; set; } = null!;

    [StringLength(26)]
    public string definationCode { get; set; } = null!;

    [StringLength(50)]
    public string lookupCode { get; set; } = null!;

    [StringLength(50)]
    public string? description { get; set; }

    public bool isMandantory { get; set; }

    [StringLength(26)]
    public string article { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? expiryDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? prodDate { get; set; }
}
