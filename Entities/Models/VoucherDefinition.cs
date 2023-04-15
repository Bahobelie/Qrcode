using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("VoucherDefinition", Schema = "common")]
public partial class VoucherDefinition
{
    public Guid Id { get; set; }

    [Key]
    public int code { get; set; }

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(100)]
    public string? systemName { get; set; }

    [StringLength(100)]
    public string? name { get; set; }

    [StringLength(15)]
    public string? abbriviation { get; set; }

    [StringLength(30)]
    public string? ISODocumentNumber { get; set; }

    public bool IsActive { get; set; }

    [StringLength(15)]
    public string? journalType { get; set; }

    public bool? IsLineItem { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("referredVoucherDefnNavigation")]
    public virtual ICollection<ClosedRelation> ClosedRelationreferredVoucherDefnNavigations { get; } = new List<ClosedRelation>();

    [InverseProperty("referringVoucherDefnNavigation")]
    public virtual ICollection<ClosedRelation> ClosedRelationreferringVoucherDefnNavigations { get; } = new List<ClosedRelation>();

    [InverseProperty("referingVouDfnNavigation")]
    public virtual ICollection<LineItemReference> LineItemReferences { get; } = new List<LineItemReference>();

    [InverseProperty("voucherDefNavigation")]
    public virtual ICollection<PostingRoutineDetail> PostingRoutineDetails { get; } = new List<PostingRoutineDetail>();

    [InverseProperty("voucherDefnNavigation")]
    public virtual ICollection<PreferenceAccess> PreferenceAccesses { get; } = new List<PreferenceAccess>();

    [InverseProperty("voucherDefnitionNavigation")]
    public virtual ICollection<ReconciliationDetail> ReconciliationDetails { get; } = new List<ReconciliationDetail>();

    [InverseProperty("voucherDefnNavigation")]
    public virtual ICollection<RelationDetail> RelationDetails { get; } = new List<RelationDetail>();

    [InverseProperty("voucherDefnNavigation")]
    public virtual ICollection<RequriedGSL> RequriedGSLs { get; } = new List<RequriedGSL>();

    [InverseProperty("voucherDefnNavigation")]
    public virtual ICollection<TermList> TermLists { get; } = new List<TermList>();

    [InverseProperty("voucherDefinitionNavigation")]
    public virtual ValueFactorSetup? ValueFactorSetup { get; set; }

    [InverseProperty("voucherDefnNavigation")]
    public virtual ICollection<VoucherExtension> VoucherExtensions { get; } = new List<VoucherExtension>();

    [InverseProperty("voucherDefnNavigation")]
    public virtual ICollection<VoucherStoreMapping> VoucherStoreMappings { get; } = new List<VoucherStoreMapping>();

    [InverseProperty("voucherDefinitionNavigation")]
    public virtual ICollection<Voucher> Vouchers { get; } = new List<Voucher>();
}
