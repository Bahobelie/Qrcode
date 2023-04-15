using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class Voucher
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public int? Type { get; set; }

    public int? Definition { get; set; }

    public int? OriginConsigneeUnit { get; set; }

    public int? DestinationConsigneeUnit { get; set; }

    public int? Period { get; set; }

    public int? Shift { get; set; }

    public int? Consignee1 { get; set; }

    public int? ConsigneeUnit1 { get; set; }

    public int? Consignee2 { get; set; }

    public int? ConsigneeUnit2 { get; set; }

    public int? Consignee3 { get; set; }

    public int? ConsigneeUnit3 { get; set; }

    public int? Consignee4 { get; set; }

    public int? ConsigneeUnit4 { get; set; }

    public int? Consignee5 { get; set; }

    public int? ConsigneeUnit5 { get; set; }

    public int? Consignee6 { get; set; }

    public int? ConsigneeUnit6 { get; set; }

    public DateTime IssuedDate { get; set; }

    public bool? IsIssued { get; set; }

    public bool? IsVoid { get; set; }

    public int? Date { get; set; }

    public int? Month { get; set; }

    public int? Year { get; set; }

    public decimal? SubTotal { get; set; }

    public decimal? Discount { get; set; }

    public decimal? AdditionalCharge { get; set; }

    public decimal? GrandTotal { get; set; }

    public int? PaymentMethod { get; set; }

    public int? Currency { get; set; }

    public int? ExchangeRate { get; set; }

    public string? Note { get; set; }

    public int? Purpose { get; set; }

    public string? FsNumber { get; set; }

    public string? Mrc { get; set; }

    public int? Cart { get; set; }

    public string? Extension1 { get; set; }

    public string? Extension2 { get; set; }

    public string? Extension3 { get; set; }

    public string? Extension4 { get; set; }

    public DateTime? Extension5 { get; set; }

    public DateTime? Extension6 { get; set; }

    public int? SourceStore { get; set; }

    public int? DestinationStore { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public bool? HasEffect { get; set; }

    public int? LastActivity { get; set; }

    public int? LastUser { get; set; }

    public int? LastDevice { get; set; }

    public int? LastState { get; set; }

    public byte[]? CreatedOn { get; set; }

    public DateTime? LastModified { get; set; }

    public decimal? Latitiude { get; set; }

    public decimal? Longitude { get; set; }

    public bool? Locked { get; set; }

    public string? DefaultImageUrl { get; set; }

    public string? Remark { get; set; }

    public virtual ICollection<AnswerSheet> AnswerSheets { get; } = new List<AnswerSheet>();

    public virtual ICollection<ClosedRelation> ClosedRelations { get; } = new List<ClosedRelation>();

    public virtual Consignee? Consignee1Navigation { get; set; }

    public virtual Consignee? Consignee2Navigation { get; set; }

    public virtual ConsigneeUnit? Consignee31 { get; set; }

    public virtual Consignee? Consignee3Navigation { get; set; }

    public virtual ConsigneeUnit? Consignee41 { get; set; }

    public virtual Consignee? Consignee4Navigation { get; set; }

    public virtual Consignee? Consignee5Navigation { get; set; }

    public virtual ConsigneeUnit? Consignee61 { get; set; }

    public virtual Consignee? Consignee6Navigation { get; set; }

    public virtual ConsigneeUnit? ConsigneeUnit1Navigation { get; set; }

    public virtual ConsigneeUnit? ConsigneeUnit2Navigation { get; set; }

    public virtual ConsigneeUnit? ConsigneeUnit5Navigation { get; set; }

    public virtual SystemConstant? DefinitionNavigation { get; set; }

    public virtual ConsigneeUnit? DestinationConsigneeUnitNavigation { get; set; }

    public virtual ConsigneeUnit? DestinationStoreNavigation { get; set; }

    public virtual ICollection<EvaluationSheet> EvaluationSheets { get; } = new List<EvaluationSheet>();

    public virtual ICollection<JournalDetail> JournalDetails { get; } = new List<JournalDetail>();

    public virtual Activity? LastActivityNavigation { get; set; }

    public virtual Device? LastDeviceNavigation { get; set; }

    public virtual ObjectStateDefinition? LastStateNavigation { get; set; }

    public virtual User? LastUserNavigation { get; set; }

    public virtual ICollection<LineItemReference> LineItemReferences { get; } = new List<LineItemReference>();

    public virtual ICollection<LineItem> LineItems { get; } = new List<LineItem>();

    public virtual ICollection<NonCashTransaction> NonCashTransactions { get; } = new List<NonCashTransaction>();

    public virtual ConsigneeUnit? OriginConsigneeUnitNavigation { get; set; }

    public virtual Period? PeriodNavigation { get; set; }

    public virtual ICollection<PreferentialValueFactor> PreferentialValueFactors { get; } = new List<PreferentialValueFactor>();

    public virtual Period? ShiftNavigation { get; set; }

    public virtual ConsigneeUnit? SourceStoreNavigation { get; set; }

    public virtual ICollection<TaxTransaction> TaxTransactions { get; } = new List<TaxTransaction>();

    public virtual ICollection<TransactionCurrency> TransactionCurrencies { get; } = new List<TransactionCurrency>();

    public virtual ICollection<TransactionReference> TransactionReferenceReferencedNavigations { get; } = new List<TransactionReference>();

    public virtual ICollection<TransactionReference> TransactionReferenceReferringNavigations { get; } = new List<TransactionReference>();

    public virtual SystemConstant? TypeNavigation { get; set; }

    public virtual ICollection<VoucherAccount> VoucherAccounts { get; } = new List<VoucherAccount>();

    public virtual ICollection<VoucherConsigneeList> VoucherConsigneeLists { get; } = new List<VoucherConsigneeList>();

    public virtual ICollection<VoucherLookupList> VoucherLookupLists { get; } = new List<VoucherLookupList>();

    public virtual ICollection<VoucherTerm> VoucherTerms { get; } = new List<VoucherTerm>();
}
