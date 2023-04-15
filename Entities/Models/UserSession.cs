using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("UserSession", Schema = "common")]
public partial class UserSession
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? startTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? endTimeStamp { get; set; }

    public bool isClosed { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }
}
