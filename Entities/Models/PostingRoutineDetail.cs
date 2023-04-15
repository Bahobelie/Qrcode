using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("PostingRoutineDetail", Schema = "common")]
public partial class PostingRoutineDetail
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string postingRoutineHeader { get; set; } = null!;

    public int index { get; set; }

    public int voucherDef { get; set; }

    public bool isMandatory { get; set; }

    [StringLength(500)]
    public string? remark { get; set; }

    [ForeignKey("postingRoutineHeader")]
    [InverseProperty("PostingRoutineDetails")]
    public virtual PostingRoutineHeader postingRoutineHeaderNavigation { get; set; } = null!;

    [ForeignKey("voucherDef")]
    [InverseProperty("PostingRoutineDetails")]
    public virtual VoucherDefinition voucherDefNavigation { get; set; } = null!;
}
