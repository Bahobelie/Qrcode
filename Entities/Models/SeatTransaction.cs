using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("SeatTransaction", Schema = "cinema")]
[Index("movieschedule", "seatarrangement", "voudef", Name = "UC_CinemaSeat", IsUnique = true)]
public partial class SeatTransaction
{
    public string id { get; set; } = null!;

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string lineitem { get; set; } = null!;

    [StringLength(26)]
    public string movieschedule { get; set; } = null!;

    [StringLength(26)]
    public string seatarrangement { get; set; } = null!;

    [StringLength(26)]
    public string voudef { get; set; } = null!;

    public string? remark { get; set; }
}
