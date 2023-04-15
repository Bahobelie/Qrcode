using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class CardView
{
    [StringLength(26)]
    public string cardNo { get; set; } = null!;

    [StringLength(26)]
    public string cardType { get; set; } = null!;

    [StringLength(25)]
    public string? model { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? registrationDate { get; set; }

    [StringLength(26)]
    public string? status { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [StringLength(50)]
    public string? type { get; set; }

    [StringLength(50)]
    public string? cardmodel { get; set; }

    [StringLength(50)]
    public string? cardstatus { get; set; }
}
