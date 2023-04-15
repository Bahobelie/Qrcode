using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Tax", Schema = "common")]
public partial class Tax
{
    public Guid id { get; set; }

    [Key]
    public int code { get; set; }

    [StringLength(26)]
    public string category { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal amount { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("taxNavigation")]
    public virtual ICollection<GSLTax> GSLTaxes { get; } = new List<GSLTax>();

    [InverseProperty("taxNavigation")]
    public virtual ICollection<LineItem> LineItems { get; } = new List<LineItem>();

    [InverseProperty("taxTypeNavigation")]
    public virtual ICollection<TaxTransaction> TaxTransactions { get; } = new List<TaxTransaction>();

    [ForeignKey("category")]
    [InverseProperty("Taxes")]
    public virtual Lookup categoryNavigation { get; set; } = null!;
}
