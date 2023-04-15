using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("LineItemSeatAndState", Schema = "pos")]
public partial class LineItemSeatAndState
{
    [Key]
    public int id { get; set; }

    [StringLength(26)]
    public string lineitem { get; set; } = null!;

    public int state { get; set; }

    public int? seat { get; set; }

    [StringLength(26)]
    public string? remark { get; set; }

    [ForeignKey("lineitem")]
    [InverseProperty("LineItemSeatAndStates")]
    public virtual LineItem lineitemNavigation { get; set; } = null!;
}
