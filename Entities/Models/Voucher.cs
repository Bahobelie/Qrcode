using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Voucher", Schema = "common")]
[Index("date", Name = "Date_Index")]
[Index("code", Name = "IX_Voucher", IsUnique = true)]
[Index("month", Name = "MonthIndex")]
[Index("voucherDefinition", Name = "Voucher_Definition_Index")]
[Index("year", Name = "Year_Index")]
public partial class Voucher
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string type { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string? component { get; set; }

    [StringLength(26)]
    public string? consignee { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    public bool IsIssued { get; set; }

    public int year { get; set; }

    public int month { get; set; }

    public int date { get; set; }

    public bool IsVoid { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    [StringLength(26)]
    public string? period { get; set; }

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    [StringLength(26)]
    public string? lastActivity { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("reference3")]
    public virtual ICollection<Activity> Activities { get; } = new List<Activity>();

    [InverseProperty("VoucherNavigation")]
    public virtual ICollection<AnswerSheet> AnswerSheets { get; } = new List<AnswerSheet>();

    [InverseProperty("referenceNavigation")]
    public virtual ICollection<CartTransaction> CartTransactions { get; } = new List<CartTransaction>();

    [InverseProperty("voucherNavigation")]
    public virtual ICollection<CaseDetail> CaseDetails { get; } = new List<CaseDetail>();

    [InverseProperty("voucherNavigation")]
    public virtual ICollection<ClosedRelation> ClosedRelations { get; } = new List<ClosedRelation>();

    [InverseProperty("reference2")]
    public virtual ICollection<Configuration> Configurations { get; } = new List<Configuration>();

    [InverseProperty("VoucherNavigation")]
    public virtual ICollection<CreditCardAuthorization> CreditCardAuthorizations { get; } = new List<CreditCardAuthorization>();

    [InverseProperty("transactionCurrencyrefNavigation")]
    public virtual ICollection<DenominationDetail> DenominationDetails { get; } = new List<DenominationDetail>();

    [InverseProperty("voucherNavigation")]
    public virtual ICollection<EscalationDetail> EscalationDetails { get; } = new List<EscalationDetail>();

    [InverseProperty("voucherNavigation")]
    public virtual ICollection<EvaluationSheet> EvaluationSheets { get; } = new List<EvaluationSheet>();

    [InverseProperty("voucherNavigation")]
    public virtual ICollection<EvenetRequiremenet> EvenetRequiremenets { get; } = new List<EvenetRequiremenet>();

    [InverseProperty("referenceNavigation")]
    public virtual ICollection<FieldFormat> FieldFormats { get; } = new List<FieldFormat>();

    [InverseProperty("voucherNavigation")]
    public virtual ICollection<JournalDetail> JournalDetails { get; } = new List<JournalDetail>();

    [ForeignKey("LastObjectState")]
    [InverseProperty("Vouchers")]
    public virtual ObjectStateDefinition? LastObjectStateNavigation { get; set; }

    [InverseProperty("voucherNavigation")]
    public virtual ICollection<LineItem> LineItems { get; } = new List<LineItem>();

    [InverseProperty("voucherNavigation")]
    public virtual ICollection<Mail> Mail { get; } = new List<Mail>();

    [InverseProperty("voucherNavigation")]
    public virtual ICollection<NonCashTransaction> NonCashTransactions { get; } = new List<NonCashTransaction>();

    [InverseProperty("reference3")]
    public virtual ICollection<ObjectState> ObjectStates { get; } = new List<ObjectState>();

    [InverseProperty("voucherNavigation")]
    public virtual ICollection<OtherConsignee> OtherConsignees { get; } = new List<OtherConsignee>();

    [InverseProperty("voucherNavigation")]
    public virtual ICollection<PreferenceValueFactor> PreferenceValueFactors { get; } = new List<PreferenceValueFactor>();

    [InverseProperty("voucherNavigation")]
    public virtual ICollection<RegistrationDetail> RegistrationDetails { get; } = new List<RegistrationDetail>();

    [InverseProperty("voucherNavigation")]
    public virtual ICollection<RegistrationExtension> RegistrationExtensions { get; } = new List<RegistrationExtension>();

    [InverseProperty("voucherNavigation")]
    public virtual ICollection<RegistrationPrivllege> RegistrationPrivlleges { get; } = new List<RegistrationPrivllege>();

    [InverseProperty("referenceObject3")]
    public virtual ICollection<Relation> Relations { get; } = new List<Relation>();

    [InverseProperty("voucherNavigation")]
    public virtual ICollection<RemovedItem> RemovedItems { get; } = new List<RemovedItem>();

    [InverseProperty("voucherNavigation")]
    public virtual ICollection<StoreTransaction> StoreTransactions { get; } = new List<StoreTransaction>();

    [InverseProperty("voucherNavigation")]
    public virtual ICollection<TaxTransaction> TaxTransactions { get; } = new List<TaxTransaction>();

    [InverseProperty("referenceNavigation")]
    public virtual ICollection<TimeSheet> TimeSheetreferenceNavigations { get; } = new List<TimeSheet>();

    [InverseProperty("voucherNavigation")]
    public virtual ICollection<TimeSheet> TimeSheetvoucherNavigations { get; } = new List<TimeSheet>();

    [InverseProperty("voucherNavigation")]
    public virtual ICollection<TransactionCurrency> TransactionCurrencies { get; } = new List<TransactionCurrency>();

    [InverseProperty("referencedNavigation")]
    public virtual ICollection<TransactionReference> TransactionReferencereferencedNavigations { get; } = new List<TransactionReference>();

    [InverseProperty("refereningNavigation")]
    public virtual ICollection<TransactionReference> TransactionReferencerefereningNavigations { get; } = new List<TransactionReference>();

    [InverseProperty("voucherNavigation")]
    public virtual ICollection<VoucherAccount> VoucherAccounts { get; } = new List<VoucherAccount>();

    [InverseProperty("voucherNavigation")]
    public virtual ICollection<VoucherExtensionTransaction> VoucherExtensionTransactions { get; } = new List<VoucherExtensionTransaction>();

    [InverseProperty("voucherNavigation")]
    public virtual ICollection<VoucherNote> VoucherNotes { get; } = new List<VoucherNote>();

    [InverseProperty("voucherNavigation")]
    public virtual ICollection<VoucherTerm> VoucherTerms { get; } = new List<VoucherTerm>();

    [InverseProperty("voucherNavigation")]
    public virtual ICollection<VoucherValue> VoucherValues { get; } = new List<VoucherValue>();

    [ForeignKey("consignee")]
    [InverseProperty("Vouchers")]
    public virtual Person? consignee1 { get; set; }

    [ForeignKey("consignee")]
    [InverseProperty("Vouchers")]
    public virtual Organization? consigneeNavigation { get; set; }

    [ForeignKey("period")]
    [InverseProperty("Vouchers")]
    public virtual Period? periodNavigation { get; set; }

    [ForeignKey("type")]
    [InverseProperty("Vouchers")]
    public virtual Lookup typeNavigation { get; set; } = null!;

    [ForeignKey("voucherDefinition")]
    [InverseProperty("Vouchers")]
    public virtual VoucherDefinition voucherDefinitionNavigation { get; set; } = null!;
}
