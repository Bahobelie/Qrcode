using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class SystemConstant
{
    public int Id { get; set; }

    public int Code { get; set; }

    public string? Type { get; set; }

    public int? Index { get; set; }

    public string? Description { get; set; }

    public string? Category { get; set; }

    public string? Value { get; set; }

    public int? ParenId { get; set; }

    public bool? IsDefault { get; set; }

    public bool? IsActive { get; set; }

    public string? Remark { get; set; }

    public virtual ICollection<AccessMatrix> AccessMatrices { get; } = new List<AccessMatrix>();

    public virtual ICollection<ActivityDefinition> ActivityDefinitions { get; } = new List<ActivityDefinition>();

    public virtual ICollection<Article> Articles { get; } = new List<Article>();

    public virtual ICollection<BankAccountDetail> BankAccountDetails { get; } = new List<BankAccountDetail>();

    public virtual ICollection<Card> CardCardTypeNavigations { get; } = new List<Card>();

    public virtual ICollection<Card> CardModelNavigations { get; } = new List<Card>();

    public virtual ICollection<ClosedRelation> ClosedRelationReferredVouherDefnNavigations { get; } = new List<ClosedRelation>();

    public virtual ICollection<ClosedRelation> ClosedRelationReferringVoucherDefnNavigations { get; } = new List<ClosedRelation>();

    public virtual ICollection<CloudSync> CloudSyncs { get; } = new List<CloudSync>();

    public virtual ICollection<Cnetlicense> Cnetlicenses { get; } = new List<Cnetlicense>();

    public virtual ICollection<Cnetmedium> CnetmediumCategoryNavigations { get; } = new List<Cnetmedium>();

    public virtual ICollection<Cnetmedium> CnetmediumTypeNavigations { get; } = new List<Cnetmedium>();

    public virtual ICollection<Consignee> ConsigneeBusinessTypeNavigations { get; } = new List<Consignee>();

    public virtual ICollection<Consignee> ConsigneeGenderNavigations { get; } = new List<Consignee>();

    public virtual ICollection<Consignee> ConsigneeGslTypeNavigations { get; } = new List<Consignee>();

    public virtual ICollection<Consignee> ConsigneeMaritalStatusNavigations { get; } = new List<Consignee>();

    public virtual ICollection<Consignee> ConsigneeTitleNavigations { get; } = new List<Consignee>();

    public virtual ICollection<ConsigneeUnit> ConsigneeUnitIndustryInvolvedNavigations { get; } = new List<ConsigneeUnit>();

    public virtual ICollection<ConsigneeUnit> ConsigneeUnitTypeNavigations { get; } = new List<ConsigneeUnit>();

    public virtual ICollection<ConsigneeUser> ConsigneeUsers { get; } = new List<ConsigneeUser>();

    public virtual ICollection<Device> Devices { get; } = new List<Device>();

    public virtual ICollection<DiscountFactor> DiscountFactors { get; } = new List<DiscountFactor>();

    public virtual ICollection<Distribution> DistributionPointerNavigations { get; } = new List<Distribution>();

    public virtual ICollection<Distribution> DistributionTypeNavigations { get; } = new List<Distribution>();

    public virtual ICollection<FieldFormat> FieldFormatPointerNavigations { get; } = new List<FieldFormat>();

    public virtual ICollection<FieldFormat> FieldFormatTargetPointerNavigations { get; } = new List<FieldFormat>();

    public virtual ICollection<FieldFormat> FieldFormatTypeNavigations { get; } = new List<FieldFormat>();

    public virtual ICollection<Functionality> FunctionalityCategoryNavigations { get; } = new List<Functionality>();

    public virtual ICollection<Functionality> FunctionalitySubSystemComponentNavigations { get; } = new List<Functionality>();

    public virtual ICollection<Functionality> FunctionalityVisualComponentNavigations { get; } = new List<Functionality>();

    public virtual ICollection<Iddefinition> Iddefinitions { get; } = new List<Iddefinition>();

    public virtual ICollection<Identification> Identifications { get; } = new List<Identification>();

    public virtual ICollection<Idsetting> Idsettings { get; } = new List<Idsetting>();

    public virtual ICollection<Language> Languages { get; } = new List<Language>();

    public virtual ICollection<LineItemConversion> LineItemConversions { get; } = new List<LineItemConversion>();

    public virtual ICollection<LineItemReference> LineItemReferences { get; } = new List<LineItemReference>();

    public virtual ICollection<LineItem> LineItems { get; } = new List<LineItem>();

    public virtual ICollection<Location> LocationGslTypeNavigations { get; } = new List<Location>();

    public virtual ICollection<Location> LocationTypeNavigations { get; } = new List<Location>();

    public virtual ICollection<MenuDesigner> MenuDesigners { get; } = new List<MenuDesigner>();

    public virtual ICollection<MovieSchedule> MovieSchedules { get; } = new List<MovieSchedule>();

    public virtual ICollection<Movie> Movies { get; } = new List<Movie>();

    public virtual ICollection<NonCashTransaction> NonCashTransactions { get; } = new List<NonCashTransaction>();

    public virtual ICollection<ObjectStateDefinition> ObjectStateDefinitions { get; } = new List<ObjectStateDefinition>();

    public virtual ICollection<Period> Periods { get; } = new List<Period>();

    public virtual ICollection<PreferenceAccess> PreferenceAccesses { get; } = new List<PreferenceAccess>();

    public virtual ICollection<Preference> PreferencePointerNavigations { get; } = new List<Preference>();

    public virtual ICollection<Preference> PreferenceReferenceNavigations { get; } = new List<Preference>();

    public virtual ICollection<Question> Questions { get; } = new List<Question>();

    public virtual ICollection<Range> Ranges { get; } = new List<Range>();

    public virtual ICollection<ReconciliationDetail> ReconciliationDetails { get; } = new List<ReconciliationDetail>();

    public virtual ICollection<ReconciliationSummary> ReconciliationSummaryComparisionNavigations { get; } = new List<ReconciliationSummary>();

    public virtual ICollection<ReconciliationSummary> ReconciliationSummaryComparisionTypeNavigations { get; } = new List<ReconciliationSummary>();

    public virtual ICollection<Relation> Relations { get; } = new List<Relation>();

    public virtual ICollection<Report> ReportCategoryNavigations { get; } = new List<Report>();

    public virtual ICollection<Report> ReportPointerNavigations { get; } = new List<Report>();

    public virtual ICollection<Report> ReportReportTypeNavigations { get; } = new List<Report>();

    public virtual ICollection<RequiredGsl> RequiredGslTypeNavigations { get; } = new List<RequiredGsl>();

    public virtual ICollection<RequiredGsl> RequiredGslVoucherDefnNavigations { get; } = new List<RequiredGsl>();

    public virtual ICollection<RequiredGsldetail> RequiredGsldetails { get; } = new List<RequiredGsldetail>();

    public virtual ICollection<Route> RouteFromStationNavigations { get; } = new List<Route>();

    public virtual ICollection<Route> RouteToStationNavigations { get; } = new List<Route>();

    public virtual ICollection<Route> RouteTransportTypeNavigations { get; } = new List<Route>();

    public virtual ICollection<ScheduleHeader> ScheduleHeaderCateogryNavigations { get; } = new List<ScheduleHeader>();

    public virtual ICollection<ScheduleHeader> ScheduleHeaderTypeNavigations { get; } = new List<ScheduleHeader>();

    public virtual ICollection<Schedule> Schedules { get; } = new List<Schedule>();

    public virtual ICollection<SeatTransaction> SeatTransactions { get; } = new List<SeatTransaction>();

    public virtual ICollection<Space> SpaceCategoryNavigations { get; } = new List<Space>();

    public virtual ICollection<Space> SpaceTypeNavigations { get; } = new List<Space>();

    public virtual ICollection<Tax> Taxes { get; } = new List<Tax>();

    public virtual ICollection<TermDefinition> TermDefinitionCategoryNavigations { get; } = new List<TermDefinition>();

    public virtual ICollection<TermDefinition> TermDefinitionVoucherDefnNavigations { get; } = new List<TermDefinition>();

    public virtual ICollection<TransactionLimit> TransactionLimits { get; } = new List<TransactionLimit>();

    public virtual ICollection<TransactionReference> TransactionReferenceReferencedVoucherDefnNavigations { get; } = new List<TransactionReference>();

    public virtual ICollection<TransactionReference> TransactionReferenceReferencingVoucherDefnNavigations { get; } = new List<TransactionReference>();

    public virtual ICollection<TransactionReference> TransactionReferenceRelationTypeNavigations { get; } = new List<TransactionReference>();

    public virtual ICollection<ValueFactorDefinition> ValueFactorDefinitions { get; } = new List<ValueFactorDefinition>();

    public virtual ICollection<ValueFactorSetup> ValueFactorSetups { get; } = new List<ValueFactorSetup>();

    public virtual ICollection<ValueFactor> ValueFactors { get; } = new List<ValueFactor>();

    public virtual ICollection<VoucherConsigneeList> VoucherConsigneeLists { get; } = new List<VoucherConsigneeList>();

    public virtual ICollection<Voucher> VoucherDefinitionNavigations { get; } = new List<Voucher>();

    public virtual ICollection<VoucherExtension> VoucherExtensionTypeNavigations { get; } = new List<VoucherExtension>();

    public virtual ICollection<VoucherExtension> VoucherExtensionVoucherDefnNavigations { get; } = new List<VoucherExtension>();

    public virtual ICollection<VoucherLookupList> VoucherLookupLists { get; } = new List<VoucherLookupList>();

    public virtual ICollection<VoucherStoreMapping> VoucherStoreMappings { get; } = new List<VoucherStoreMapping>();

    public virtual ICollection<Voucher> VoucherTypeNavigations { get; } = new List<Voucher>();
}
