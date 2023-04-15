using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("RelationDetail", Schema = "common")]
public partial class RelationDetail
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? relation { get; set; }

    public int? voucherDefn { get; set; }

    [Column("operator")]
    public int? _operator { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("relation")]
    [InverseProperty("RelationDetails")]
    public virtual Relation? relationNavigation { get; set; }

    [ForeignKey("voucherDefn")]
    [InverseProperty("RelationDetails")]
    public virtual VoucherDefinition? voucherDefnNavigation { get; set; }
}
