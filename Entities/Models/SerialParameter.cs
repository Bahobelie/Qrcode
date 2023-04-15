using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("SerialParameter", Schema = "common")]
[Index("code", Name = "IX_SerialParameter", IsUnique = true)]
public partial class SerialParameter
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string device { get; set; } = null!;

    [StringLength(26)]
    public string baudRate { get; set; } = null!;

    [StringLength(5)]
    public string serialPort { get; set; } = null!;

    [StringLength(26)]
    public string? parity { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("baudRate")]
    [InverseProperty("SerialParameterbaudRateNavigations")]
    public virtual Lookup baudRateNavigation { get; set; } = null!;

    [ForeignKey("device")]
    [InverseProperty("SerialParameters")]
    public virtual Device deviceNavigation { get; set; } = null!;

    [ForeignKey("parity")]
    [InverseProperty("SerialParameterparityNavigations")]
    public virtual Lookup? parityNavigation { get; set; }
}
