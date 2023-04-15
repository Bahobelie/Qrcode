using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("EvaluationSheet", Schema = "common")]
public partial class EvaluationSheet
{
    public Guid? id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? voucher { get; set; }

    public int? index { get; set; }

    [StringLength(50)]
    public string? question { get; set; }

    [StringLength(50)]
    public string? point { get; set; }

    [StringLength(50)]
    public string? timeRequired { get; set; }

    [StringLength(50)]
    public string? isBonus { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("evaluationSheetNavigation")]
    public virtual ICollection<AnswerSheet> AnswerSheets { get; } = new List<AnswerSheet>();

    [ForeignKey("voucher")]
    [InverseProperty("EvaluationSheets")]
    public virtual Voucher? voucherNavigation { get; set; }
}
