using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("ACLog", Schema = "AccessControl")]
public partial class ACLog
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string card { get; set; } = null!;

    [StringLength(26)]
    public string acDevice { get; set; } = null!;

    [StringLength(50)]
    public string reader { get; set; } = null!;

    public string? description { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime timeStamp { get; set; }

    public int year { get; set; }

    public int month { get; set; }

    public int date { get; set; }

    public bool isEntry { get; set; }

    public bool? isClosed { get; set; }

    public bool isGranted { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("acDevice")]
    [InverseProperty("ACLogs")]
    public virtual Device acDeviceNavigation { get; set; } = null!;

    [ForeignKey("card")]
    [InverseProperty("ACLogs")]
    public virtual Card cardNavigation { get; set; } = null!;
}
