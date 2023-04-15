using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("SerialDefinition", Schema = "common")]
[Index("code", Name = "IX_SerialDefinition", IsUnique = true)]
public partial class SerialDefinition
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string article { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    public bool isMandantory { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("serialDefinitionNavigation")]
    public virtual ICollection<SerialCode> SerialCodes { get; } = new List<SerialCode>();

    [ForeignKey("article")]
    [InverseProperty("SerialDefinitions")]
    public virtual Article articleNavigation { get; set; } = null!;
}
