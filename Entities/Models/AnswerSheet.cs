using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("AnswerSheet", Schema = "common")]
public partial class AnswerSheet
{
    [StringLength(10)]
    public string? id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int? index { get; set; }

    [StringLength(26)]
    public string? Voucher { get; set; }

    [StringLength(26)]
    public string? evaluationSheet { get; set; }

    [StringLength(50)]
    public string? answer { get; set; }

    [StringLength(50)]
    public string? pointObtained { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("Voucher")]
    [InverseProperty("AnswerSheets")]
    public virtual Voucher? VoucherNavigation { get; set; }

    [ForeignKey("evaluationSheet")]
    [InverseProperty("AnswerSheets")]
    public virtual EvaluationSheet? evaluationSheetNavigation { get; set; }
}
