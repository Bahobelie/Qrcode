using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("TurnDown", Schema = "PMS")]
public partial class TurnDown
{
    public Guid? id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? roomDetail { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? timestamp { get; set; }

    public bool? value { get; set; }

    [StringLength(26)]
    public string? remark { get; set; }

    [ForeignKey("roomDetail")]
    [InverseProperty("TurnDowns")]
    public virtual RoomDetail? roomDetailNavigation { get; set; }
}
