using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("TermList", Schema = "common")]
[Index("code", Name = "IX_TermList", IsUnique = true)]
[Index("voucherDefn", Name = "Term_LIst_Vdef_Index")]
public partial class TermList
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int voucherDefn { get; set; }

    [StringLength(26)]
    public string category { get; set; } = null!;

    public string description { get; set; } = null!;

    public string? defaultValue { get; set; }

    public bool isMandatory { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("reference3")]
    public virtual ICollection<ValueFactor> ValueFactors { get; } = new List<ValueFactor>();

    [InverseProperty("termNavigation")]
    public virtual ICollection<VoucherTerm> VoucherTerms { get; } = new List<VoucherTerm>();

    [ForeignKey("category")]
    [InverseProperty("TermLists")]
    public virtual Lookup categoryNavigation { get; set; } = null!;

    [ForeignKey("voucherDefn")]
    [InverseProperty("TermLists")]
    public virtual VoucherDefinition voucherDefnNavigation { get; set; } = null!;
}
