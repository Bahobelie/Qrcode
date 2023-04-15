using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class RateDetailRoomType_View
{
    [StringLength(26)]
    public string rateCodeHeader { get; set; } = null!;

    [StringLength(26)]
    public string rateCodeDetail { get; set; } = null!;

    [StringLength(26)]
    public string roomType { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime startDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime endDate { get; set; }
}
