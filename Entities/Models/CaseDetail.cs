using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("CaseDetail", Schema = "Internal")]
public partial class CaseDetail
{
    [Key]
    public Guid id { get; set; }

    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(26)]
    public string module { get; set; } = null!;

    [StringLength(26)]
    public string issue { get; set; } = null!;

    [StringLength(26)]
    public string cause { get; set; } = null!;

    [StringLength(26)]
    public string solution { get; set; } = null!;

    [StringLength(26)]
    public string result { get; set; } = null!;

    public string recommendation { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("cause")]
    [InverseProperty("CaseDetailcauseNavigations")]
    public virtual Lookup causeNavigation { get; set; } = null!;

    [ForeignKey("issue")]
    [InverseProperty("CaseDetailissueNavigations")]
    public virtual Lookup issueNavigation { get; set; } = null!;

    [ForeignKey("module")]
    [InverseProperty("CaseDetails")]
    public virtual CNETComponent moduleNavigation { get; set; } = null!;

    [ForeignKey("result")]
    [InverseProperty("CaseDetailresultNavigations")]
    public virtual Lookup resultNavigation { get; set; } = null!;

    [ForeignKey("solution")]
    [InverseProperty("CaseDetailsolutionNavigations")]
    public virtual Lookup solutionNavigation { get; set; } = null!;

    [ForeignKey("voucher")]
    [InverseProperty("CaseDetails")]
    public virtual Voucher voucherNavigation { get; set; } = null!;
}
