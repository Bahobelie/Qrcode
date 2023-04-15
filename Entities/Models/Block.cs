using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Block", Schema = "PMS")]
public partial class Block
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string name { get; set; } = null!;

    [StringLength(26)]
    public string registrationHeader { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? cutOffDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? followUpDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? decisionDate { get; set; }

    public bool? isCatering { get; set; }

    public bool? isElastic { get; set; }

    public bool? supressRate { get; set; }

    [StringLength(26)]
    public string? printRate { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("registrationHeader")]
    [InverseProperty("Blocks")]
    public virtual RegistrationExtension registrationHeaderNavigation { get; set; } = null!;
}
