using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("CommunicationSource", Schema = "common")]
[Index("code", Name = "IX_CommunicationSource", IsUnique = true)]
public partial class CommunicationSource
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    /// <summary>
    /// Ca Be:Article (common),Device (common),Organization (common),Person (common)
    /// </summary>
    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(26)]
    public string component { get; set; } = null!;

    [StringLength(26)]
    public string communicateBy { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("reference")]
    [InverseProperty("CommunicationSources")]
    public virtual Device reference1 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("CommunicationSources")]
    public virtual Organization reference2 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("CommunicationSources")]
    public virtual Person reference3 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("CommunicationSources")]
    public virtual Article referenceNavigation { get; set; } = null!;
}
