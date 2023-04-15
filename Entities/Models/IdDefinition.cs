using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("IdDefinition", Schema = "common")]
[Index("code", Name = "IX_IdDefinition", IsUnique = true)]
public partial class IdDefinition
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string component { get; set; } = null!;

    [StringLength(100)]
    public string? description { get; set; }

    [StringLength(8)]
    public string? prefix { get; set; }

    [StringLength(1)]
    public string? prefixSeparator { get; set; }

    public int length { get; set; }

    [StringLength(1)]
    public string? suffixSeparator { get; set; }

    [StringLength(4)]
    public string? suffix { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("idDefinitionNavigation")]
    public virtual ICollection<IdSetting> IdSettings { get; } = new List<IdSetting>();
}
