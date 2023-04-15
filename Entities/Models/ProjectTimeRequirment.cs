using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("ProjectTimeRequirment", Schema = "Internal")]
public partial class ProjectTimeRequirment
{
    public Guid ID { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int sequence { get; set; }

    [StringLength(26)]
    public string voucherReference { get; set; } = null!;

    public int days { get; set; }

    [StringLength(50)]
    public string owner { get; set; } = null!;

    [StringLength(200)]
    public string note { get; set; } = null!;

    [StringLength(50)]
    public string? remark { get; set; }

    public bool active { get; set; }
}
