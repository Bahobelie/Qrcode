using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Identification", Schema = "common")]
[Index("code", Name = "IX_Identification", IsUnique = true)]
public partial class Identification
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(50)]
    public string? description { get; set; }

    public string idNumber { get; set; } = null!;

    [StringLength(26)]
    public string type { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? issueDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? expiryDate { get; set; }

    [StringLength(25)]
    public string? issuer { get; set; }

    public int index { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("reference2")]
    public virtual ICollection<Attachment> Attachments { get; } = new List<Attachment>();

    [ForeignKey("reference")]
    [InverseProperty("Identifications")]
    public virtual Device reference1 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("Identifications")]
    public virtual Organization reference2 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("Identifications")]
    public virtual Person reference3 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("Identifications")]
    public virtual Article referenceNavigation { get; set; } = null!;

    [ForeignKey("type")]
    [InverseProperty("Identifications")]
    public virtual Lookup typeNavigation { get; set; } = null!;
}
