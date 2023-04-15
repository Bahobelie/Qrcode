using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Beginning", Schema = "common")]
[Index("code", Name = "IX_Beginning", IsUnique = true)]
[Index("reference", Name = "_dta_index_Beginning_5_1574661053__K3_5")]
public partial class Beginning
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    /// <summary>
    /// Can Be:Article (common),Device (common),Organization (common),Person (common)
    /// </summary>
    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(26)]
    public string period { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal value { get; set; }

    [StringLength(50)]
    public string? type { get; set; }

    public bool isProvisional { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("period")]
    [InverseProperty("Beginnings")]
    public virtual Period periodNavigation { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("Beginnings")]
    public virtual Organization reference1 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("Beginnings")]
    public virtual Person reference2 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("Beginnings")]
    public virtual Article referenceNavigation { get; set; } = null!;
}
