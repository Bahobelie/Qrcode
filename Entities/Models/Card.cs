using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Card", Schema = "common")]
[Index("code", Name = "IX_Card", IsUnique = true)]
public partial class Card
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

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

    [InverseProperty("cardNavigation")]
    public virtual ICollection<ACLog> ACLogs { get; } = new List<ACLog>();

    [InverseProperty("cardNavigation")]
    public virtual ICollection<IssuedCared> IssuedCareds { get; } = new List<IssuedCared>();
}
