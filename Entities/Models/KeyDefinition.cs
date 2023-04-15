using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("KeyDefinition", Schema = "PMS")]
public partial class KeyDefinition
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string space { get; set; } = null!;

    [StringLength(26)]
    public string? keyCode { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("keyDefinitionNavigation")]
    public virtual ICollection<KeyOption> KeyOptions { get; } = new List<KeyOption>();

    [ForeignKey("space")]
    [InverseProperty("KeyDefinitions")]
    public virtual Space spaceNavigation { get; set; } = null!;
}
