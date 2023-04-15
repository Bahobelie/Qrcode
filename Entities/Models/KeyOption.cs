using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("KeyOption", Schema = "PMS")]
public partial class KeyOption
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string roomDetail { get; set; } = null!;

    [StringLength(26)]
    public string keyDefinition { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("keyDefinition")]
    [InverseProperty("KeyOptions")]
    public virtual KeyDefinition keyDefinitionNavigation { get; set; } = null!;

    [ForeignKey("roomDetail")]
    [InverseProperty("KeyOptions")]
    public virtual RoomDetail roomDetailNavigation { get; set; } = null!;
}
