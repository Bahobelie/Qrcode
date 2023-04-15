using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_SerialCodeLifeSpan
{
    [StringLength(26)]
    public string lineItem { get; set; } = null!;

    [Column("Serial Definition")]
    [StringLength(50)]
    public string Serial_Definition { get; set; } = null!;

    [Column("Serial Number")]
    [StringLength(20)]
    public string Serial_Number { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime prodDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime expiryDate { get; set; }
}
