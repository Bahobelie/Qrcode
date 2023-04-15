using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("LineItem", Schema = "common")]
[Index("voucher", Name = "_dta_index_LineItem_5_2038558596__K3")]
[Index("voucher", "article", Name = "_dta_index_LineItem_5_2038558596__K3_K4")]
[Index("voucher", "article", "code", Name = "_dta_index_LineItem_5_2038558596__K3_K4_K2_5_6_7_8_13")]
[Index("article", "voucher", Name = "_dta_index_LineItem_5_2038558596__K4_K3")]
public partial class LineItem
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(26)]
    public string article { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? unitAmt { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal quantity { get; set; }

    [StringLength(26)]
    public string? UOM { get; set; }

    [Column(TypeName = "money")]
    public decimal? totalAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal taxableAmount { get; set; }

    public int? tax { get; set; }

    [Column(TypeName = "money")]
    public decimal? taxAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? calculatedCost { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("lineItemNavigation")]
    public virtual ICollection<LineItemConversion> LineItemConversions { get; } = new List<LineItemConversion>();

    [InverseProperty("lineitemNavigation")]
    public virtual ICollection<LineItemExtension> LineItemExtensions { get; } = new List<LineItemExtension>();

    [InverseProperty("LineItemNavigation")]
    public virtual ICollection<LineItemModfier> LineItemModfiers { get; } = new List<LineItemModfier>();

    [InverseProperty("lineItemNavigation")]
    public virtual ICollection<LineItemNote> LineItemNotes { get; } = new List<LineItemNote>();

    [InverseProperty("lineItemNavigation")]
    public virtual ICollection<LineItemReference> LineItemReferencelineItemNavigations { get; } = new List<LineItemReference>();

    [InverseProperty("referencedNavigation")]
    public virtual ICollection<LineItemReference> LineItemReferencereferencedNavigations { get; } = new List<LineItemReference>();

    [InverseProperty("lineitemNavigation")]
    public virtual ICollection<LineItemSeatAndState> LineItemSeatAndStates { get; } = new List<LineItemSeatAndState>();

    [InverseProperty("lineItemNavigation")]
    public virtual ICollection<LineItemValueFactor> LineItemValueFactors { get; } = new List<LineItemValueFactor>();

    [InverseProperty("lineitemNavigation")]
    public virtual ICollection<LineitemWeight> LineitemWeights { get; } = new List<LineitemWeight>();

    [InverseProperty("referenceNavigation")]
    public virtual ICollection<Schedule> Schedules { get; } = new List<Schedule>();

    [ForeignKey("UOM")]
    [InverseProperty("LineItems")]
    public virtual Lookup? UOMNavigation { get; set; }

    [ForeignKey("article")]
    [InverseProperty("LineItems")]
    public virtual Article articleNavigation { get; set; } = null!;

    [ForeignKey("tax")]
    [InverseProperty("LineItems")]
    public virtual Tax? taxNavigation { get; set; }

    [ForeignKey("voucher")]
    [InverseProperty("LineItems")]
    public virtual Voucher voucherNavigation { get; set; } = null!;
}
