using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Discrepancy", Schema = "PMS")]
public partial class Discrepancy
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? roomDetail { get; set; }

    [StringLength(26)]
    public string? discrepancyType { get; set; }

    [StringLength(26)]
    public string? description { get; set; }

    [StringLength(26)]
    public string? FOValue { get; set; }

    [StringLength(26)]
    public string? hkValue { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("roomDetail")]
    [InverseProperty("Discrepancies")]
    public virtual RoomDetail? roomDetailNavigation { get; set; }
}
