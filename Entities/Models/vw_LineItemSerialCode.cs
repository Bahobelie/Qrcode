using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_LineItemSerialCode
{
    [StringLength(26)]
    public string Defination { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [StringLength(26)]
    public string serialCode { get; set; } = null!;

    [StringLength(26)]
    public string lineItem { get; set; } = null!;

    [StringLength(20)]
    public string number { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? prodDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? expiryDate { get; set; }
}
