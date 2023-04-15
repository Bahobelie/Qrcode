using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Attachment", Schema = "common")]
[Index("code", Name = "IX_Attachment", IsUnique = true)]
public partial class Attachment
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    /// <summary>
    /// Can Be:Article (common),Attachment (common),Device (common),Organization (common),Person (common),Preference (common)
    /// </summary>
    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(26)]
    public string catagory { get; set; } = null!;

    [StringLength(100)]
    public string? description { get; set; }

    [StringLength(256)]
    public string url { get; set; } = null!;

    public byte[]? file { get; set; }

    [StringLength(26)]
    public string type { get; set; } = null!;

    public byte? index { get; set; }

    [StringLength(4000)]
    public string? remark { get; set; }

    [ForeignKey("reference")]
    [InverseProperty("Attachments")]
    public virtual Device reference1 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("Attachments")]
    public virtual Identification reference2 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("Attachments")]
    public virtual Organization reference3 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("Attachments")]
    public virtual Person reference4 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("Attachments")]
    public virtual Preference reference5 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("Attachments")]
    public virtual Article referenceNavigation { get; set; } = null!;
}
