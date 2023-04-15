using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("BeginningTransaction", Schema = "common")]
public partial class BeginningTransaction
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string Account { get; set; } = null!;

    public string Description { get; set; } = null!;

    [StringLength(26)]
    public string? Reference { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Date { get; set; }

    [StringLength(26)]
    public string Period { get; set; } = null!;

    public int Type { get; set; }

    [Column(TypeName = "money")]
    public decimal Amount { get; set; }

    public int Reconciled { get; set; }

    [StringLength(26)]
    public string reconciliationPeriod { get; set; } = null!;

    [StringLength(100)]
    public string? Remark { get; set; }
}
