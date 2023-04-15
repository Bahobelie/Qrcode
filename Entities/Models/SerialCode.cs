using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("SerialCode", Schema = "common")]
[Index("code", Name = "IX_SerialCode", IsUnique = true)]
public partial class SerialCode
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string lineItem { get; set; } = null!;

    [StringLength(26)]
    public string serialDefinition { get; set; } = null!;

    public string number { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("serialDefinition")]
    [InverseProperty("SerialCodes")]
    public virtual SerialDefinition serialDefinitionNavigation { get; set; } = null!;
}
