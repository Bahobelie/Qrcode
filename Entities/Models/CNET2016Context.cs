using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

public partial class CNET2016Context : DbContext
{
    public CNET2016Context()
    {
    }

    public CNET2016Context(DbContextOptions<CNET2016Context> options)
        : base(options)
    {
    }

    public virtual DbSet<ACLog> ACLogs { get; set; }

    public virtual DbSet<AccessControlView> AccessControlViews { get; set; }

    public virtual DbSet<AccessMatrix> AccessMatrices { get; set; }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<AccountAction> AccountActions { get; set; }

    public virtual DbSet<AccountMap> AccountMaps { get; set; }

    public virtual DbSet<Action> Actions { get; set; }

    public virtual DbSet<Activity> Activities { get; set; }

    public virtual DbSet<ActivityDefination_view> ActivityDefination_views { get; set; }

    public virtual DbSet<ActivityDefinition> ActivityDefinitions { get; set; }

    public virtual DbSet<ActivityPrevilege_view> ActivityPrevilege_views { get; set; }

    public virtual DbSet<ActivityView> ActivityViews { get; set; }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Address_View> Address_Views { get; set; }

    public virtual DbSet<AllArticleRelatedInfo_View> AllArticleRelatedInfo_Views { get; set; }

    public virtual DbSet<AllResturantTable> AllResturantTables { get; set; }

    public virtual DbSet<AllVisualControlFunctionality> AllVisualControlFunctionalities { get; set; }

    public virtual DbSet<AnswerKey> AnswerKeys { get; set; }

    public virtual DbSet<AnswerSheet> AnswerSheets { get; set; }

    public virtual DbSet<Article> Articles { get; set; }

    public virtual DbSet<ArticleBeginningStockView> ArticleBeginningStockViews { get; set; }

    public virtual DbSet<ArticleComponent> ArticleComponents { get; set; }

    public virtual DbSet<ArticleDetail_View> ArticleDetail_Views { get; set; }

    public virtual DbSet<ArticleModifier> ArticleModifiers { get; set; }

    public virtual DbSet<ArticleValuesView> ArticleValuesViews { get; set; }

    public virtual DbSet<Article_View> Article_Views { get; set; }

    public virtual DbSet<Attachment> Attachments { get; set; }

    public virtual DbSet<Attachment_View> Attachment_Views { get; set; }

    public virtual DbSet<AttendanceAnalysis> AttendanceAnalyses { get; set; }

    public virtual DbSet<AttendanceException> AttendanceExceptions { get; set; }

    public virtual DbSet<AttendanceLog> AttendanceLogs { get; set; }

    public virtual DbSet<AvailabilityCalendar> AvailabilityCalendars { get; set; }

    public virtual DbSet<BankAccountDetail> BankAccountDetails { get; set; }

    public virtual DbSet<Beginning> Beginnings { get; set; }

    public virtual DbSet<BeginningBalance_View> BeginningBalance_Views { get; set; }

    public virtual DbSet<BeginningTransaction> BeginningTransactions { get; set; }

    public virtual DbSet<Block> Blocks { get; set; }

    public virtual DbSet<Branch> Branches { get; set; }

    public virtual DbSet<CNETComponent> CNETComponents { get; set; }

    public virtual DbSet<CNETLicense> CNETLicenses { get; set; }

    public virtual DbSet<CNETMedium> CNETMedia { get; set; }

    public virtual DbSet<CNETPrivacy> CNETPrivacies { get; set; }

    public virtual DbSet<CNETSystemUpdate> CNETSystemUpdates { get; set; }

    public virtual DbSet<CNETVariation> CNETVariations { get; set; }

    public virtual DbSet<CNET_GP> CNET_GPs { get; set; }

    public virtual DbSet<Card> Cards { get; set; }

    public virtual DbSet<CardView> CardViews { get; set; }

    public virtual DbSet<Career> Careers { get; set; }

    public virtual DbSet<CartTransaction> CartTransactions { get; set; }

    public virtual DbSet<CaseDetail> CaseDetails { get; set; }

    public virtual DbSet<ChargableRegistrationView> ChargableRegistrationViews { get; set; }

    public virtual DbSet<CheckoutDetailView> CheckoutDetailViews { get; set; }

    public virtual DbSet<Choice> Choices { get; set; }

    public virtual DbSet<ClearanceEmployeeView> ClearanceEmployeeViews { get; set; }

    public virtual DbSet<ClientsLicense> ClientsLicenses { get; set; }

    public virtual DbSet<ClosedRelation> ClosedRelations { get; set; }

    public virtual DbSet<ClosingValidation> ClosingValidations { get; set; }

    public virtual DbSet<CloudSync> CloudSyncs { get; set; }

    public virtual DbSet<CommunicationSource> CommunicationSources { get; set; }

    public virtual DbSet<Configuration> Configurations { get; set; }

    public virtual DbSet<ConsigneeDetail_View> ConsigneeDetail_Views { get; set; }

    public virtual DbSet<ConsigneeReconciliation_View> ConsigneeReconciliation_Views { get; set; }

    public virtual DbSet<ControlAccount> ControlAccounts { get; set; }

    public virtual DbSet<ControlAccountView> ControlAccountViews { get; set; }

    public virtual DbSet<ConversionDefinition> ConversionDefinitions { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<CreditCardAuthorization> CreditCardAuthorizations { get; set; }

    public virtual DbSet<Currency> Currencies { get; set; }

    public virtual DbSet<CurrencyPreference> CurrencyPreferences { get; set; }

    public virtual DbSet<DailyResidentSummary> DailyResidentSummaries { get; set; }

    public virtual DbSet<DailyRoomChargePosting_View> DailyRoomChargePosting_Views { get; set; }

    public virtual DbSet<DefaultIndustrialSetting> DefaultIndustrialSettings { get; set; }

    public virtual DbSet<Delegate> Delegates { get; set; }

    public virtual DbSet<Denomination> Denominations { get; set; }

    public virtual DbSet<DenominationDetail> DenominationDetails { get; set; }

    public virtual DbSet<DepreciationRule> DepreciationRules { get; set; }

    public virtual DbSet<Device> Devices { get; set; }

    public virtual DbSet<DeviceDetail_View> DeviceDetail_Views { get; set; }

    public virtual DbSet<DeviceIPParameterView> DeviceIPParameterViews { get; set; }

    public virtual DbSet<DeviceSchedule> DeviceSchedules { get; set; }

    public virtual DbSet<DeviceView> DeviceViews { get; set; }

    public virtual DbSet<DiscountFactor> DiscountFactors { get; set; }

    public virtual DbSet<Discrepancy> Discrepancies { get; set; }

    public virtual DbSet<DisplayOrder> DisplayOrders { get; set; }

    public virtual DbSet<Distribution> Distributions { get; set; }

    public virtual DbSet<DocumentAuditView> DocumentAuditViews { get; set; }

    public virtual DbSet<EffortConsumption> EffortConsumptions { get; set; }

    public virtual DbSet<EscalationDetail> EscalationDetails { get; set; }

    public virtual DbSet<EvaluationSheet> EvaluationSheets { get; set; }

    public virtual DbSet<EvenetRequiremenet> EvenetRequiremenets { get; set; }

    public virtual DbSet<EventDetail> EventDetails { get; set; }

    public virtual DbSet<ExchangeRate> ExchangeRates { get; set; }

    public virtual DbSet<Face> Faces { get; set; }

    public virtual DbSet<FieldFormat> FieldFormats { get; set; }

    public virtual DbSet<FieldFormat_View> FieldFormat_Views { get; set; }

    public virtual DbSet<FiscalExtension> FiscalExtensions { get; set; }

    public virtual DbSet<FixedAssetInventoryView> FixedAssetInventoryViews { get; set; }

    public virtual DbSet<Font> Fonts { get; set; }

    public virtual DbSet<FormulationView> FormulationViews { get; set; }

    public virtual DbSet<Functionality> Functionalities { get; set; }

    public virtual DbSet<GSLAcctRequirement> GSLAcctRequirements { get; set; }

    public virtual DbSet<GSLAddressMap> GSLAddressMaps { get; set; }

    public virtual DbSet<GSLNote> GSLNotes { get; set; }

    public virtual DbSet<GSLTax> GSLTaxes { get; set; }

    public virtual DbSet<GSLTypeList> GSLTypeLists { get; set; }

    public virtual DbSet<GSLTypeListView> GSLTypeListViews { get; set; }

    public virtual DbSet<GSLUser> GSLUsers { get; set; }

    public virtual DbSet<GetAllOrderStationMapView> GetAllOrderStationMapViews { get; set; }

    public virtual DbSet<GetSerialDefAndCodeDetail_View> GetSerialDefAndCodeDetail_Views { get; set; }

    public virtual DbSet<HKAssignment> HKAssignments { get; set; }

    public virtual DbSet<HKValue> HKValues { get; set; }

    public virtual DbSet<Holiday> Holidays { get; set; }

    public virtual DbSet<HolidayDefinition> HolidayDefinitions { get; set; }

    public virtual DbSet<Hospitality_DetailReport_View> Hospitality_DetailReport_Views { get; set; }

    public virtual DbSet<Hospitality_HeaderReport_view> Hospitality_HeaderReport_views { get; set; }

    public virtual DbSet<IPParameter> IPParameters { get; set; }

    public virtual DbSet<IPTV_VOD_VIEW> IPTV_VOD_VIEWs { get; set; }

    public virtual DbSet<IdDefinationView> IdDefinationViews { get; set; }

    public virtual DbSet<IdDefinition> IdDefinitions { get; set; }

    public virtual DbSet<IdSetting> IdSettings { get; set; }

    public virtual DbSet<IdSettingAuditView> IdSettingAuditViews { get; set; }

    public virtual DbSet<IdSettingView> IdSettingViews { get; set; }

    public virtual DbSet<Identification> Identifications { get; set; }

    public virtual DbSet<IndustryInvolved> IndustryInvolveds { get; set; }

    public virtual DbSet<IssuedCared> IssuedCareds { get; set; }

    public virtual DbSet<JobDescription> JobDescriptions { get; set; }

    public virtual DbSet<JournalAuditDetailView> JournalAuditDetailViews { get; set; }

    public virtual DbSet<JournalDetail> JournalDetails { get; set; }

    public virtual DbSet<JournalDetailReconcilation> JournalDetailReconcilations { get; set; }

    public virtual DbSet<JournalDetailView> JournalDetailViews { get; set; }

    public virtual DbSet<JournalReferenceAuditView> JournalReferenceAuditViews { get; set; }

    public virtual DbSet<KeyDefinition> KeyDefinitions { get; set; }

    public virtual DbSet<KeyOption> KeyOptions { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<LanguageOfInterest> LanguageOfInterests { get; set; }

    public virtual DbSet<LifeSpan> LifeSpans { get; set; }

    public virtual DbSet<Lifetime> Lifetimes { get; set; }

    public virtual DbSet<LineItem> LineItems { get; set; }

    public virtual DbSet<LineItemConversion> LineItemConversions { get; set; }

    public virtual DbSet<LineItemConversionLookup> LineItemConversionLookups { get; set; }

    public virtual DbSet<LineItemDetail_View> LineItemDetail_Views { get; set; }

    public virtual DbSet<LineItemExtension> LineItemExtensions { get; set; }

    public virtual DbSet<LineItemModfier> LineItemModfiers { get; set; }

    public virtual DbSet<LineItemNote> LineItemNotes { get; set; }

    public virtual DbSet<LineItemReference> LineItemReferences { get; set; }

    public virtual DbSet<LineItemSeatAndState> LineItemSeatAndStates { get; set; }

    public virtual DbSet<LineItemValueFactor> LineItemValueFactors { get; set; }

    public virtual DbSet<LineitemWeight> LineitemWeights { get; set; }

    public virtual DbSet<ListOfWaiterView> ListOfWaiterViews { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<Location_View> Location_Views { get; set; }

    public virtual DbSet<Log> Logs { get; set; }

    public virtual DbSet<Log_View> Log_Views { get; set; }

    public virtual DbSet<Lookup> Lookups { get; set; }

    public virtual DbSet<Lookup1> Lookups1 { get; set; }

    public virtual DbSet<MTDView> MTDViews { get; set; }

    public virtual DbSet<Mail> Mail { get; set; }

    public virtual DbSet<Media_View> Media_Views { get; set; }

    public virtual DbSet<MenuDesigner> MenuDesigners { get; set; }

    public virtual DbSet<Message_View> Message_Views { get; set; }

    public virtual DbSet<MobileTransaction> MobileTransactions { get; set; }

    public virtual DbSet<ModificationHistory> ModificationHistories { get; set; }

    public virtual DbSet<ModificationHistory_VIEW> ModificationHistory_VIEWs { get; set; }

    public virtual DbSet<ModificationLogview> ModificationLogviews { get; set; }

    public virtual DbSet<Movie> Movies { get; set; }

    public virtual DbSet<MovieSchedule> MovieSchedules { get; set; }

    public virtual DbSet<MultiOrganization> MultiOrganizations { get; set; }

    public virtual DbSet<NegotiatedRate> NegotiatedRates { get; set; }

    public virtual DbSet<NonCashDeposit> NonCashDeposits { get; set; }

    public virtual DbSet<NonCashTransaction> NonCashTransactions { get; set; }

    public virtual DbSet<NonCashTransaction_View> NonCashTransaction_Views { get; set; }

    public virtual DbSet<ObjectState> ObjectStates { get; set; }

    public virtual DbSet<ObjectStateDefinition> ObjectStateDefinitions { get; set; }

    public virtual DbSet<ObjectStateView> ObjectStateViews { get; set; }

    public virtual DbSet<OptionalCode> OptionalCodes { get; set; }

    public virtual DbSet<OrderStationMap> OrderStationMaps { get; set; }

    public virtual DbSet<Organization> Organizations { get; set; }

    public virtual DbSet<OrganizationUnit> OrganizationUnits { get; set; }

    public virtual DbSet<OrganizationUnitDefinition> OrganizationUnitDefinitions { get; set; }

    public virtual DbSet<Organization_Region_Town_View> Organization_Region_Town_Views { get; set; }

    public virtual DbSet<Organization_View> Organization_Views { get; set; }

    public virtual DbSet<OtherConsignee> OtherConsignees { get; set; }

    public virtual DbSet<POS_Artticle_View> POS_Artticle_Views { get; set; }

    public virtual DbSet<PREMIUM_RMS_Bills_View> PREMIUM_RMS_Bills_Views { get; set; }

    public virtual DbSet<PackageDetail> PackageDetails { get; set; }

    public virtual DbSet<PackageHeader> PackageHeaders { get; set; }

    public virtual DbSet<PackageToPost_View> PackageToPost_Views { get; set; }

    public virtual DbSet<PackagesToPost> PackagesToPosts { get; set; }

    public virtual DbSet<PaymentSchedule> PaymentSchedules { get; set; }

    public virtual DbSet<Period> Periods { get; set; }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<PersonOrganization_View> PersonOrganization_Views { get; set; }

    public virtual DbSet<Person_View> Person_Views { get; set; }

    public virtual DbSet<PhysicalDimension> PhysicalDimensions { get; set; }

    public virtual DbSet<Plan> Plans { get; set; }

    public virtual DbSet<PlanDetail> PlanDetails { get; set; }

    public virtual DbSet<PoliceReport> PoliceReports { get; set; }

    public virtual DbSet<PostingRoutineDetail> PostingRoutineDetails { get; set; }

    public virtual DbSet<PostingRoutineHeader> PostingRoutineHeaders { get; set; }

    public virtual DbSet<PostingSchedule> PostingSchedules { get; set; }

    public virtual DbSet<PreferedOrganizationList_View> PreferedOrganizationList_Views { get; set; }

    public virtual DbSet<Preference> Preferences { get; set; }

    public virtual DbSet<PreferenceAccess> PreferenceAccesses { get; set; }

    public virtual DbSet<PreferenceValueFactor> PreferenceValueFactors { get; set; }

    public virtual DbSet<PreferenceView> PreferenceViews { get; set; }

    public virtual DbSet<Preference_Attachment_View> Preference_Attachment_Views { get; set; }

    public virtual DbSet<Process> Processes { get; set; }

    public virtual DbSet<ProcessTaskMap> ProcessTaskMaps { get; set; }

    public virtual DbSet<ProductExtension> ProductExtensions { get; set; }

    public virtual DbSet<ProgressTaxRate> ProgressTaxRates { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<ProjectTimeRequirment> ProjectTimeRequirments { get; set; }

    public virtual DbSet<PromotionView> PromotionViews { get; set; }

    public virtual DbSet<QCTest> QCTests { get; set; }

    public virtual DbSet<Question> Questions { get; set; }

    public virtual DbSet<QuestionRouter> QuestionRouters { get; set; }

    public virtual DbSet<RMSExtension> RMSExtensions { get; set; }

    public virtual DbSet<Range> Ranges { get; set; }

    public virtual DbSet<Rate> Rates { get; set; }

    public virtual DbSet<RateAdjustment> RateAdjustments { get; set; }

    public virtual DbSet<RateCategory> RateCategories { get; set; }

    public virtual DbSet<RateCategoryRateStrategy> RateCategoryRateStrategies { get; set; }

    public virtual DbSet<RateCodeCategoryCurrency_View> RateCodeCategoryCurrency_Views { get; set; }

    public virtual DbSet<RateCodeDetail> RateCodeDetails { get; set; }

    public virtual DbSet<RateCodeDetailGuestCount> RateCodeDetailGuestCounts { get; set; }

    public virtual DbSet<RateCodeDetailRoomType> RateCodeDetailRoomTypes { get; set; }

    public virtual DbSet<RateCodeHeader> RateCodeHeaders { get; set; }

    public virtual DbSet<RateCodePackage> RateCodePackages { get; set; }

    public virtual DbSet<RateCodeRateStrategy> RateCodeRateStrategies { get; set; }

    public virtual DbSet<RateCodeRoomType> RateCodeRoomTypes { get; set; }

    public virtual DbSet<RateComponent> RateComponents { get; set; }

    public virtual DbSet<RateDetailRoomTypeWeek_View> RateDetailRoomTypeWeek_Views { get; set; }

    public virtual DbSet<RateDetailRoomType_View> RateDetailRoomType_Views { get; set; }

    public virtual DbSet<RatePackage> RatePackages { get; set; }

    public virtual DbSet<RatePackage_View> RatePackage_Views { get; set; }

    public virtual DbSet<RateQuery_View> RateQuery_Views { get; set; }

    public virtual DbSet<RateStrategy> RateStrategies { get; set; }

    public virtual DbSet<ReconciliationDetail> ReconciliationDetails { get; set; }

    public virtual DbSet<ReconciliationDetailView> ReconciliationDetailViews { get; set; }

    public virtual DbSet<ReconciliationSummary> ReconciliationSummaries { get; set; }

    public virtual DbSet<ReconciliationSummaryView> ReconciliationSummaryViews { get; set; }

    public virtual DbSet<RegionalDetail> RegionalDetails { get; set; }

    public virtual DbSet<RegistrationDetail> RegistrationDetails { get; set; }

    public virtual DbSet<RegistrationExtension> RegistrationExtensions { get; set; }

    public virtual DbSet<RegistrationPrivllege> RegistrationPrivlleges { get; set; }

    public virtual DbSet<Relation> Relations { get; set; }

    public virtual DbSet<RelationDetail> RelationDetails { get; set; }

    public virtual DbSet<RelationDetail_View> RelationDetail_Views { get; set; }

    public virtual DbSet<RelationalState> RelationalStates { get; set; }

    public virtual DbSet<RemovedItem> RemovedItems { get; set; }

    public virtual DbSet<Report> Reports { get; set; }

    public virtual DbSet<ReportCriterion> ReportCriteria { get; set; }

    public virtual DbSet<ReportHistory> ReportHistories { get; set; }

    public virtual DbSet<RequiredGSLDetail> RequiredGSLDetails { get; set; }

    public virtual DbSet<RequiredGSL_View> RequiredGSL_Views { get; set; }

    public virtual DbSet<RequriedGSL> RequriedGSLs { get; set; }

    public virtual DbSet<Reservation_View> Reservation_Views { get; set; }

    public virtual DbSet<ResidentSummary> ResidentSummaries { get; set; }

    public virtual DbSet<RestaurantTable> RestaurantTables { get; set; }

    public virtual DbSet<RestaurantTree> RestaurantTrees { get; set; }

    public virtual DbSet<RoleActivity> RoleActivities { get; set; }

    public virtual DbSet<RoomActivityView> RoomActivityViews { get; set; }

    public virtual DbSet<RoomDetail> RoomDetails { get; set; }

    public virtual DbSet<RoomFeature> RoomFeatures { get; set; }

    public virtual DbSet<RoomInventory_View> RoomInventory_Views { get; set; }

    public virtual DbSet<RoomType> RoomTypes { get; set; }

    public virtual DbSet<RoomTypeRateStrategy> RoomTypeRateStrategies { get; set; }

    public virtual DbSet<Route> Routes { get; set; }

    public virtual DbSet<RouteSale> RouteSales { get; set; }

    public virtual DbSet<SalesReportHeiniken> SalesReportHeinikens { get; set; }

    public virtual DbSet<Schedule> Schedules { get; set; }

    public virtual DbSet<ScheduleControllerMapView> ScheduleControllerMapViews { get; set; }

    public virtual DbSet<ScheduleDetail> ScheduleDetails { get; set; }

    public virtual DbSet<ScheduleHeader> ScheduleHeaders { get; set; }

    public virtual DbSet<ScheduleHeader_view> ScheduleHeader_views { get; set; }

    public virtual DbSet<SeasonalMessage> SeasonalMessages { get; set; }

    public virtual DbSet<SeatArrangement> SeatArrangements { get; set; }

    public virtual DbSet<SeatTransaction> SeatTransactions { get; set; }

    public virtual DbSet<SelectedValueFactor_VIEW> SelectedValueFactor_VIEWs { get; set; }

    public virtual DbSet<SerialCode> SerialCodes { get; set; }

    public virtual DbSet<SerialDefinition> SerialDefinitions { get; set; }

    public virtual DbSet<SerialDefinition_View> SerialDefinition_Views { get; set; }

    public virtual DbSet<SerialParameter> SerialParameters { get; set; }

    public virtual DbSet<Session> Sessions { get; set; }

    public virtual DbSet<ShapeMapper> ShapeMappers { get; set; }

    public virtual DbSet<Shift> Shifts { get; set; }

    public virtual DbSet<Space> Spaces { get; set; }

    public virtual DbSet<SpaceCapacity> SpaceCapacities { get; set; }

    public virtual DbSet<SpaceDirection> SpaceDirections { get; set; }

    public virtual DbSet<Space_View> Space_Views { get; set; }

    public virtual DbSet<Specification> Specifications { get; set; }

    public virtual DbSet<StockBalance> StockBalances { get; set; }

    public virtual DbSet<StockLevel> StockLevels { get; set; }

    public virtual DbSet<StockLevelView> StockLevelViews { get; set; }

    public virtual DbSet<Stockbalance_view> Stockbalance_views { get; set; }

    public virtual DbSet<StoreTransaction> StoreTransactions { get; set; }

    public virtual DbSet<Subcountry> Subcountries { get; set; }

    public virtual DbSet<SubscriptionControllerMapView> SubscriptionControllerMapViews { get; set; }

    public virtual DbSet<SubscriptionView> SubscriptionViews { get; set; }

    public virtual DbSet<Subtitle> Subtitles { get; set; }

    public virtual DbSet<Tax> Taxes { get; set; }

    public virtual DbSet<TaxTransaction> TaxTransactions { get; set; }

    public virtual DbSet<TaxWithCategory> TaxWithCategories { get; set; }

    public virtual DbSet<TermList> TermLists { get; set; }

    public virtual DbSet<TimeSheet> TimeSheets { get; set; }

    public virtual DbSet<TranReferenceReconciliation_View> TranReferenceReconciliation_Views { get; set; }

    public virtual DbSet<TranRoutingDetail> TranRoutingDetails { get; set; }

    public virtual DbSet<TranRoutingHeader> TranRoutingHeaders { get; set; }

    public virtual DbSet<TransactionCurrency> TransactionCurrencies { get; set; }

    public virtual DbSet<TransactionLimit> TransactionLimits { get; set; }

    public virtual DbSet<TransactionReference> TransactionReferences { get; set; }

    public virtual DbSet<TransactionReferenceVoucherView> TransactionReferenceVoucherViews { get; set; }

    public virtual DbSet<TransactionSession> TransactionSessions { get; set; }

    public virtual DbSet<Translation> Translations { get; set; }

    public virtual DbSet<TravelDetail> TravelDetails { get; set; }

    public virtual DbSet<TrialBalance> TrialBalances { get; set; }

    public virtual DbSet<TurnDown> TurnDowns { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserRoleMapper> UserRoleMappers { get; set; }

    public virtual DbSet<UserSession> UserSessions { get; set; }

    public virtual DbSet<VOD_View> VOD_Views { get; set; }

    public virtual DbSet<Value> Values { get; set; }

    public virtual DbSet<ValueFactor> ValueFactors { get; set; }

    public virtual DbSet<ValueFactorDefinition> ValueFactorDefinitions { get; set; }

    public virtual DbSet<ValueFactorSetup> ValueFactorSetups { get; set; }

    public virtual DbSet<Value_View> Value_Views { get; set; }

    public virtual DbSet<VauesSummaryByReferenceView> VauesSummaryByReferenceViews { get; set; }

    public virtual DbSet<ViewDeviceByReference> ViewDeviceByReferences { get; set; }

    public virtual DbSet<ViewFont> ViewFonts { get; set; }

    public virtual DbSet<ViewGetVoucherExtTran> ViewGetVoucherExtTrans { get; set; }

    public virtual DbSet<ViewHolidayPeriod> ViewHolidayPeriods { get; set; }

    public virtual DbSet<ViewOrganizationUnitInfo> ViewOrganizationUnitInfos { get; set; }

    public virtual DbSet<ViewWorkFlow> ViewWorkFlows { get; set; }

    public virtual DbSet<View_1> View_1s { get; set; }

    public virtual DbSet<View_2> View_2s { get; set; }

    public virtual DbSet<View_ArticlePrice> View_ArticlePrices { get; set; }

    public virtual DbSet<View_GetIssuedCardInfo> View_GetIssuedCardInfos { get; set; }

    public virtual DbSet<VoidLastPlacement> VoidLastPlacements { get; set; }

    public virtual DbSet<Voucher> Vouchers { get; set; }

    public virtual DbSet<VoucherAccount> VoucherAccounts { get; set; }

    public virtual DbSet<VoucherAccount_View> VoucherAccount_Views { get; set; }

    public virtual DbSet<VoucherAttachmentView> VoucherAttachmentViews { get; set; }

    public virtual DbSet<VoucherDashBoardPrivilege> VoucherDashBoardPrivileges { get; set; }

    public virtual DbSet<VoucherDefinition> VoucherDefinitions { get; set; }

    public virtual DbSet<VoucherDetail_View> VoucherDetail_Views { get; set; }

    public virtual DbSet<VoucherExtension> VoucherExtensions { get; set; }

    public virtual DbSet<VoucherExtensionTransaction> VoucherExtensionTransactions { get; set; }

    public virtual DbSet<VoucherExtension_View> VoucherExtension_Views { get; set; }

    public virtual DbSet<VoucherLineItemView> VoucherLineItemViews { get; set; }

    public virtual DbSet<VoucherLookupDetail> VoucherLookupDetails { get; set; }

    public virtual DbSet<VoucherNote> VoucherNotes { get; set; }

    public virtual DbSet<VoucherOperation> VoucherOperations { get; set; }

    public virtual DbSet<VoucherRegistrationView> VoucherRegistrationViews { get; set; }

    public virtual DbSet<VoucherStoreMapping> VoucherStoreMappings { get; set; }

    public virtual DbSet<VoucherTerm> VoucherTerms { get; set; }

    public virtual DbSet<VoucherValue> VoucherValues { get; set; }

    public virtual DbSet<Voucher_BackwardReferenceReport_View> Voucher_BackwardReferenceReport_Views { get; set; }

    public virtual DbSet<Voucher_DetailExtensionReport_View> Voucher_DetailExtensionReport_Views { get; set; }

    public virtual DbSet<Voucher_DetailReport_View> Voucher_DetailReport_Views { get; set; }

    public virtual DbSet<Voucher_DetailReport_View1> Voucher_DetailReport_Views1 { get; set; }

    public virtual DbSet<Voucher_ForwardReferenceReport_View> Voucher_ForwardReferenceReport_Views { get; set; }

    public virtual DbSet<Voucher_HeaderReport_view> Voucher_HeaderReport_views { get; set; }

    public virtual DbSet<Voucher_ReferenceReport_View> Voucher_ReferenceReport_Views { get; set; }

    public virtual DbSet<Voucher_Relation_View> Voucher_Relation_Views { get; set; }

    public virtual DbSet<Voucher_RemovedArticleReport_View> Voucher_RemovedArticleReport_Views { get; set; }

    public virtual DbSet<Voucher_SalesBySupplier_View> Voucher_SalesBySupplier_Views { get; set; }

    public virtual DbSet<Voucher_View> Voucher_Views { get; set; }

    public virtual DbSet<Voucher_WorkflowReport_View> Voucher_WorkflowReport_Views { get; set; }

    public virtual DbSet<Vw_ModificationHistory> Vw_ModificationHistories { get; set; }

    public virtual DbSet<WeekDay> WeekDays { get; set; }

    public virtual DbSet<WriteUp> WriteUps { get; set; }

    public virtual DbSet<_Address_CityProvince_View> _Address_CityProvince_Views { get; set; }

    public virtual DbSet<_Address_EXTENSION_View> _Address_EXTENSION_Views { get; set; }

    public virtual DbSet<_Address_Email_View> _Address_Email_Views { get; set; }

    public virtual DbSet<_Address_Fax_View> _Address_Fax_Views { get; set; }

    public virtual DbSet<_Address_HOME_PHONE_View> _Address_HOME_PHONE_Views { get; set; }

    public virtual DbSet<_Address_HouseNo_View> _Address_HouseNo_Views { get; set; }

    public virtual DbSet<_Address_LINKED_IN_View> _Address_LINKED_IN_Views { get; set; }

    public virtual DbSet<_Address_Mobilephone_View> _Address_Mobilephone_Views { get; set; }

    public virtual DbSet<_Address_PHYSICAL_ADDRESS_View> _Address_PHYSICAL_ADDRESS_Views { get; set; }

    public virtual DbSet<_Address_POBox_View> _Address_POBox_Views { get; set; }

    public virtual DbSet<_Address_Region_View> _Address_Region_Views { get; set; }

    public virtual DbSet<_Address_SMTP_Server_View> _Address_SMTP_Server_Views { get; set; }

    public virtual DbSet<_Address_SOCAIL_MEDIA_View> _Address_SOCAIL_MEDIA_Views { get; set; }

    public virtual DbSet<_Address_Specific_Location_View> _Address_Specific_Location_Views { get; set; }

    public virtual DbSet<_Address_Website_View> _Address_Website_Views { get; set; }

    public virtual DbSet<_Address_WorkMobile_View> _Address_WorkMobile_Views { get; set; }

    public virtual DbSet<_Address_kebele_View> _Address_kebele_Views { get; set; }

    public virtual DbSet<_Address_subCity_View> _Address_subCity_Views { get; set; }

    public virtual DbSet<_Address_twitter_View> _Address_twitter_Views { get; set; }

    public virtual DbSet<_Address_wereda_View> _Address_wereda_Views { get; set; }

    public virtual DbSet<allSalesReportView> allSalesReportViews { get; set; }

    public virtual DbSet<beauty_supply_items_view> beauty_supply_items_views { get; set; }

    public virtual DbSet<cloth_items_view> cloth_items_views { get; set; }

    public virtual DbSet<consolidated_beauty_supply_items_view> consolidated_beauty_supply_items_views { get; set; }

    public virtual DbSet<consolidated_cloth_items_view> consolidated_cloth_items_views { get; set; }

    public virtual DbSet<consolidated_electrical_items_view> consolidated_electrical_items_views { get; set; }

    public virtual DbSet<consolidated_electronics_items_view> consolidated_electronics_items_views { get; set; }

    public virtual DbSet<consolidated_furniture_items_view> consolidated_furniture_items_views { get; set; }

    public virtual DbSet<consolidated_grocery_items_view> consolidated_grocery_items_views { get; set; }

    public virtual DbSet<consolidated_household_items_view> consolidated_household_items_views { get; set; }

    public virtual DbSet<consolidated_pharmacy_items_view> consolidated_pharmacy_items_views { get; set; }

    public virtual DbSet<consolidated_restaurant_items_view> consolidated_restaurant_items_views { get; set; }

    public virtual DbSet<db__vw_RelationDetal> db__vw_RelationDetals { get; set; }

    public virtual DbSet<electrical_items_view> electrical_items_views { get; set; }

    public virtual DbSet<electronics_items_view> electronics_items_views { get; set; }

    public virtual DbSet<furniture_items_view> furniture_items_views { get; set; }

    public virtual DbSet<grocery_items_view> grocery_items_views { get; set; }

    public virtual DbSet<household_items_view> household_items_views { get; set; }

    public virtual DbSet<organizationAddressView> organizationAddressViews { get; set; }

    public virtual DbSet<pharmacy_items_view> pharmacy_items_views { get; set; }

    public virtual DbSet<restaurant_items_view> restaurant_items_views { get; set; }

    public virtual DbSet<rptItemList> rptItemLists { get; set; }

    public virtual DbSet<rptTransactionReference> rptTransactionReferences { get; set; }

    public virtual DbSet<rptVoucherAttachment> rptVoucherAttachments { get; set; }

    public virtual DbSet<rptVoucherOperation> rptVoucherOperations { get; set; }

    public virtual DbSet<rptsummarized> rptsummarizeds { get; set; }

    public virtual DbSet<scheduleView> scheduleViews { get; set; }

    public virtual DbSet<testView> testViews { get; set; }

    public virtual DbSet<viewAccountBeginningBalance> viewAccountBeginningBalances { get; set; }

    public virtual DbSet<viewActivepersonRole> viewActivepersonRoles { get; set; }

    public virtual DbSet<viewActivityDefinition> viewActivityDefinitions { get; set; }

    public virtual DbSet<viewFunctWithAccessM> viewFunctWithAccessMs { get; set; }

    public virtual DbSet<viewGetLineItemSpanByReference> viewGetLineItemSpanByReferences { get; set; }

    public virtual DbSet<viewLineItemModifierNoteValFactor> viewLineItemModifierNoteValFactors { get; set; }

    public virtual DbSet<viewLineItemRef> viewLineItemRefs { get; set; }

    public virtual DbSet<viewOrgPersonByType> viewOrgPersonByTypes { get; set; }

    public virtual DbSet<viewPriceTag> viewPriceTags { get; set; }

    public virtual DbSet<viewRelationOjbect> viewRelationOjbects { get; set; }

    public virtual DbSet<viewReport> viewReports { get; set; }

    public virtual DbSet<viewReportCriteriaValue> viewReportCriteriaValues { get; set; }

    public virtual DbSet<viewRoleActivitywithRange> viewRoleActivitywithRanges { get; set; }

    public virtual DbSet<viewSpaceLocation> viewSpaceLocations { get; set; }

    public virtual DbSet<viewTransactionDenomination> viewTransactionDenominations { get; set; }

    public virtual DbSet<view_Lookup> view_Lookups { get; set; }

    public virtual DbSet<voucherActivity_View> voucherActivity_Views { get; set; }

    public virtual DbSet<vwSerialCode_description> vwSerialCode_descriptions { get; set; }

    public virtual DbSet<vwSynchronization_view> vwSynchronization_views { get; set; }

    public virtual DbSet<vw_ACLogView> vw_ACLogViews { get; set; }

    public virtual DbSet<vw_AccessControlDisplayView> vw_AccessControlDisplayViews { get; set; }

    public virtual DbSet<vw_AccessControlLogDetailnfo> vw_AccessControlLogDetailnfos { get; set; }

    public virtual DbSet<vw_AccompanyingView> vw_AccompanyingViews { get; set; }

    public virtual DbSet<vw_AccountMapView> vw_AccountMapViews { get; set; }

    public virtual DbSet<vw_AccountView> vw_AccountViews { get; set; }

    public virtual DbSet<vw_Account_AccountMap> vw_Account_AccountMaps { get; set; }

    public virtual DbSet<vw_AccountingConsigneeView> vw_AccountingConsigneeViews { get; set; }

    public virtual DbSet<vw_AccrualVoucher> vw_AccrualVouchers { get; set; }

    public virtual DbSet<vw_ActivityDefByCompAndRef> vw_ActivityDefByCompAndRefs { get; set; }

    public virtual DbSet<vw_ActivitySecurity> vw_ActivitySecurities { get; set; }

    public virtual DbSet<vw_AddressDetailView> vw_AddressDetailViews { get; set; }

    public virtual DbSet<vw_AddressValue> vw_AddressValues { get; set; }

    public virtual DbSet<vw_AddressWithValue> vw_AddressWithValues { get; set; }

    public virtual DbSet<vw_AgingMainVoucherView> vw_AgingMainVoucherViews { get; set; }

    public virtual DbSet<vw_AgingVoucherView> vw_AgingVoucherViews { get; set; }

    public virtual DbSet<vw_AllArticleOptionalCode> vw_AllArticleOptionalCodes { get; set; }

    public virtual DbSet<vw_AllLineItemArticle> vw_AllLineItemArticles { get; set; }

    public virtual DbSet<vw_AllPersonOrganizationName> vw_AllPersonOrganizationNames { get; set; }

    public virtual DbSet<vw_AllPersonOrganizationNamesAndPreference> vw_AllPersonOrganizationNamesAndPreferences { get; set; }

    public virtual DbSet<vw_AllPersonView> vw_AllPersonViews { get; set; }

    public virtual DbSet<vw_ArtPrefNoCatagory> vw_ArtPrefNoCatagories { get; set; }

    public virtual DbSet<vw_ArticleAccountMap> vw_ArticleAccountMaps { get; set; }

    public virtual DbSet<vw_ArticleActivity> vw_ArticleActivities { get; set; }

    public virtual DbSet<vw_ArticleBeginningView> vw_ArticleBeginningViews { get; set; }

    public virtual DbSet<vw_ArticleCBView> vw_ArticleCBViews { get; set; }

    public virtual DbSet<vw_ArticleComponentWithDescription> vw_ArticleComponentWithDescriptions { get; set; }

    public virtual DbSet<vw_ArticleHeader> vw_ArticleHeaders { get; set; }

    public virtual DbSet<vw_ArticlePhysicalDiman> vw_ArticlePhysicalDimen { get; set; }

    public virtual DbSet<vw_ArticlePreviousStockBalance> vw_ArticlePreviousStockBalances { get; set; }

    public virtual DbSet<vw_ArticleProductExtension> vw_ArticleProductExtensions { get; set; }

    public virtual DbSet<vw_ArticleStockBalanceBySerialNumber> vw_ArticleStockBalanceBySerialNumbers { get; set; }

    public virtual DbSet<vw_ArticleStockBalanceView> vw_ArticleStockBalanceViews { get; set; }

    public virtual DbSet<vw_ArticleStoreList> vw_ArticleStoreLists { get; set; }

    public virtual DbSet<vw_ArticleTransactionHistory> vw_ArticleTransactionHistories { get; set; }

    public virtual DbSet<vw_ArticleView> vw_ArticleViews { get; set; }

    public virtual DbSet<vw_ArticleViewINFO> vw_ArticleViewINFOs { get; set; }

    public virtual DbSet<vw_ArticleWithAccountMap> vw_ArticleWithAccountMaps { get; set; }

    public virtual DbSet<vw_AttendanceException> vw_AttendanceExceptions { get; set; }

    public virtual DbSet<vw_AttendanceExceptionView> vw_AttendanceExceptionViews { get; set; }

    public virtual DbSet<vw_AttendanceIdentification> vw_AttendanceIdentifications { get; set; }

    public virtual DbSet<vw_AttendanceLog> vw_AttendanceLogs { get; set; }

    public virtual DbSet<vw_AuditEmployeeView> vw_AuditEmployeeViews { get; set; }

    public virtual DbSet<vw_AuditPlacementVoucher> vw_AuditPlacementVouchers { get; set; }

    public virtual DbSet<vw_BackwardReference> vw_BackwardReferences { get; set; }

    public virtual DbSet<vw_BankBalanceView> vw_BankBalanceViews { get; set; }

    public virtual DbSet<vw_BankTransferView> vw_BankTransferViews { get; set; }

    public virtual DbSet<vw_BatchExpiryDateNotificationView> vw_BatchExpiryDateNotificationViews { get; set; }

    public virtual DbSet<vw_BiometericID> vw_BiometericIDs { get; set; }

    public virtual DbSet<vw_BookedTransactionView> vw_BookedTransactionViews { get; set; }

    public virtual DbSet<vw_CardIssuedView> vw_CardIssuedViews { get; set; }

    public virtual DbSet<vw_CareerView> vw_CareerViews { get; set; }

    public virtual DbSet<vw_CartView> vw_CartViews { get; set; }

    public virtual DbSet<vw_CaseVoucherView> vw_CaseVoucherViews { get; set; }

    public virtual DbSet<vw_CashDepositView> vw_CashDepositViews { get; set; }

    public virtual DbSet<vw_ChangeLogVoucherDetail> vw_ChangeLogVoucherDetails { get; set; }

    public virtual DbSet<vw_ClientsLicense> vw_ClientsLicenses { get; set; }

    public virtual DbSet<vw_CnetComponentWithLicence> vw_CnetComponentWithLicences { get; set; }

    public virtual DbSet<vw_CompanyPensionTaxtransaction> vw_CompanyPensionTaxtransactions { get; set; }

    public virtual DbSet<vw_ConsigneeView> vw_ConsigneeViews { get; set; }

    public virtual DbSet<vw_ConsolidatedCompanyRating> vw_ConsolidatedCompanyRatings { get; set; }

    public virtual DbSet<vw_ConsolidatedCompanyRatingDetail> vw_ConsolidatedCompanyRatingDetails { get; set; }

    public virtual DbSet<vw_CreditReceiptView> vw_CreditReceiptViews { get; set; }

    public virtual DbSet<vw_CreditValidationView> vw_CreditValidationViews { get; set; }

    public virtual DbSet<vw_CurrentArticleStockBalance> vw_CurrentArticleStockBalances { get; set; }

    public virtual DbSet<vw_DailyClosingDetail> vw_DailyClosingDetails { get; set; }

    public virtual DbSet<vw_DailySalesSummary> vw_DailySalesSummaries { get; set; }

    public virtual DbSet<vw_DashboardProfile> vw_DashboardProfiles { get; set; }

    public virtual DbSet<vw_DeliverDriver> vw_DeliverDrivers { get; set; }

    public virtual DbSet<vw_Device_Name> vw_Device_Names { get; set; }

    public virtual DbSet<vw_DiscountFactor> vw_DiscountFactors { get; set; }

    public virtual DbSet<vw_DistributionLookup> vw_DistributionLookups { get; set; }

    public virtual DbSet<vw_DocumentRangeView> vw_DocumentRangeViews { get; set; }

    public virtual DbSet<vw_ERCASalesView> vw_ERCASalesViews { get; set; }

    public virtual DbSet<vw_EcommerceOrderUnionView> vw_EcommerceOrderUnionViews { get; set; }

    public virtual DbSet<vw_EcommerceOrderView> vw_EcommerceOrderViews { get; set; }

    public virtual DbSet<vw_EmployeeAttachmentView> vw_EmployeeAttachmentViews { get; set; }

    public virtual DbSet<vw_EmployeeLastPlacement> vw_EmployeeLastPlacements { get; set; }

    public virtual DbSet<vw_EmployeeMobile> vw_EmployeeMobiles { get; set; }

    public virtual DbSet<vw_EmployeePensionTaxtransaction> vw_EmployeePensionTaxtransactions { get; set; }

    public virtual DbSet<vw_EmployeeView> vw_EmployeeViews { get; set; }

    public virtual DbSet<vw_EquipmentDatum> vw_EquipmentData { get; set; }

    public virtual DbSet<vw_EscalationVoucherView> vw_EscalationVoucherViews { get; set; }

    public virtual DbSet<vw_EvaluationSheet> vw_EvaluationSheets { get; set; }

    public virtual DbSet<vw_EventDetailView> vw_EventDetailViews { get; set; }

    public virtual DbSet<vw_EventDisplayView> vw_EventDisplayViews { get; set; }

    public virtual DbSet<vw_EventRequirementView> vw_EventRequirementViews { get; set; }

    public virtual DbSet<vw_EventView> vw_EventViews { get; set; }

    public virtual DbSet<vw_Extension> vw_Extensions { get; set; }

    public virtual DbSet<vw_FirstActivityVoucher> vw_FirstActivityVouchers { get; set; }

    public virtual DbSet<vw_FirstLineItemArticle> vw_FirstLineItemArticles { get; set; }

    public virtual DbSet<vw_FirstNonCashTransaction> vw_FirstNonCashTransactions { get; set; }

    public virtual DbSet<vw_FirstPlacement> vw_FirstPlacements { get; set; }

    public virtual DbSet<vw_FirstPlacementDate> vw_FirstPlacementDates { get; set; }

    public virtual DbSet<vw_FirstPlacementVoucher> vw_FirstPlacementVouchers { get; set; }

    public virtual DbSet<vw_FixedAssetAcquisitionValue> vw_FixedAssetAcquisitionValues { get; set; }

    public virtual DbSet<vw_FixedAssetBookValue> vw_FixedAssetBookValues { get; set; }

    public virtual DbSet<vw_FixedAssetBookValueComparison> vw_FixedAssetBookValueComparisons { get; set; }

    public virtual DbSet<vw_FixedAssetDepView> vw_FixedAssetDepViews { get; set; }

    public virtual DbSet<vw_FixedAssetDepriciationLineItem> vw_FixedAssetDepriciationLineItems { get; set; }

    public virtual DbSet<vw_FixedAssetMarketValue> vw_FixedAssetMarketValues { get; set; }

    public virtual DbSet<vw_FixedAssetSalvageValue> vw_FixedAssetSalvageValues { get; set; }

    public virtual DbSet<vw_FormulationView> vw_FormulationViews { get; set; }

    public virtual DbSet<vw_ForwardReference> vw_ForwardReferences { get; set; }

    public virtual DbSet<vw_GSLTaxList> vw_GSLTaxLists { get; set; }

    public virtual DbSet<vw_GetAttachmentTypeByLookUp> vw_GetAttachmentTypeByLookUps { get; set; }

    public virtual DbSet<vw_GroupedLineitemCategory> vw_GroupedLineitemCategories { get; set; }

    public virtual DbSet<vw_GuestComment> vw_GuestComments { get; set; }

    public virtual DbSet<vw_IdentificationBioId> vw_IdentificationBioIds { get; set; }

    public virtual DbSet<vw_IdentificationBiometric> vw_IdentificationBiometrics { get; set; }

    public virtual DbSet<vw_IdentificationTIN> vw_IdentificationTINs { get; set; }

    public virtual DbSet<vw_IncomeTaxtransaction> vw_IncomeTaxtransactions { get; set; }

    public virtual DbSet<vw_Industry> vw_Industries { get; set; }

    public virtual DbSet<vw_IndustryInvolvedOrganization> vw_IndustryInvolvedOrganizations { get; set; }

    public virtual DbSet<vw_InternalReference> vw_InternalReferences { get; set; }

    public virtual DbSet<vw_ItemReconciliationUnionView> vw_ItemReconciliationUnionViews { get; set; }

    public virtual DbSet<vw_ItemReconciliationView> vw_ItemReconciliationViews { get; set; }

    public virtual DbSet<vw_JobCardActivityDetail> vw_JobCardActivityDetails { get; set; }

    public virtual DbSet<vw_JobCardActivityDetailRange> vw_JobCardActivityDetailRanges { get; set; }

    public virtual DbSet<vw_JobCardActivityHeader> vw_JobCardActivityHeaders { get; set; }

    public virtual DbSet<vw_JobCardView> vw_JobCardViews { get; set; }

    public virtual DbSet<vw_JournalDetailReconcilation> vw_JournalDetailReconcilations { get; set; }

    public virtual DbSet<vw_JournalDetailTransactionReference> vw_JournalDetailTransactionReferences { get; set; }

    public virtual DbSet<vw_JournalDetailView> vw_JournalDetailViews { get; set; }

    public virtual DbSet<vw_JournalDoubleReference> vw_JournalDoubleReferences { get; set; }

    public virtual DbSet<vw_KDSMultipleQueueView> vw_KDSMultipleQueueViews { get; set; }

    public virtual DbSet<vw_KDSOrderView> vw_KDSOrderViews { get; set; }

    public virtual DbSet<vw_KDSPreparedView> vw_KDSPreparedViews { get; set; }

    public virtual DbSet<vw_LastActivity> vw_LastActivities { get; set; }

    public virtual DbSet<vw_LastActivityArticle> vw_LastActivityArticles { get; set; }

    public virtual DbSet<vw_LastActivityOrganization> vw_LastActivityOrganizations { get; set; }

    public virtual DbSet<vw_LastActivityPerson> vw_LastActivityPeople { get; set; }

    public virtual DbSet<vw_LastActivityWithObjectState> vw_LastActivityWithObjectStates { get; set; }

    public virtual DbSet<vw_LastCareer> vw_LastCareers { get; set; }

    public virtual DbSet<vw_LastPlacement> vw_LastPlacements { get; set; }

    public virtual DbSet<vw_LastPlacementVoucher> vw_LastPlacementVouchers { get; set; }

    public virtual DbSet<vw_LeaveAllocationView> vw_LeaveAllocationViews { get; set; }

    public virtual DbSet<vw_LeaveBalance> vw_LeaveBalances { get; set; }

    public virtual DbSet<vw_LeaveLineItemRef> vw_LeaveLineItemRefs { get; set; }

    public virtual DbSet<vw_LeaveVoucherView> vw_LeaveVoucherViews { get; set; }

    public virtual DbSet<vw_LedgerTransactionsView> vw_LedgerTransactionsViews { get; set; }

    public virtual DbSet<vw_LedgerView> vw_LedgerViews { get; set; }

    public virtual DbSet<vw_LicenseGenerationView> vw_LicenseGenerationViews { get; set; }

    public virtual DbSet<vw_LicenseVoucher> vw_LicenseVouchers { get; set; }

    public virtual DbSet<vw_LifeSpanDetail> vw_LifeSpanDetails { get; set; }

    public virtual DbSet<vw_LineItemActDashboardDetail> vw_LineItemActDashboardDetails { get; set; }

    public virtual DbSet<vw_LineItemActivityDetail> vw_LineItemActivityDetails { get; set; }

    public virtual DbSet<vw_LineItemActivityHeader> vw_LineItemActivityHeaders { get; set; }

    public virtual DbSet<vw_LineItemCategoryView> vw_LineItemCategoryViews { get; set; }

    public virtual DbSet<vw_LineItemClosedJob> vw_LineItemClosedJobs { get; set; }

    public virtual DbSet<vw_LineItemCount> vw_LineItemCounts { get; set; }

    public virtual DbSet<vw_LineItemJournalDetailDatum> vw_LineItemJournalDetailData { get; set; }

    public virtual DbSet<vw_LineItemLifeSpan> vw_LineItemLifeSpans { get; set; }

    public virtual DbSet<vw_LineItemModifier> vw_LineItemModifiers { get; set; }

    public virtual DbSet<vw_LineItemQtySum> vw_LineItemQtySums { get; set; }

    public virtual DbSet<vw_LineItemScheduleView> vw_LineItemScheduleViews { get; set; }

    public virtual DbSet<vw_LineItemSerialCode> vw_LineItemSerialCodes { get; set; }

    public virtual DbSet<vw_LineitemActivityDetailRange> vw_LineitemActivityDetailRanges { get; set; }

    public virtual DbSet<vw_LineitemActivityRange> vw_LineitemActivityRanges { get; set; }

    public virtual DbSet<vw_LineitemActivityRangeInMin> vw_LineitemActivityRangeInMins { get; set; }

    public virtual DbSet<vw_LineitemReferrenceSummary> vw_LineitemReferrenceSummaries { get; set; }

    public virtual DbSet<vw_ListOfOnceReferedVouchersbyUser> vw_ListOfOnceReferedVouchersbyUsers { get; set; }

    public virtual DbSet<vw_ListOfUnReferedVoucher> vw_ListOfUnReferedVouchers { get; set; }

    public virtual DbSet<vw_LogActivity> vw_LogActivities { get; set; }

    public virtual DbSet<vw_LogisticCenter> vw_LogisticCenters { get; set; }

    public virtual DbSet<vw_MailVoucher> vw_MailVouchers { get; set; }

    public virtual DbSet<vw_MemberLogView> vw_MemberLogViews { get; set; }

    public virtual DbSet<vw_MinStockLevel> vw_MinStockLevels { get; set; }

    public virtual DbSet<vw_MobileMovieCompaniesView> vw_MobileMovieCompaniesViews { get; set; }

    public virtual DbSet<vw_MoblieMovieScheduleView> vw_MoblieMovieScheduleViews { get; set; }

    public virtual DbSet<vw_Movie> vw_Movies { get; set; }

    public virtual DbSet<vw_MovieScheduleCountView> vw_MovieScheduleCountViews { get; set; }

    public virtual DbSet<vw_MovieScheduleView> vw_MovieScheduleViews { get; set; }

    public virtual DbSet<vw_MovieTransaction> vw_MovieTransactions { get; set; }

    public virtual DbSet<vw_MovieTransactionDetail> vw_MovieTransactionDetails { get; set; }

    public virtual DbSet<vw_MovieTransactionView> vw_MovieTransactionViews { get; set; }

    public virtual DbSet<vw_MovieView> vw_MovieViews { get; set; }

    public virtual DbSet<vw_MultiCompanyIndustry> vw_MultiCompanyIndustries { get; set; }

    public virtual DbSet<vw_MutliCompanyIndustriesArticleCategory> vw_MutliCompanyIndustriesArticleCategories { get; set; }

    public virtual DbSet<vw_NoCashPayment> vw_NoCashPayments { get; set; }

    public virtual DbSet<vw_NonCashPayment> vw_NonCashPayments { get; set; }

    public virtual DbSet<vw_NonCashPaymentView> vw_NonCashPaymentViews { get; set; }

    public virtual DbSet<vw_NonCashTransaction> vw_NonCashTransactions { get; set; }

    public virtual DbSet<vw_NonCashTransactionView> vw_NonCashTransactionViews { get; set; }

    public virtual DbSet<vw_NonLineItemVoucherHeader> vw_NonLineItemVoucherHeaders { get; set; }

    public virtual DbSet<vw_NonTaxableTransaction> vw_NonTaxableTransactions { get; set; }

    public virtual DbSet<vw_OrgMapper> vw_OrgMappers { get; set; }

    public virtual DbSet<vw_OrgPrefNoCatagory> vw_OrgPrefNoCatagories { get; set; }

    public virtual DbSet<vw_OrgUnitDefView> vw_OrgUnitDefViews { get; set; }

    public virtual DbSet<vw_OrgWithIdentification> vw_OrgWithIdentifications { get; set; }

    public virtual DbSet<vw_OrgaUnitDevice> vw_OrgaUnitDevices { get; set; }

    public virtual DbSet<vw_OrganizationActivity> vw_OrganizationActivities { get; set; }

    public virtual DbSet<vw_OrganizationCity> vw_OrganizationCities { get; set; }

    public virtual DbSet<vw_OrganizationCountry> vw_OrganizationCountries { get; set; }

    public virtual DbSet<vw_OrganizationHeader> vw_OrganizationHeaders { get; set; }

    public virtual DbSet<vw_OrganizationIdentification> vw_OrganizationIdentifications { get; set; }

    public virtual DbSet<vw_OrganizationRelation> vw_OrganizationRelations { get; set; }

    public virtual DbSet<vw_OrganizationStructure> vw_OrganizationStructures { get; set; }

    public virtual DbSet<vw_OrganizationTIN> vw_OrganizationTINs { get; set; }

    public virtual DbSet<vw_OrganizationTelephone> vw_OrganizationTelephones { get; set; }

    public virtual DbSet<vw_OrganizationView> vw_OrganizationViews { get; set; }

    public virtual DbSet<vw_OrganizationWithAccountMap> vw_OrganizationWithAccountMaps { get; set; }

    public virtual DbSet<vw_OrganizationsOwner> vw_OrganizationsOwners { get; set; }

    public virtual DbSet<vw_OtherConsigneeFirst> vw_OtherConsigneeFirsts { get; set; }

    public virtual DbSet<vw_OtherConsigneeSecond> vw_OtherConsigneeSeconds { get; set; }

    public virtual DbSet<vw_OtherConsigneeThird> vw_OtherConsigneeThirds { get; set; }

    public virtual DbSet<vw_OtherConsigneeView> vw_OtherConsigneeViews { get; set; }

    public virtual DbSet<vw_OvertimeDetailView> vw_OvertimeDetailViews { get; set; }

    public virtual DbSet<vw_OvertimeView> vw_OvertimeViews { get; set; }

    public virtual DbSet<vw_POSArticleView> vw_POSArticleViews { get; set; }

    public virtual DbSet<vw_PackageView> vw_PackageViews { get; set; }

    public virtual DbSet<vw_PayrollEmployeeView> vw_PayrollEmployeeViews { get; set; }

    public virtual DbSet<vw_PayrollSlip> vw_PayrollSlips { get; set; }

    public virtual DbSet<vw_PerPrefNoCatagory> vw_PerPrefNoCatagories { get; set; }

    public virtual DbSet<vw_PersionNationalityView> vw_PersionNationalityViews { get; set; }

    public virtual DbSet<vw_Person> vw_People { get; set; }

    public virtual DbSet<vw_PersonActivity> vw_PersonActivities { get; set; }

    public virtual DbSet<vw_PersonDashboard> vw_PersonDashboards { get; set; }

    public virtual DbSet<vw_PersonHeader> vw_PersonHeaders { get; set; }

    public virtual DbSet<vw_PersonTelephone> vw_PersonTelephones { get; set; }

    public virtual DbSet<vw_PersonView> vw_PersonViews { get; set; }

    public virtual DbSet<vw_PersonWithAccountMap> vw_PersonWithAccountMaps { get; set; }

    public virtual DbSet<vw_PersonnelList> vw_PersonnelLists { get; set; }

    public virtual DbSet<vw_Personview1> vw_Personviews1 { get; set; }

    public virtual DbSet<vw_PlacementEmploymentDate> vw_PlacementEmploymentDates { get; set; }

    public virtual DbSet<vw_PlacementTransferView> vw_PlacementTransferViews { get; set; }

    public virtual DbSet<vw_PlacementVoucher> vw_PlacementVouchers { get; set; }

    public virtual DbSet<vw_PlanAndbudget> vw_PlanAndbudgets { get; set; }

    public virtual DbSet<vw_PoliceView> vw_PoliceViews { get; set; }

    public virtual DbSet<vw_PreferenceWithDevice> vw_PreferenceWithDevices { get; set; }

    public virtual DbSet<vw_ProductionReferenceView> vw_ProductionReferenceViews { get; set; }

    public virtual DbSet<vw_ProductionView> vw_ProductionViews { get; set; }

    public virtual DbSet<vw_ProfitabilityReport> vw_ProfitabilityReports { get; set; }

    public virtual DbSet<vw_ProgressTaxRate> vw_ProgressTaxRates { get; set; }

    public virtual DbSet<vw_ProjectReportVoucher> vw_ProjectReportVouchers { get; set; }

    public virtual DbSet<vw_ProjectView> vw_ProjectViews { get; set; }

    public virtual DbSet<vw_ProjectVoucherDetail> vw_ProjectVoucherDetails { get; set; }

    public virtual DbSet<vw_PromotionReportView> vw_PromotionReportViews { get; set; }

    public virtual DbSet<vw_PurchasedArticle> vw_PurchasedArticles { get; set; }

    public virtual DbSet<vw_RMSExtension> vw_RMSExtensions { get; set; }

    public virtual DbSet<vw_RMSHeldView> vw_RMSHeldViews { get; set; }

    public virtual DbSet<vw_RateAdjustment> vw_RateAdjustments { get; set; }

    public virtual DbSet<vw_RateComponent> vw_RateComponents { get; set; }

    public virtual DbSet<vw_RateStrategyView> vw_RateStrategyViews { get; set; }

    public virtual DbSet<vw_ReferenceTreeView> vw_ReferenceTreeViews { get; set; }

    public virtual DbSet<vw_ReferencedVoucherHeader> vw_ReferencedVoucherHeaders { get; set; }

    public virtual DbSet<vw_RefernceObjectState> vw_RefernceObjectStates { get; set; }

    public virtual DbSet<vw_RegistrationDetailView> vw_RegistrationDetailViews { get; set; }

    public virtual DbSet<vw_RegistrationDetailWithMonth> vw_RegistrationDetailWithMonths { get; set; }

    public virtual DbSet<vw_RegistrationDocument> vw_RegistrationDocuments { get; set; }

    public virtual DbSet<vw_RegistrationDocumentView> vw_RegistrationDocumentViews { get; set; }

    public virtual DbSet<vw_RegistrationOperation> vw_RegistrationOperations { get; set; }

    public virtual DbSet<vw_RegistrationTransaction> vw_RegistrationTransactions { get; set; }

    public virtual DbSet<vw_RelationDetail> vw_RelationDetails { get; set; }

    public virtual DbSet<vw_RemovedItem> vw_RemovedItems { get; set; }

    public virtual DbSet<vw_ReportView> vw_ReportViews { get; set; }

    public virtual DbSet<vw_RequiredGSL> vw_RequiredGSLs { get; set; }

    public virtual DbSet<vw_Reservation> vw_Reservations { get; set; }

    public virtual DbSet<vw_ResidentID> vw_ResidentIDs { get; set; }

    public virtual DbSet<vw_RevenuePostView> vw_RevenuePostViews { get; set; }

    public virtual DbSet<vw_RoomDetailView> vw_RoomDetailViews { get; set; }

    public virtual DbSet<vw_RoomFeature> vw_RoomFeatures { get; set; }

    public virtual DbSet<vw_RoomIncome> vw_RoomIncomes { get; set; }

    public virtual DbSet<vw_RouteView> vw_RouteViews { get; set; }

    public virtual DbSet<vw_SEMId> vw_SEMIds { get; set; }

    public virtual DbSet<vw_SEM_IDView> vw_SEM_IDViews { get; set; }

    public virtual DbSet<vw_SRV_GRV> vw_SRV_GRVs { get; set; }

    public virtual DbSet<vw_SalesCoverView> vw_SalesCoverViews { get; set; }

    public virtual DbSet<vw_SalesReportByCategoryAndBrand> vw_SalesReportByCategoryAndBrands { get; set; }

    public virtual DbSet<vw_SalesReportBySupplier> vw_SalesReportBySuppliers { get; set; }

    public virtual DbSet<vw_SalesReportForERCA> vw_SalesReportForERCAs { get; set; }

    public virtual DbSet<vw_Sales_by_Timestamp> vw_Sales_by_Timestamps { get; set; }

    public virtual DbSet<vw_ScheduleValueView> vw_ScheduleValueViews { get; set; }

    public virtual DbSet<vw_SecurityRoleAcessPrevilege> vw_SecurityRoleAcessPrevileges { get; set; }

    public virtual DbSet<vw_SecurityRoleActivityPrevilege> vw_SecurityRoleActivityPrevileges { get; set; }

    public virtual DbSet<vw_SecurityRoleReport> vw_SecurityRoleReports { get; set; }

    public virtual DbSet<vw_SecurityUserRoleMembership> vw_SecurityUserRoleMemberships { get; set; }

    public virtual DbSet<vw_SelectAllMoviesView> vw_SelectAllMoviesViews { get; set; }

    public virtual DbSet<vw_SequencedLastActivity> vw_SequencedLastActivities { get; set; }

    public virtual DbSet<vw_SerialCodeDescription> vw_SerialCodeDescriptions { get; set; }

    public virtual DbSet<vw_SerialCodeLifeSpan> vw_SerialCodeLifeSpans { get; set; }

    public virtual DbSet<vw_ServiceConsignee> vw_ServiceConsignees { get; set; }

    public virtual DbSet<vw_ServiceLineItemExtDetail> vw_ServiceLineItemExtDetails { get; set; }

    public virtual DbSet<vw_ShiftClosing> vw_ShiftClosings { get; set; }

    public virtual DbSet<vw_ShiftClosingVoucherDetail> vw_ShiftClosingVoucherDetails { get; set; }

    public virtual DbSet<vw_SoldArticlesView> vw_SoldArticlesViews { get; set; }

    public virtual DbSet<vw_StoreTransactionView> vw_StoreTransactionViews { get; set; }

    public virtual DbSet<vw_SubscriptionAgingView> vw_SubscriptionAgingViews { get; set; }

    public virtual DbSet<vw_SubscriptionLogView> vw_SubscriptionLogViews { get; set; }

    public virtual DbSet<vw_SummarizedReferenceView> vw_SummarizedReferenceViews { get; set; }

    public virtual DbSet<vw_SummaryOfHRExpense> vw_SummaryOfHRExpenses { get; set; }

    public virtual DbSet<vw_SuspensionView> vw_SuspensionViews { get; set; }

    public virtual DbSet<vw_SyncDistributionView> vw_SyncDistributionViews { get; set; }

    public virtual DbSet<vw_TOT1transaction> vw_TOT1transactions { get; set; }

    public virtual DbSet<vw_TOT2transaction> vw_TOT2transactions { get; set; }

    public virtual DbSet<vw_TaskControlView> vw_TaskControlViews { get; set; }

    public virtual DbSet<vw_TaskFollowUpAndReport> vw_TaskFollowUpAndReports { get; set; }

    public virtual DbSet<vw_TaskFollowUpAndReportWithLineItem> vw_TaskFollowUpAndReportWithLineItems { get; set; }

    public virtual DbSet<vw_TaskIssueDetail> vw_TaskIssueDetails { get; set; }

    public virtual DbSet<vw_TaskVoucherDetail> vw_TaskVoucherDetails { get; set; }

    public virtual DbSet<vw_TaxTransactionView> vw_TaxTransactionViews { get; set; }

    public virtual DbSet<vw_TelephoneAddress> vw_TelephoneAddresses { get; set; }

    public virtual DbSet<vw_TerminatedEmployeeView> vw_TerminatedEmployeeViews { get; set; }

    public virtual DbSet<vw_TerminatedNonClearedEmployee> vw_TerminatedNonClearedEmployees { get; set; }

    public virtual DbSet<vw_TerminatedPayrollHistory> vw_TerminatedPayrollHistories { get; set; }

    public virtual DbSet<vw_TerminationView> vw_TerminationViews { get; set; }

    public virtual DbSet<vw_TimeSheet> vw_TimeSheets { get; set; }

    public virtual DbSet<vw_TotalJobCardTime> vw_TotalJobCardTimes { get; set; }

    public virtual DbSet<vw_TransactionCloudSync> vw_TransactionCloudSyncs { get; set; }

    public virtual DbSet<vw_TravelDetail> vw_TravelDetails { get; set; }

    public virtual DbSet<vw_TravelDetailView> vw_TravelDetailViews { get; set; }

    public virtual DbSet<vw_TrialBalanceView> vw_TrialBalanceViews { get; set; }

    public virtual DbSet<vw_UserRoleWithActivityDefn> vw_UserRoleWithActivityDefns { get; set; }

    public virtual DbSet<vw_UserRoleWithFunctionalityAccessLevel> vw_UserRoleWithFunctionalityAccessLevels { get; set; }

    public virtual DbSet<vw_UserRoleWithReportAccessLevel> vw_UserRoleWithReportAccessLevels { get; set; }

    public virtual DbSet<vw_VATtransaction> vw_VATtransactions { get; set; }

    public virtual DbSet<vw_ValueHistoryView> vw_ValueHistoryViews { get; set; }

    public virtual DbSet<vw_Voucher> vw_Vouchers { get; set; }

    public virtual DbSet<vw_VoucherActivityView> vw_VoucherActivityViews { get; set; }

    public virtual DbSet<vw_VoucherArticle> vw_VoucherArticles { get; set; }

    public virtual DbSet<vw_VoucherBySupplier> vw_VoucherBySuppliers { get; set; }

    public virtual DbSet<vw_VoucherCalculatedValue> vw_VoucherCalculatedValues { get; set; }

    public virtual DbSet<vw_VoucherConsignee> vw_VoucherConsignees { get; set; }

    public virtual DbSet<vw_VoucherCurrencyView> vw_VoucherCurrencyViews { get; set; }

    public virtual DbSet<vw_VoucherCustomer> vw_VoucherCustomers { get; set; }

    public virtual DbSet<vw_VoucherDetailByWaiterName> vw_VoucherDetailByWaiterNames { get; set; }

    public virtual DbSet<vw_VoucherDetailCCRView> vw_VoucherDetailCCRViews { get; set; }

    public virtual DbSet<vw_VoucherDetailDisandAcharge> vw_VoucherDetailDisandAcharges { get; set; }

    public virtual DbSet<vw_VoucherDetailView> vw_VoucherDetailViews { get; set; }

    public virtual DbSet<vw_VoucherDetailViewWithArticle> vw_VoucherDetailViewWithArticles { get; set; }

    public virtual DbSet<vw_VoucherDetailWithPaymentMethod> vw_VoucherDetailWithPaymentMethods { get; set; }

    public virtual DbSet<vw_VoucherDetailWithRoomDetail> vw_VoucherDetailWithRoomDetails { get; set; }

    public virtual DbSet<vw_VoucherDetailWithTransactionReference> vw_VoucherDetailWithTransactionReferences { get; set; }

    public virtual DbSet<vw_VoucherExtensionFirst> vw_VoucherExtensionFirsts { get; set; }

    public virtual DbSet<vw_VoucherExtensionFourth> vw_VoucherExtensionFourths { get; set; }

    public virtual DbSet<vw_VoucherExtensionSecond> vw_VoucherExtensionSeconds { get; set; }

    public virtual DbSet<vw_VoucherExtensionThird> vw_VoucherExtensionThirds { get; set; }

    public virtual DbSet<vw_VoucherExtensionTransactionView> vw_VoucherExtensionTransactionViews { get; set; }

    public virtual DbSet<vw_VoucherHeader> vw_VoucherHeaders { get; set; }

    public virtual DbSet<vw_VoucherHeaderCCRView> vw_VoucherHeaderCCRViews { get; set; }

    public virtual DbSet<vw_VoucherHeaderLight> vw_VoucherHeaderLights { get; set; }

    public virtual DbSet<vw_VoucherHeaderMedium> vw_VoucherHeaderMedia { get; set; }

    public virtual DbSet<vw_VoucherHeaderReferenceView> vw_VoucherHeaderReferenceViews { get; set; }

    public virtual DbSet<vw_VoucherHeaderView> vw_VoucherHeaderViews { get; set; }

    public virtual DbSet<vw_VoucherHeaderViewWithArticle> vw_VoucherHeaderViewWithArticles { get; set; }

    public virtual DbSet<vw_VoucherHeaderViewWithOtherConsignee> vw_VoucherHeaderViewWithOtherConsignees { get; set; }

    public virtual DbSet<vw_VoucherHeaderWithRoomNo> vw_VoucherHeaderWithRoomNos { get; set; }

    public virtual DbSet<vw_VoucherHeaderWithTransactionReference> vw_VoucherHeaderWithTransactionReferences { get; set; }

    public virtual DbSet<vw_VoucherIntegrityView> vw_VoucherIntegrityViews { get; set; }

    public virtual DbSet<vw_VoucherLineItemDetail> vw_VoucherLineItemDetails { get; set; }

    public virtual DbSet<vw_VoucherOrgIdentification> vw_VoucherOrgIdentifications { get; set; }

    public virtual DbSet<vw_VoucherOrganizationView> vw_VoucherOrganizationViews { get; set; }

    public virtual DbSet<vw_VoucherPersonView> vw_VoucherPersonViews { get; set; }

    public virtual DbSet<vw_VoucherReconcilationByArticle> vw_VoucherReconcilationByArticles { get; set; }

    public virtual DbSet<vw_VoucherReferenceSummary> vw_VoucherReferenceSummaries { get; set; }

    public virtual DbSet<vw_VoucherReferenceView> vw_VoucherReferenceViews { get; set; }

    public virtual DbSet<vw_VoucherReferenced> vw_VoucherReferenceds { get; set; }

    public virtual DbSet<vw_VoucherReportDetailView> vw_VoucherReportDetailViews { get; set; }

    public virtual DbSet<vw_VoucherTaxSummaryView> vw_VoucherTaxSummaryViews { get; set; }

    public virtual DbSet<vw_VoucherTaxSummaryWithTransactionReference> vw_VoucherTaxSummaryWithTransactionReferences { get; set; }

    public virtual DbSet<vw_VoucherTaxTransaction> vw_VoucherTaxTransactions { get; set; }

    public virtual DbSet<vw_VoucherTaxTransactionReference> vw_VoucherTaxTransactionReferences { get; set; }

    public virtual DbSet<vw_VoucherTermView> vw_VoucherTermViews { get; set; }

    public virtual DbSet<vw_VoucherTransactionBranch> vw_VoucherTransactionBranches { get; set; }

    public virtual DbSet<vw_VoucherUserNameDetailView> vw_VoucherUserNameDetailViews { get; set; }

    public virtual DbSet<vw_VoucherValuePeriodView> vw_VoucherValuePeriodViews { get; set; }

    public virtual DbSet<vw_VoucherValueSummaryView> vw_VoucherValueSummaryViews { get; set; }

    public virtual DbSet<vw_VoucherWithGrade> vw_VoucherWithGrades { get; set; }

    public virtual DbSet<vw_WaiterEfficencyView> vw_WaiterEfficencyViews { get; set; }

    public virtual DbSet<vw_WithholdingPostView> vw_WithholdingPostViews { get; set; }

    public virtual DbSet<vw_WithholdingTransaction> vw_WithholdingTransactions { get; set; }

    public virtual DbSet<vw_WithholdingView> vw_WithholdingViews { get; set; }

    public virtual DbSet<vw_WorkFlowAndActivity> vw_WorkFlowAndActivities { get; set; }

    public virtual DbSet<vw_WorkFlowByReferenceView> vw_WorkFlowByReferenceViews { get; set; }

    public virtual DbSet<vw_WorkflowKey> vw_WorkflowKeys { get; set; }

    public virtual DbSet<vw_accountMapOrgUnit> vw_accountMapOrgUnits { get; set; }

    public virtual DbSet<vw_accountOrganization> vw_accountOrganizations { get; set; }

    public virtual DbSet<vw_agingIssuedTransactionReference> vw_agingIssuedTransactionReferences { get; set; }

    public virtual DbSet<vw_allAddressView> vw_allAddressViews { get; set; }

    public virtual DbSet<vw_articleWithpreference> vw_articleWithpreferences { get; set; }

    public virtual DbSet<vw_attendanceExceptionDetail> vw_attendanceExceptionDetails { get; set; }

    public virtual DbSet<vw_attendanceModification> vw_attendanceModifications { get; set; }

    public virtual DbSet<vw_attendanceSummary> vw_attendanceSummaries { get; set; }

    public virtual DbSet<vw_bankAccountDetail> vw_bankAccountDetails { get; set; }

    public virtual DbSet<vw_bankBegView> vw_bankBegViews { get; set; }

    public virtual DbSet<vw_bankBeginning> vw_bankBeginnings { get; set; }

    public virtual DbSet<vw_bincardSummaryView> vw_bincardSummaryViews { get; set; }

    public virtual DbSet<vw_branch_view> vw_branch_views { get; set; }

    public virtual DbSet<vw_chartOfAccountDetail> vw_chartOfAccountDetails { get; set; }

    public virtual DbSet<vw_childPrentPreferenceAccountMap> vw_childPrentPreferenceAccountMaps { get; set; }

    public virtual DbSet<vw_companyRating> vw_companyRatings { get; set; }

    public virtual DbSet<vw_configOstate> vw_configOstates { get; set; }

    public virtual DbSet<vw_consolidatedDeliveryDispatchView> vw_consolidatedDeliveryDispatchViews { get; set; }

    public virtual DbSet<vw_consolidatedItemView> vw_consolidatedItemViews { get; set; }

    public virtual DbSet<vw_consolidated_branch_view> vw_consolidated_branch_views { get; set; }

    public virtual DbSet<vw_consolidated_order_noncash_transaction_view> vw_consolidated_order_noncash_transaction_views { get; set; }

    public virtual DbSet<vw_consolidated_product_company_review_view> vw_consolidated_product_company_review_views { get; set; }

    public virtual DbSet<vw_consolidated_sales_noncash_transaction_view> vw_consolidated_sales_noncash_transaction_views { get; set; }

    public virtual DbSet<vw_consolidated_wishlist> vw_consolidated_wishlists { get; set; }

    public virtual DbSet<vw_countryAndCity> vw_countryAndCities { get; set; }

    public virtual DbSet<vw_currentPeriod> vw_currentPeriods { get; set; }

    public virtual DbSet<vw_customer_sales_route> vw_customer_sales_routes { get; set; }

    public virtual DbSet<vw_dailyPackageDetail> vw_dailyPackageDetails { get; set; }

    public virtual DbSet<vw_dailyResidentCategoryView> vw_dailyResidentCategoryViews { get; set; }

    public virtual DbSet<vw_deliveryDispatchView> vw_deliveryDispatchViews { get; set; }

    public virtual DbSet<vw_deliveryOrgUnit> vw_deliveryOrgUnits { get; set; }

    public virtual DbSet<vw_depreciatedView> vw_depreciatedViews { get; set; }

    public virtual DbSet<vw_discrepancy> vw_discrepancies { get; set; }

    public virtual DbSet<vw_displayOrderSingle> vw_displayOrderSingles { get; set; }

    public virtual DbSet<vw_distinctSalesRoute> vw_distinctSalesRoutes { get; set; }

    public virtual DbSet<vw_doorLock> vw_doorLocks { get; set; }

    public virtual DbSet<vw_eCommerce_Items_View> vw_eCommerce_Items_Views { get; set; }

    public virtual DbSet<vw_ePaymentOption> vw_ePaymentOptions { get; set; }

    public virtual DbSet<vw_employeeWorkTime> vw_employeeWorkTimes { get; set; }

    public virtual DbSet<vw_eventHeaderView> vw_eventHeaderViews { get; set; }

    public virtual DbSet<vw_expenseShareView> vw_expenseShareViews { get; set; }

    public virtual DbSet<vw_fsExtensionView> vw_fsExtensionViews { get; set; }

    public virtual DbSet<vw_groupedNonCashTransaction> vw_groupedNonCashTransactions { get; set; }

    public virtual DbSet<vw_invAndCsJournalDetailAccount> vw_invAndCsJournalDetailAccounts { get; set; }

    public virtual DbSet<vw_invJournalVSinvDocument> vw_invJournalVSinvDocuments { get; set; }

    public virtual DbSet<vw_journalDetailLight> vw_journalDetailLights { get; set; }

    public virtual DbSet<vw_journalDetailLineItemView> vw_journalDetailLineItemViews { get; set; }

    public virtual DbSet<vw_journalIncomeAccountSummary> vw_journalIncomeAccountSummaries { get; set; }

    public virtual DbSet<vw_journalIncomeStatementByBranch> vw_journalIncomeStatementByBranches { get; set; }

    public virtual DbSet<vw_journalPostView> vw_journalPostViews { get; set; }

    public virtual DbSet<vw_journalVoucherReference> vw_journalVoucherReferences { get; set; }

    public virtual DbSet<vw_lastPlacementDate> vw_lastPlacementDates { get; set; }

    public virtual DbSet<vw_latestBeginning> vw_latestBeginnings { get; set; }

    public virtual DbSet<vw_latestBeginningCost> vw_latestBeginningCosts { get; set; }

    public virtual DbSet<vw_latestBeginningDetail> vw_latestBeginningDetails { get; set; }

    public virtual DbSet<vw_latestBeginningForWorkingBalance> vw_latestBeginningForWorkingBalances { get; set; }

    public virtual DbSet<vw_ledgerViewByBranch> vw_ledgerViewByBranches { get; set; }

    public virtual DbSet<vw_lineitemPostView> vw_lineitemPostViews { get; set; }

    public virtual DbSet<vw_order_noncash_transaction_view> vw_order_noncash_transaction_views { get; set; }

    public virtual DbSet<vw_orgGP> vw_orgGPs { get; set; }

    public virtual DbSet<vw_packageAuditView> vw_packageAuditViews { get; set; }

    public virtual DbSet<vw_payableReceivablePostView> vw_payableReceivablePostViews { get; set; }

    public virtual DbSet<vw_payrollDefinitionView> vw_payrollDefinitionViews { get; set; }

    public virtual DbSet<vw_payrollSheetView> vw_payrollSheetViews { get; set; }

    public virtual DbSet<vw_payrollTaxView> vw_payrollTaxViews { get; set; }

    public virtual DbSet<vw_payrollVoucherView> vw_payrollVoucherViews { get; set; }

    public virtual DbSet<vw_personGP> vw_personGPs { get; set; }

    public virtual DbSet<vw_personRole> vw_personRoles { get; set; }

    public virtual DbSet<vw_pickupOrgUnit> vw_pickupOrgUnits { get; set; }

    public virtual DbSet<vw_pictureAttachment> vw_pictureAttachments { get; set; }

    public virtual DbSet<vw_placementBranchView> vw_placementBranchViews { get; set; }

    public virtual DbSet<vw_placementDepartmentView> vw_placementDepartmentViews { get; set; }

    public virtual DbSet<vw_placementRoleView> vw_placementRoleViews { get; set; }

    public virtual DbSet<vw_placementView> vw_placementViews { get; set; }

    public virtual DbSet<vw_preparedActivity> vw_preparedActivities { get; set; }

    public virtual DbSet<vw_priceChange> vw_priceChanges { get; set; }

    public virtual DbSet<vw_product_company_review_view> vw_product_company_review_views { get; set; }

    public virtual DbSet<vw_productionProcessView> vw_productionProcessViews { get; set; }

    public virtual DbSet<vw_rating_identification> vw_rating_identifications { get; set; }

    public virtual DbSet<vw_roomManagment> vw_roomManagments { get; set; }

    public virtual DbSet<vw_roomPOSCharge> vw_roomPOSCharges { get; set; }

    public virtual DbSet<vw_routeDetail> vw_routeDetails { get; set; }

    public virtual DbSet<vw_salesDepositView> vw_salesDepositViews { get; set; }

    public virtual DbSet<vw_salesSummary> vw_salesSummaries { get; set; }

    public virtual DbSet<vw_salesSummaryDetailView> vw_salesSummaryDetailViews { get; set; }

    public virtual DbSet<vw_sales_noncash_transaction_view> vw_sales_noncash_transaction_views { get; set; }

    public virtual DbSet<vw_scheduleDetail> vw_scheduleDetails { get; set; }

    public virtual DbSet<vw_serviceRequest> vw_serviceRequests { get; set; }

    public virtual DbSet<vw_sessionDetail> vw_sessionDetails { get; set; }

    public virtual DbSet<vw_sessionShift> vw_sessionShifts { get; set; }

    public virtual DbSet<vw_singleVoucherNote> vw_singleVoucherNotes { get; set; }

    public virtual DbSet<vw_specialStockLedgerVoucher> vw_specialStockLedgerVouchers { get; set; }

    public virtual DbSet<vw_stockConsolidatedUnionView> vw_stockConsolidatedUnionViews { get; set; }

    public virtual DbSet<vw_stockConsolidatedView> vw_stockConsolidatedViews { get; set; }

    public virtual DbSet<vw_stock_balance_activity> vw_stock_balance_activities { get; set; }

    public virtual DbSet<vw_taxPostView> vw_taxPostViews { get; set; }

    public virtual DbSet<vw_transactionRefDetailView> vw_transactionRefDetailViews { get; set; }

    public virtual DbSet<vw_turndown> vw_turndowns { get; set; }

    public virtual DbSet<vw_usersView> vw_usersViews { get; set; }

    public virtual DbSet<vw_voucherDefWithComponent> vw_voucherDefWithComponents { get; set; }

    public virtual DbSet<vw_voucherGP> vw_voucherGPs { get; set; }

    public virtual DbSet<vw_voucherOtherConsgineeFirst> vw_voucherOtherConsgineeFirsts { get; set; }

    public virtual DbSet<vw_wishlist> vw_wishlists { get; set; }

    public virtual DbSet<wacCalculation_view> wacCalculation_views { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DEV-BINIYAM\\CNETPC;User ID=sa;Password=123456;Database=CNET2016;Trusted_Connection=False;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ACLog>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.acDeviceNavigation).WithMany(p => p.ACLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACLog_Device");

            entity.HasOne(d => d.cardNavigation).WithMany(p => p.ACLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACLog_Card");
        });

        modelBuilder.Entity<AccessControlView>(entity =>
        {
            entity.ToView("AccessControlView", "AccessControl");
        });

        modelBuilder.Entity<AccessMatrix>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK_AccessMatrix_1");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.reference).HasComment("Can Be:Lookup (common),Preference (common)");

            entity.HasOne(d => d.referenceNavigation).WithMany(p => p.AccessMatrices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccessMatrix_CNETComponent");

            entity.HasOne(d => d.reference1).WithMany(p => p.AccessMatrices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccessMatrix_Device");

            entity.HasOne(d => d.reference2).WithMany(p => p.AccessMatrices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccessMatrix_Functionality");

            entity.HasOne(d => d.reference3).WithMany(p => p.AccessMatrices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccessMatrix_Report");

            entity.HasOne(d => d.roleNavigation).WithMany(p => p.AccessMatrices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccessMatrix_Preference");
        });

        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.code).HasName("PK_Account_1");

            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.parentAccountNavigation).WithMany(p => p.InverseparentAccountNavigation).HasConstraintName("FK_Account_Account");
        });

        modelBuilder.Entity<AccountAction>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.AccountNavigation).WithMany(p => p.AccountActions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountAction_Account");
        });

        modelBuilder.Entity<AccountMap>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.referenceNavigation).WithMany(p => p.AccountMaps)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountMap_PersonReferene");

            entity.HasOne(d => d.reference1).WithMany(p => p.AccountMaps)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountMap_OrganizationReference");

            entity.HasOne(d => d.reference2).WithMany(p => p.AccountMaps)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountMap_ArticleReference");
        });

        modelBuilder.Entity<Action>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK_Action_1");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.activityDefnNavigation).WithMany(p => p.Actions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Action_ActivityDefinition");
        });

        modelBuilder.Entity<Activity>(entity =>
        {
            entity.HasKey(e => e.code).HasName("PK_Activity_1");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.reference).HasComment("Can Be:Article (common),Organization (common),Person (common),User (common),Voucher (common)");

            entity.HasOne(d => d.activitiyDefinitionNavigation).WithMany(p => p.Activities)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Activity_ActivityDefinition");

            entity.HasOne(d => d.componentNavigation).WithMany(p => p.Activities).HasConstraintName("FK_Activity_CNETComponent");

            entity.HasOne(d => d.deviceNavigation).WithMany(p => p.Activities).HasConstraintName("FK_Activity_Device");

            entity.HasOne(d => d.organizationUnitDefNavigation).WithMany(p => p.Activities).HasConstraintName("FK_Activity_OrganizationUnitDefinition");

            entity.HasOne(d => d.referenceNavigation).WithMany(p => p.Activities)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Activity_Article");

            entity.HasOne(d => d.reference1).WithMany(p => p.Activities)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Activity_Organization");

            entity.HasOne(d => d.reference2).WithMany(p => p.Activities)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Activity_Person");

            entity.HasOne(d => d.reference3).WithMany(p => p.Activities)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Activity_Voucher");

            entity.HasOne(d => d.userNavigation).WithMany(p => p.Activities).HasConstraintName("FK_Activity_User");
        });

        modelBuilder.Entity<ActivityDefination_view>(entity =>
        {
            entity.ToView("ActivityDefination_view", "common");
        });

        modelBuilder.Entity<ActivityDefinition>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.isPrint).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<ActivityPrevilege_view>(entity =>
        {
            entity.ToView("ActivityPrevilege_view", "common");
        });

        modelBuilder.Entity<ActivityView>(entity =>
        {
            entity.ToView("ActivityView", "common");
        });

        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.code).HasName("PK_Address_1");

            entity.ToTable("Address", "common", tb => tb.HasTrigger("addressDeleteTrigger"));

            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.reference).HasComment("Can Be:Organization (common),Person (common),Store (common)");

            entity.HasOne(d => d.preferenceNavigation).WithMany(p => p.Addresses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Address_Preference");

            entity.HasOne(d => d.referenceNavigation).WithMany(p => p.Addresses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Address_Organization");

            entity.HasOne(d => d.reference1).WithMany(p => p.Addresses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Address_Person");
        });

        modelBuilder.Entity<Address_View>(entity =>
        {
            entity.ToView("Address_View", "common");
        });

        modelBuilder.Entity<AllArticleRelatedInfo_View>(entity =>
        {
            entity.ToView("AllArticleRelatedInfo_View", "common");
        });

        modelBuilder.Entity<AllResturantTable>(entity =>
        {
            entity.ToView("AllResturantTables", "pos");
        });

        modelBuilder.Entity<AllVisualControlFunctionality>(entity =>
        {
            entity.ToView("AllVisualControlFunctionalities", "common");
        });

        modelBuilder.Entity<AnswerKey>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.codeNavigation).WithOne(p => p.AnswerKey)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AnswerKey_Question");
        });

        modelBuilder.Entity<AnswerSheet>(entity =>
        {
            entity.Property(e => e.id).IsFixedLength();

            entity.HasOne(d => d.VoucherNavigation).WithMany(p => p.AnswerSheets).HasConstraintName("FK_AnswerSheet_Voucher");

            entity.HasOne(d => d.evaluationSheetNavigation).WithMany(p => p.AnswerSheets).HasConstraintName("FK_AnswerSheet_EvaluationSheet");
        });

        modelBuilder.Entity<Article>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.gslTypeNavigation).WithMany(p => p.Articles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Article_GSLTypeList");

            entity.HasOne(d => d.preferenceNavigation).WithMany(p => p.Articles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Article_Preference");
        });

        modelBuilder.Entity<ArticleBeginningStockView>(entity =>
        {
            entity.ToView("ArticleBeginningStockView", "common");
        });

        modelBuilder.Entity<ArticleComponent>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<ArticleDetail_View>(entity =>
        {
            entity.ToView("ArticleDetail_View", "common");
        });

        modelBuilder.Entity<ArticleModifier>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<ArticleValuesView>(entity =>
        {
            entity.ToView("ArticleValuesView", "common");
        });

        modelBuilder.Entity<Article_View>(entity =>
        {
            entity.ToView("Article_View", "common");
        });

        modelBuilder.Entity<Attachment>(entity =>
        {
            entity.HasKey(e => e.code).HasName("PK_Attachment_1");

            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.reference).HasComment("Can Be:Article (common),Attachment (common),Device (common),Organization (common),Person (common),Preference (common)");

            entity.HasOne(d => d.referenceNavigation).WithMany(p => p.Attachments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Attachment_Article");

            entity.HasOne(d => d.reference1).WithMany(p => p.Attachments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Attachment_Device");

            entity.HasOne(d => d.reference2).WithMany(p => p.Attachments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Attachment_Identification");

            entity.HasOne(d => d.reference3).WithMany(p => p.Attachments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Attachment_Organization");

            entity.HasOne(d => d.reference4).WithMany(p => p.Attachments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Attachment_Person");

            entity.HasOne(d => d.reference5).WithMany(p => p.Attachments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Attachment_Preference");
        });

        modelBuilder.Entity<Attachment_View>(entity =>
        {
            entity.ToView("Attachment_View", "common");
        });

        modelBuilder.Entity<AttendanceAnalysis>(entity =>
        {
            entity.HasKey(e => e.code).HasName("PK_DailyAttendance");

            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.shiftNavigation).WithMany(p => p.AttendanceAnalyses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AttendanceAnalysis_Shift");
        });

        modelBuilder.Entity<AttendanceException>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<AttendanceLog>(entity =>
        {
            entity.HasKey(e => e.code).HasName("PK_Attendance_1");

            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.identificationNavigation).WithMany(p => p.AttendanceLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Attendance_Person");
        });

        modelBuilder.Entity<AvailabilityCalendar>(entity =>
        {
            entity.HasKey(e => e.code).HasName("PK_AvailabilityCalendar_1");

            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<BankAccountDetail>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.reference).HasComment("Can Be: BankAccountDetail (common),Person (common)");

            entity.HasOne(d => d.referenceNavigation).WithMany(p => p.BankAccountDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BankAccountDetail_OrganizationUnit");

            entity.HasOne(d => d.reference1).WithMany(p => p.BankAccountDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BankAccountDetail_Person");
        });

        modelBuilder.Entity<Beginning>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.reference).HasComment("Can Be:Article (common),Device (common),Organization (common),Person (common)");

            entity.HasOne(d => d.periodNavigation).WithMany(p => p.Beginnings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Beginning_Period");

            entity.HasOne(d => d.referenceNavigation).WithMany(p => p.Beginnings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Beginning_Article");

            entity.HasOne(d => d.reference1).WithMany(p => p.Beginnings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Beginning_Organization");

            entity.HasOne(d => d.reference2).WithMany(p => p.Beginnings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Beginning_Person");
        });

        modelBuilder.Entity<BeginningBalance_View>(entity =>
        {
            entity.ToView("BeginningBalance_View", "common");
        });

        modelBuilder.Entity<BeginningTransaction>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<Block>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.registrationHeaderNavigation).WithMany(p => p.Blocks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Block_RegistrationHeader");
        });

        modelBuilder.Entity<Branch>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<CNETComponent>(entity =>
        {
            entity.HasKey(e => e.code).HasName("PK_Component");

            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.parentNavigation).WithMany(p => p.InverseparentNavigation).HasConstraintName("FK_CNETComponent_CNETComponent");
        });

        modelBuilder.Entity<CNETLicense>(entity =>
        {
            entity.HasKey(e => e.code).HasName("PK_License");

            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<CNETMedium>(entity =>
        {
            entity.HasKey(e => e.code).HasName("PK_Media");

            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.articleNavigation).WithMany(p => p.CNETMedia).HasConstraintName("FK_CNETMedia_Article");

            entity.HasOne(d => d.categoryNavigation).WithMany(p => p.CNETMediumcategoryNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CNETMedia_Lookup");

            entity.HasOne(d => d.typeNavigation).WithMany(p => p.CNETMediumtypeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CNETMedia_Lookup1");
        });

        modelBuilder.Entity<CNETPrivacy>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.PrivacyRuleNavigation).WithMany(p => p.CNETPrivacies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CNETPrivacy_Lookup");

            entity.HasOne(d => d.referenceNavigation).WithMany(p => p.CNETPrivacies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CNETPrivacy_Organization");

            entity.HasOne(d => d.reference1).WithMany(p => p.CNETPrivacies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CNETPrivacy_Person");
        });

        modelBuilder.Entity<CNETSystemUpdate>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<CNETVariation>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<CNET_GP>(entity =>
        {
            entity.HasKey(e => e.code).HasName("PK_GPS");

            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.latitude).HasDefaultValueSql("((0.0))");
            entity.Property(e => e.longitude).HasDefaultValueSql("((0.0))");
            entity.Property(e => e.reference).HasComment("Can Be:ModificationHistory (common),OrganizationUnit (common),Person (common),Subcountry (common)");

            entity.HasOne(d => d.referenceNavigation).WithMany(p => p.CNET_GPs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GPS_ModificationHistory");

            entity.HasOne(d => d.reference1).WithMany(p => p.CNET_GPs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GPS_OrganizationUnit");

            entity.HasOne(d => d.reference2).WithMany(p => p.CNET_GPs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GPS_Person");
        });

        modelBuilder.Entity<Card>(entity =>
        {
            entity.HasKey(e => e.code).HasName("PK_Card_1");

            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<CardView>(entity =>
        {
            entity.ToView("CardView", "common");
        });

        modelBuilder.Entity<Career>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<CartTransaction>(entity =>
        {
            entity.HasKey(e => e.code).HasName("PK_CartTransaction_1");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.cartNavigation).WithMany(p => p.CartTransactions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CartTransaction_Preference");

            entity.HasOne(d => d.referenceNavigation).WithMany(p => p.CartTransactions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CartTransaction_Voucher");
        });

        modelBuilder.Entity<CaseDetail>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.causeNavigation).WithMany(p => p.CaseDetailcauseNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CaseDetail_Lookup");

            entity.HasOne(d => d.issueNavigation).WithMany(p => p.CaseDetailissueNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CaseDetail_CaseDetail");

            entity.HasOne(d => d.moduleNavigation).WithMany(p => p.CaseDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CaseDetail_CNETComponent");

            entity.HasOne(d => d.resultNavigation).WithMany(p => p.CaseDetailresultNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CaseDetail_Lookup1");

            entity.HasOne(d => d.solutionNavigation).WithMany(p => p.CaseDetailsolutionNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CaseDetail_Lookup2");

            entity.HasOne(d => d.voucherNavigation).WithMany(p => p.CaseDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CaseDetail_Voucher");
        });

        modelBuilder.Entity<ChargableRegistrationView>(entity =>
        {
            entity.ToView("ChargableRegistrationView", "PMS");
        });

        modelBuilder.Entity<CheckoutDetailView>(entity =>
        {
            entity.ToView("CheckoutDetailView", "PMS");
        });

        modelBuilder.Entity<Choice>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<ClearanceEmployeeView>(entity =>
        {
            entity.ToView("ClearanceEmployeeView", "common");
        });

        modelBuilder.Entity<ClientsLicense>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<ClosedRelation>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.referredVoucherDefnNavigation).WithMany(p => p.ClosedRelationreferredVoucherDefnNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClosedRelation_VoucherDefinition");

            entity.HasOne(d => d.referringVoucherDefnNavigation).WithMany(p => p.ClosedRelationreferringVoucherDefnNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClosedRelation_VoucherDefinition1");

            entity.HasOne(d => d.voucherNavigation).WithMany(p => p.ClosedRelations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClosedRelation_ClosedRelation");
        });

        modelBuilder.Entity<ClosingValidation>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<CloudSync>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<CommunicationSource>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.reference).HasComment("Ca Be:Article (common),Device (common),Organization (common),Person (common)");

            entity.HasOne(d => d.referenceNavigation).WithMany(p => p.CommunicationSources)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CommunicationSource_Article");

            entity.HasOne(d => d.reference1).WithMany(p => p.CommunicationSources)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CommunicationSource_Device");

            entity.HasOne(d => d.reference2).WithMany(p => p.CommunicationSources)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CommunicationSource_Organization");

            entity.HasOne(d => d.reference3).WithMany(p => p.CommunicationSources)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CommunicationSource_Person");
        });

        modelBuilder.Entity<Configuration>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.preference).HasComment("Can be:");
            entity.Property(e => e.reference).HasComment("Can Be:Component (common),Device (common),GSLTypeList (common),Voucher (common)");

            entity.HasOne(d => d.referenceNavigation).WithMany(p => p.Configurations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Configuration_CNETComponent");

            entity.HasOne(d => d.reference1).WithMany(p => p.Configurations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Configuration_Device");

            entity.HasOne(d => d.reference2).WithMany(p => p.Configurations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Configuration_Voucher");
        });

        modelBuilder.Entity<ConsigneeDetail_View>(entity =>
        {
            entity.ToView("ConsigneeDetail_View", "common");
        });

        modelBuilder.Entity<ConsigneeReconciliation_View>(entity =>
        {
            entity.ToView("ConsigneeReconciliation_View", "common");
        });

        modelBuilder.Entity<ControlAccount>(entity =>
        {
            entity.HasKey(e => e.code).HasName("PK_ControlAccount_1");

            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<ControlAccountView>(entity =>
        {
            entity.ToView("ControlAccountView", "common");
        });

        modelBuilder.Entity<ConversionDefinition>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.code).HasName("PK_Country_1");

            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<CreditCardAuthorization>(entity =>
        {
            entity.HasOne(d => d.VoucherNavigation).WithMany(p => p.CreditCardAuthorizations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CreditCardAuthorization_Voucher");
        });

        modelBuilder.Entity<Currency>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.countryNavigation).WithMany(p => p.Currencies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Currency_Country");
        });

        modelBuilder.Entity<CurrencyPreference>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.CurrencyNavigation).WithMany(p => p.CurrencyPreferences)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CurrencyPreference_Currency");

            entity.HasOne(d => d.ReferenceNavigation).WithMany(p => p.CurrencyPreferences)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CurrencyPreference_Article");

            entity.HasOne(d => d.Reference1).WithMany(p => p.CurrencyPreferences)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CurrencyPreference_Organization");

            entity.HasOne(d => d.Reference2).WithMany(p => p.CurrencyPreferences)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CurrencyPreference_Person");
        });

        modelBuilder.Entity<DailyResidentSummary>(entity =>
        {
            entity.HasKey(e => e.code).HasName("PK_DailyResidentSummary_1");

            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<DailyRoomChargePosting_View>(entity =>
        {
            entity.ToView("DailyRoomChargePosting_View", "PMS");
        });

        modelBuilder.Entity<DefaultIndustrialSetting>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.industryNavigation).WithMany(p => p.DefaultIndustrialSettings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DefaultIndustrialSetting_IndustryInvolved");
        });

        modelBuilder.Entity<Delegate>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__Delegate__A25C5AA6992DFD12");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.DelegatedNavigation).WithMany(p => p.DelegateDelegatedNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Delegate_User");

            entity.HasOne(d => d.DelegatingNavigation).WithMany(p => p.DelegateDelegatingNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Delegate_User1");
        });

        modelBuilder.Entity<Denomination>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.currencyNavigation).WithMany(p => p.Denominations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Denomination_Currency");
        });

        modelBuilder.Entity<DenominationDetail>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.transactionCurrencyrefNavigation).WithMany(p => p.DenominationDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DenominationDetail_Voucher");
        });

        modelBuilder.Entity<DepreciationRule>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<Device>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.articleNavigation).WithMany(p => p.Devices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Device_Article");

            entity.HasOne(d => d.connectionTypeNavigation).WithMany(p => p.Devices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Device_Lookup");

            entity.HasOne(d => d.hostNavigation).WithMany(p => p.InversehostNavigation).HasConstraintName("FK_Device_Device1");

            entity.HasOne(d => d.preferenceNavigation).WithMany(p => p.Devices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Device_Preference");
        });

        modelBuilder.Entity<DeviceDetail_View>(entity =>
        {
            entity.ToView("DeviceDetail_View", "common");
        });

        modelBuilder.Entity<DeviceIPParameterView>(entity =>
        {
            entity.ToView("DeviceIPParameterView", "common");
        });

        modelBuilder.Entity<DeviceSchedule>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.DeviceNavigation).WithMany(p => p.DeviceSchedules)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DeviceSchedule_Device");
        });

        modelBuilder.Entity<DeviceView>(entity =>
        {
            entity.ToView("DeviceView", "common");
        });

        modelBuilder.Entity<DiscountFactor>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.ArticleNavigation).WithMany(p => p.DiscountFactors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountFactor_Article");

            entity.HasOne(d => d.ComponentNavigation).WithMany(p => p.DiscountFactors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountFactor_CNETComponent");

            entity.HasOne(d => d.RangeNavigation).WithMany(p => p.DiscountFactors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountFactor_Range");

            entity.HasOne(d => d.ValueFactorDefinitionNavigation).WithMany(p => p.DiscountFactors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountFactor_VFD");
        });

        modelBuilder.Entity<Discrepancy>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.roomDetailNavigation).WithMany(p => p.Discrepancies).HasConstraintName("FK_Descripancy_RoomDetail");
        });

        modelBuilder.Entity<Distribution>(entity =>
        {
            entity.HasKey(e => e.code).HasName("PK_Destination");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.reference).HasComment("Can Be:GSLTypeList (common),VoucherDefinition (common)");

            entity.HasOne(d => d.componentNavigation).WithMany(p => p.Distributions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Distribution_CNETComponent");

            entity.HasOne(d => d.destinationNavigation).WithMany(p => p.Distributions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Distribution_Device");

            entity.HasOne(d => d.destination1).WithMany(p => p.Distributions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Distribution_OrganizationUnit");

            entity.HasOne(d => d.typeNavigation).WithMany(p => p.Distributions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Distribution_Lookup");
        });

        modelBuilder.Entity<DocumentAuditView>(entity =>
        {
            entity.ToView("DocumentAuditView", "common");
        });

        modelBuilder.Entity<EffortConsumption>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.activityNavigation).WithMany(p => p.EffortConsumptions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EffortConsumption_Activity");

            entity.HasOne(d => d.effortTypeNavigation).WithMany(p => p.EffortConsumptions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EffortConsumption_Lookup");
        });

        modelBuilder.Entity<EscalationDetail>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.assignedToNavigation).WithMany(p => p.EscalationDetails).HasConstraintName("FK_EscalationDetail_Person");

            entity.HasOne(d => d.functionalityNavigation).WithMany(p => p.EscalationDetailfunctionalityNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EscalationDetail_Lookup");

            entity.HasOne(d => d.moduleNavigation).WithMany(p => p.EscalationDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EscalationDetail_CNETComponent");

            entity.HasOne(d => d.priorityNavigation).WithMany(p => p.EscalationDetailpriorityNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EscalationDetail_Lookup1");

            entity.HasOne(d => d.voucherNavigation).WithMany(p => p.EscalationDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EscalationDetail_Voucher");
        });

        modelBuilder.Entity<EvaluationSheet>(entity =>
        {
            entity.HasOne(d => d.voucherNavigation).WithMany(p => p.EvaluationSheets).HasConstraintName("FK_EvaluationSheet_Voucher");
        });

        modelBuilder.Entity<EvenetRequiremenet>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.eventDetailNavigation).WithMany(p => p.EvenetRequiremenets).HasConstraintName("FK_EvenetRequiremenet_EventDetail");

            entity.HasOne(d => d.voucherNavigation).WithMany(p => p.EvenetRequiremenets).HasConstraintName("FK_EvenetRequiremenet_Voucher");
        });

        modelBuilder.Entity<EventDetail>(entity =>
        {
            entity.Property(e => e.description).IsFixedLength();
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<ExchangeRate>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.currencyNavigation).WithMany(p => p.ExchangeRates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExchangeRate_Currency");
        });

        modelBuilder.Entity<Face>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.languageNavigation).WithMany(p => p.Faces)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Face_Language");
        });

        modelBuilder.Entity<FieldFormat>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.reference).HasComment("Can Be:GSLTypeList (common),Report (common),Voucher (common)");

            entity.HasOne(d => d.referenceNavigation).WithMany(p => p.FieldFormats)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FieldFormat_Voucher");

            entity.HasOne(d => d.typeNavigation).WithMany(p => p.FieldFormats)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FieldFormat_Lookup");
        });

        modelBuilder.Entity<FieldFormat_View>(entity =>
        {
            entity.ToView("FieldFormat_View", "common");
        });

        modelBuilder.Entity<FiscalExtension>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<FixedAssetInventoryView>(entity =>
        {
            entity.ToView("FixedAssetInventoryView", "common");
        });

        modelBuilder.Entity<Font>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.faceNavigation).WithMany(p => p.Fonts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Font_Face");
        });

        modelBuilder.Entity<FormulationView>(entity =>
        {
            entity.ToView("FormulationView", "common");
        });

        modelBuilder.Entity<Functionality>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.subsystemComponentNavigation).WithMany(p => p.FunctionalitysubsystemComponentNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Functionality_SubSystemComponent");

            entity.HasOne(d => d.visualComponentNavigation).WithMany(p => p.FunctionalityvisualComponentNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Functionality_VisualComponent");
        });

        modelBuilder.Entity<GSLAcctRequirement>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.gslTypeListNavigation).WithMany(p => p.GSLAcctRequirements)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GSLAcctRequirement_GSLTypeList");
        });

        modelBuilder.Entity<GSLAddressMap>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<GSLNote>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<GSLTax>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.reference).HasComment("Can Be:Article (common),Organization (common),Person (common),Tax (common)");

            entity.HasOne(d => d.referenceNavigation).WithMany(p => p.GSLTaxes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GSLTax_Article");

            entity.HasOne(d => d.reference1).WithMany(p => p.GSLTaxes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GSLTax_Organization");

            entity.HasOne(d => d.reference2).WithMany(p => p.GSLTaxes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GSLTax_Person");

            entity.HasOne(d => d.taxNavigation).WithMany(p => p.GSLTaxes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GSLTax_Tax");
        });

        modelBuilder.Entity<GSLTypeList>(entity =>
        {
            entity.HasKey(e => e.code).HasName("PK_GSLTypeList_1");

            entity.Property(e => e.code).ValueGeneratedNever();
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<GSLTypeListView>(entity =>
        {
            entity.ToView("GSLTypeListView", "common");
        });

        modelBuilder.Entity<GSLUser>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.RoleNavigation).WithMany(p => p.GSLUsers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GSLUser_OrganizationUnitDefinition");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.GSLUsers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GSLUser_Lookup");
        });

        modelBuilder.Entity<GetAllOrderStationMapView>(entity =>
        {
            entity.ToView("GetAllOrderStationMapView", "pos");
        });

        modelBuilder.Entity<GetSerialDefAndCodeDetail_View>(entity =>
        {
            entity.ToView("GetSerialDefAndCodeDetail_View", "common");
        });

        modelBuilder.Entity<HKAssignment>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.roomDetailNavigation).WithMany(p => p.HKAssignments).HasConstraintName("FK_HKAssignment_RoomDetail");
        });

        modelBuilder.Entity<HKValue>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<Holiday>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.actualPeriodNavigation).WithMany(p => p.HolidayactualPeriodNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Holiday_Period1");

            entity.HasOne(d => d.forecastedPeriodNavigation).WithMany(p => p.HolidayforecastedPeriodNavigations).HasConstraintName("FK_Holiday_Period");

            entity.HasOne(d => d.holidayDfnNavigation).WithMany(p => p.Holidays)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Holiday_HolidayDefinition");
        });

        modelBuilder.Entity<HolidayDefinition>(entity =>
        {
            entity.HasKey(e => e.code).HasName("PK_HolidayList");

            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.typeNavigation).WithMany(p => p.HolidayDefinitions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HolidayDefinition_Lookup");
        });

        modelBuilder.Entity<Hospitality_DetailReport_View>(entity =>
        {
            entity.ToView("Hospitality_DetailReport_View", "report");
        });

        modelBuilder.Entity<Hospitality_HeaderReport_view>(entity =>
        {
            entity.ToView("Hospitality_HeaderReport_view", "report");
        });

        modelBuilder.Entity<IPParameter>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.deviceNavigation).WithMany(p => p.IPParameters)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IPParameter_Device");
        });

        modelBuilder.Entity<IPTV_VOD_VIEW>(entity =>
        {
            entity.ToView("IPTV_VOD_VIEW", "PMS");
        });

        modelBuilder.Entity<IdDefinationView>(entity =>
        {
            entity.ToView("IdDefinationView", "common");
        });

        modelBuilder.Entity<IdDefinition>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<IdSetting>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.deviceNavigation).WithMany(p => p.IdSettings).HasConstraintName("FK_IdSetting_Device");

            entity.HasOne(d => d.idDefinitionNavigation).WithMany(p => p.IdSettings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IdSetting_IdDefinition");

            entity.HasOne(d => d.organizationUnitNavigation).WithMany(p => p.IdSettings).HasConstraintName("FK_IdSetting_OrganizationUnit");

            entity.HasOne(d => d.referenceNavigation).WithMany(p => p.IdSettings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IdSetting_Article");

            entity.HasOne(d => d.reference1).WithMany(p => p.IdSettings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IdSetting_Organization");

            entity.HasOne(d => d.reference2).WithMany(p => p.IdSettings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IdSetting_Person");
        });

        modelBuilder.Entity<IdSettingAuditView>(entity =>
        {
            entity.ToView("IdSettingAuditView", "common");
        });

        modelBuilder.Entity<IdSettingView>(entity =>
        {
            entity.ToView("IdSettingView", "common");
        });

        modelBuilder.Entity<Identification>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.referenceNavigation).WithMany(p => p.Identifications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Identification_Article");

            entity.HasOne(d => d.reference1).WithMany(p => p.Identifications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Identification_Device");

            entity.HasOne(d => d.reference2).WithMany(p => p.Identifications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Identification_Organization");

            entity.HasOne(d => d.reference3).WithMany(p => p.Identifications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Identification_Person");

            entity.HasOne(d => d.typeNavigation).WithMany(p => p.Identifications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Identification_Lookup");
        });

        modelBuilder.Entity<IndustryInvolved>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.industyNavigation).WithMany(p => p.IndustryInvolvedindustyNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IndustryInvolved_Lookup");

            entity.HasOne(d => d.involvmentNavigation).WithMany(p => p.IndustryInvolvedinvolvmentNavigations).HasConstraintName("FK_IndustryInvolved_Lookup1");

            entity.HasOne(d => d.referenceNavigation).WithMany(p => p.IndustryInvolveds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IndustryInvolved_Article");

            entity.HasOne(d => d.reference1).WithMany(p => p.IndustryInvolveds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IndustryInvolved_Organization");

            entity.HasOne(d => d.reference2).WithMany(p => p.IndustryInvolveds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IndustryInvolved_Person");
        });

        modelBuilder.Entity<IssuedCared>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.cardNavigation).WithMany(p => p.IssuedCareds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IssuedCared_Card");

            entity.HasOne(d => d.componentNavigation).WithMany(p => p.IssuedCareds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IssuedCared_Organization");

            entity.HasOne(d => d.referenceNavigation).WithMany(p => p.IssuedCareds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IssuedCared_Person");
        });

        modelBuilder.Entity<JobDescription>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<JournalAuditDetailView>(entity =>
        {
            entity.ToView("JournalAuditDetailView", "common");
        });

        modelBuilder.Entity<JournalDetail>(entity =>
        {
            entity.HasKey(e => e.code).HasName("PK_JournalDetail_1");

            entity.ToTable("JournalDetail", "common", tb => tb.HasTrigger("Prevent_Update_JournalDetail_Trigger"));

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.voucherNavigation).WithMany(p => p.JournalDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JournalDetail_Voucher");
        });

        modelBuilder.Entity<JournalDetailReconcilation>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.journalDetailNavigation).WithMany(p => p.JournalDetailReconcilations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JournalDetailReconcilation_JournalDetail");
        });

        modelBuilder.Entity<JournalDetailView>(entity =>
        {
            entity.ToView("JournalDetailView", "common");
        });

        modelBuilder.Entity<JournalReferenceAuditView>(entity =>
        {
            entity.ToView("JournalReferenceAuditView", "common");
        });

        modelBuilder.Entity<KeyDefinition>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.spaceNavigation).WithMany(p => p.KeyDefinitions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KeyDefinition_Space");
        });

        modelBuilder.Entity<KeyOption>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.keyDefinitionNavigation).WithMany(p => p.KeyOptions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KeyOption_KeyDefinition");

            entity.HasOne(d => d.roomDetailNavigation).WithMany(p => p.KeyOptions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KeyOption_RoomDetail");
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.typeNavigation).WithMany(p => p.Languages)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Language_Lookup");
        });

        modelBuilder.Entity<LanguageOfInterest>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.languageNavigation).WithMany(p => p.LanguageOfInterests)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LanguageOfInterest_Language");

            entity.HasOne(d => d.personNavigation).WithMany(p => p.LanguageOfInterests)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LanguageOfInterest_Person");
        });

        modelBuilder.Entity<LifeSpan>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.componentNavigation).WithMany(p => p.LifeSpans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LifeSpan_CNETComponent");
        });

        modelBuilder.Entity<Lifetime>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.factorNavigation).WithMany(p => p.Lifetimes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Lifetime_Lookup");

            entity.HasOne(d => d.referenceNavigation).WithMany(p => p.Lifetimes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Lifetime_Article");

            entity.HasOne(d => d.reference1).WithMany(p => p.Lifetimes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Lifetime_Organization");

            entity.HasOne(d => d.reference2).WithMany(p => p.Lifetimes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Lifetime_Person");
        });

        modelBuilder.Entity<LineItem>(entity =>
        {
            entity.ToTable("LineItem", "common", tb => tb.HasTrigger("Prevent_Update_LineItem_Trigger"));

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.UOMNavigation).WithMany(p => p.LineItems).HasConstraintName("FK_LineItem_Lookup");

            entity.HasOne(d => d.articleNavigation).WithMany(p => p.LineItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LineItem_Article");

            entity.HasOne(d => d.taxNavigation).WithMany(p => p.LineItems).HasConstraintName("FK_LineItem_Tax");

            entity.HasOne(d => d.voucherNavigation).WithMany(p => p.LineItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LineItem_Voucher");
        });

        modelBuilder.Entity<LineItemConversion>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.lineItemNavigation).WithMany(p => p.LineItemConversions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LineItemConversion_LineItem");
        });

        modelBuilder.Entity<LineItemConversionLookup>(entity =>
        {
            entity.ToView("LineItemConversionLookup", "common");
        });

        modelBuilder.Entity<LineItemDetail_View>(entity =>
        {
            entity.ToView("LineItemDetail_View", "common");
        });

        modelBuilder.Entity<LineItemExtension>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.lineitemNavigation).WithMany(p => p.LineItemExtensions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LineItemExtension_LineItem");

            entity.HasOne(d => d.voucherExtensionNavigation).WithMany(p => p.LineItemExtensions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LineItemExtension_VoucherExtension");
        });

        modelBuilder.Entity<LineItemModfier>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.LineItemNavigation).WithMany(p => p.LineItemModfiers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LineItemModfier_LineItem");

            entity.HasOne(d => d.articleModfierNavigation).WithMany(p => p.LineItemModfiers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LineItemModfier_LineItemModfier");
        });

        modelBuilder.Entity<LineItemNote>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.lineItemNavigation).WithMany(p => p.LineItemNotes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LineItemNote_LineItem");
        });

        modelBuilder.Entity<LineItemReference>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.lineItemNavigation).WithMany(p => p.LineItemReferencelineItemNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LineItemReference_LineItem1");

            entity.HasOne(d => d.referencedNavigation).WithMany(p => p.LineItemReferencereferencedNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LineItemReference_LineItem");

            entity.HasOne(d => d.referingVouDfnNavigation).WithMany(p => p.LineItemReferences)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LineItemReference_VoucherDefinition");
        });

        modelBuilder.Entity<LineItemSeatAndState>(entity =>
        {
            entity.HasOne(d => d.lineitemNavigation).WithMany(p => p.LineItemSeatAndStates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LineItemSeatAndState_LineItem");
        });

        modelBuilder.Entity<LineItemValueFactor>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.lineItemNavigation).WithMany(p => p.LineItemValueFactors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LineItemValueFactor_LineItem");
        });

        modelBuilder.Entity<LineitemWeight>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.lineitemNavigation).WithMany(p => p.LineitemWeights).HasConstraintName("FK_LineitemWeight_LineItem");
        });

        modelBuilder.Entity<ListOfWaiterView>(entity =>
        {
            entity.ToView("ListOfWaiterView", "pos");
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Space).WithMany(p => p.Locations).HasConstraintName("FK_Location_Space");

            entity.HasOne(d => d.gslTypeNavigation).WithMany(p => p.Locations).HasConstraintName("FK_Location_Location");

            entity.HasOne(d => d.referenceNavigation).WithMany(p => p.Locations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Location_Article");

            entity.HasOne(d => d.typeNavigation).WithMany(p => p.Locations).HasConstraintName("FK_Location_Lookup");
        });

        modelBuilder.Entity<Location_View>(entity =>
        {
            entity.ToView("Location_View", "common");
        });

        modelBuilder.Entity<Log>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.activityNavigation).WithMany(p => p.Logs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Log_Activity");
        });

        modelBuilder.Entity<Log_View>(entity =>
        {
            entity.ToView("Log_View", "common");
        });

        modelBuilder.Entity<Lookup>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<MTDView>(entity =>
        {
            entity.ToView("MTDView", "hrms");
        });

        modelBuilder.Entity<Mail>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.voucherNavigation).WithMany(p => p.Mail)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Mail_Voucher");
        });

        modelBuilder.Entity<Media_View>(entity =>
        {
            entity.ToView("Media_View", "PMS");
        });

        modelBuilder.Entity<MenuDesigner>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.componentNavigation).WithMany(p => p.MenuDesigners)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MenuDesigner_CNETComponent");

            entity.HasOne(d => d.fifthMenuNavigation).WithMany(p => p.MenuDesignerfifthMenuNavigations).HasConstraintName("FK_MenuDesigner_Preference5");

            entity.HasOne(d => d.firstMenuNavigation).WithMany(p => p.MenuDesignerfirstMenuNavigations).HasConstraintName("FK_MenuDesigner_Preference1");

            entity.HasOne(d => d.fourthMenuNavigation).WithMany(p => p.MenuDesignerfourthMenuNavigations).HasConstraintName("FK_MenuDesigner_Preference4");

            entity.HasOne(d => d.secondMenuNavigation).WithMany(p => p.MenuDesignersecondMenuNavigations).HasConstraintName("FK_MenuDesigner_Preference2");

            entity.HasOne(d => d.sixthMenuNavigation).WithMany(p => p.MenuDesignersixthMenuNavigations).HasConstraintName("FK_MenuDesigner_Preference");

            entity.HasOne(d => d.thirdMenuNavigation).WithMany(p => p.MenuDesignerthirdMenuNavigations).HasConstraintName("FK_MenuDesigner_Preference3");
        });

        modelBuilder.Entity<Message_View>(entity =>
        {
            entity.ToView("Message_View", "PMS");
        });

        modelBuilder.Entity<MobileTransaction>(entity =>
        {
            entity.HasKey(e => e.code).HasName("PK_CBETransaction");

            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<ModificationHistory>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.activityNavigation).WithMany(p => p.ModificationHistories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ModificationHistory_Activity");
        });

        modelBuilder.Entity<ModificationHistory_VIEW>(entity =>
        {
            entity.ToView("ModificationHistory_VIEW", "common");
        });

        modelBuilder.Entity<ModificationLogview>(entity =>
        {
            entity.ToView("ModificationLogview", "common");
        });

        modelBuilder.Entity<Movie>(entity =>
        {
            entity.HasKey(e => e.code).HasName("PK_Movies");

            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.mediaNavigation).WithMany(p => p.Movies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Movies_CNETMedia");
        });

        modelBuilder.Entity<MovieSchedule>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<MultiOrganization>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.componentNavigation).WithMany(p => p.MultiOrganizations).HasConstraintName("FK_MultiOrganization_CNETComponent");
        });

        modelBuilder.Entity<NegotiatedRate>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.consigneeNavigation).WithMany(p => p.NegotiatedRates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NegotiatedRate_Organization");

            entity.HasOne(d => d.consignee1).WithMany(p => p.NegotiatedRates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NegotiatedRate_Person");

            entity.HasOne(d => d.rateCodeNavigation).WithMany(p => p.NegotiatedRates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NegotiatedRate_RateCodeHeader");
        });

        modelBuilder.Entity<NonCashDeposit>(entity =>
        {
            entity.ToView("NonCashDeposit", "common");
        });

        modelBuilder.Entity<NonCashTransaction>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.consigneeNavigation).WithMany(p => p.NonCashTransactionconsigneeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NonCashTransaction_Organization");

            entity.HasOne(d => d.consignee1).WithMany(p => p.NonCashTransactions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NonCashTransaction_OrganizationUnit");

            entity.HasOne(d => d.consignee2).WithMany(p => p.NonCashTransactions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NonCashTransaction_Person");

            entity.HasOne(d => d.currencyCodeNavigation).WithMany(p => p.NonCashTransactions).HasConstraintName("FK_NonCashTransaction_Currency");

            entity.HasOne(d => d.paymentMethodNavigation).WithMany(p => p.NonCashTransactions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NonCashTransaction_Lookup");

            entity.HasOne(d => d.paymentProcesserNavigation).WithMany(p => p.NonCashTransactionpaymentProcesserNavigations).HasConstraintName("FK_NonCashTransaction_PaymentProcessor");

            entity.HasOne(d => d.voucherNavigation).WithMany(p => p.NonCashTransactions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NonCashTransaction_Voucher");
        });

        modelBuilder.Entity<NonCashTransaction_View>(entity =>
        {
            entity.ToView("NonCashTransaction_View", "common");
        });

        modelBuilder.Entity<ObjectState>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.referenceNavigation).WithMany(p => p.ObjectStates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ObjectState_Article");

            entity.HasOne(d => d.reference1).WithMany(p => p.ObjectStates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ObjectState_Organization");

            entity.HasOne(d => d.reference2).WithMany(p => p.ObjectStates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ObjectState_Person");

            entity.HasOne(d => d.reference3).WithMany(p => p.ObjectStates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ObjectState_Vouchers");
        });

        modelBuilder.Entity<ObjectStateDefinition>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<ObjectStateView>(entity =>
        {
            entity.ToView("ObjectStateView", "common");
        });

        modelBuilder.Entity<OptionalCode>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.articleNavigation).WithMany(p => p.OptionalCodes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OptionalCode_Article");

            entity.HasOne(d => d.article1).WithMany(p => p.OptionalCodes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OptionalCode_Organization");

            entity.HasOne(d => d.article2).WithMany(p => p.OptionalCodes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OptionalCode_Person");
        });

        modelBuilder.Entity<OrderStationMap>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.posDeviceNavigation).WithMany(p => p.OrderStationMapposDeviceNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderStationMap_Device");

            entity.HasOne(d => d.preferenceNavigation).WithMany(p => p.OrderStationMaps)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Preference_OrderStationMap");

            entity.HasOne(d => d.stationDeviceNavigation).WithMany(p => p.OrderStationMapstationDeviceNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderStationMap_Device1");
        });

        modelBuilder.Entity<Organization>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.preferenceNavigation).WithMany(p => p.Organizations).HasConstraintName("FK_Organization_Preference");

            entity.HasOne(d => d.typeNavigation).WithMany(p => p.Organizations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Organization_GSLTypeList");
        });

        modelBuilder.Entity<OrganizationUnit>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.organizationUnitDefinitionNavigation).WithMany(p => p.OrganizationUnits)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrganizationUnit_OrganizationUnitDefinition");

            entity.HasOne(d => d.referenceNavigation).WithMany(p => p.OrganizationUnits)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrganizationUnit_Organization");
        });

        modelBuilder.Entity<OrganizationUnitDefinition>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.typeNavigation).WithMany(p => p.OrganizationUnitDefinitions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrganizationUnitDefinition_Lookup");
        });

        modelBuilder.Entity<Organization_Region_Town_View>(entity =>
        {
            entity.ToView("Organization_Region_Town_View", "common");
        });

        modelBuilder.Entity<Organization_View>(entity =>
        {
            entity.ToView("Organization_View", "common");
        });

        modelBuilder.Entity<OtherConsignee>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.consigneeNavigation).WithMany(p => p.OtherConsignees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OtherConsignees_Organization");

            entity.HasOne(d => d.consignee1).WithMany(p => p.OtherConsignees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OtherConsignees_Person");

            entity.HasOne(d => d.requiredGSLNavigation).WithMany(p => p.OtherConsignees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OtherConsignees_RequriedGSL");

            entity.HasOne(d => d.voucherNavigation).WithMany(p => p.OtherConsignees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OtherConsignees_Voucher");
        });

        modelBuilder.Entity<POS_Artticle_View>(entity =>
        {
            entity.ToView("POS_Artticle_View", "pos");
        });

        modelBuilder.Entity<PREMIUM_RMS_Bills_View>(entity =>
        {
            entity.ToView("PREMIUM_RMS_Bills_View", "pos");
        });

        modelBuilder.Entity<PackageDetail>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.packageNavigation).WithMany(p => p.PackageDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PackageDetail_Package");
        });

        modelBuilder.Entity<PackageHeader>(entity =>
        {
            entity.HasKey(e => e.code).HasName("PK_Package");

            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.articleNavigation).WithMany(p => p.PackageHeaders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Package_Article");

            entity.HasOne(d => d.calculationRuleNavigation).WithMany(p => p.PackageHeadercalculationRuleNavigations).HasConstraintName("FK_Package_LookupCalculateRule");

            entity.HasOne(d => d.currencyPreferenceNavigation).WithMany(p => p.PackageHeaders).HasConstraintName("FK_Package_Curency");

            entity.HasOne(d => d.pakgGroupNavigation).WithMany(p => p.PackageHeaderpakgGroupNavigations).HasConstraintName("FK_Package_LookupPackageGroup");

            entity.HasOne(d => d.postingRhythmNavigation).WithMany(p => p.PackageHeaderpostingRhythmNavigations).HasConstraintName("FK_Package_LookupPostingRythm");

            entity.HasOne(d => d.rateApearanceNavigation).WithMany(p => p.PackageHeaderrateApearanceNavigations).HasConstraintName("FK_Package_LookupRateApperance");

            entity.HasOne(d => d.typeNavigation).WithMany(p => p.PackageHeadertypeNavigations).HasConstraintName("FK_PackageHeader_Lookup");
        });

        modelBuilder.Entity<PackageToPost_View>(entity =>
        {
            entity.ToView("PackageToPost_View", "PMS");
        });

        modelBuilder.Entity<PackagesToPost>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.packageHeaderNavigation).WithMany(p => p.PackagesToPosts).HasConstraintName("FK_PackagesToPost_PackageHeader");

            entity.HasOne(d => d.registrationDetailNavigation).WithMany(p => p.PackagesToPosts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PackagesToPost_RegistrationDetail");
        });

        modelBuilder.Entity<PaymentSchedule>(entity =>
        {
            entity.HasKey(e => e.code).HasName("PK_paymentSchedule");

            entity.Property(e => e.ID).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<Period>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.typeNavigation).WithMany(p => p.Periods)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Period_Lookup");
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newsequentialid())");

            entity.HasOne(d => d.preferenceNavigation).WithMany(p => p.People).HasConstraintName("FK_Person_Preference");

            entity.HasOne(d => d.typeNavigation).WithMany(p => p.People)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Person_GSLTypeList");
        });

        modelBuilder.Entity<PersonOrganization_View>(entity =>
        {
            entity.ToView("PersonOrganization_View", "common");
        });

        modelBuilder.Entity<Person_View>(entity =>
        {
            entity.ToView("Person_View", "common");
        });

        modelBuilder.Entity<PhysicalDimension>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.articleNavigation).WithMany(p => p.PhysicalDimensions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhysicalDimension_Article");
        });

        modelBuilder.Entity<Plan>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.periodNavigation).WithMany(p => p.Plans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Plan_Period");

            entity.HasOne(d => d.ratingNavigation).WithMany(p => p.PlanratingNavigations).HasConstraintName("FK_Plan_Lookup1");

            entity.HasOne(d => d.typeNavigation).WithMany(p => p.PlantypeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Plan_Lookup");
        });

        modelBuilder.Entity<PlanDetail>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.planNavigation).WithMany(p => p.PlanDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PlanDetail_Plan");
        });

        modelBuilder.Entity<PostingRoutineDetail>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.postingRoutineHeaderNavigation).WithMany(p => p.PostingRoutineDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PostingRoutineDetail_PostingRoutineDetail");

            entity.HasOne(d => d.voucherDefNavigation).WithMany(p => p.PostingRoutineDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PostingRoutineDetail_VoucherDefinition");
        });

        modelBuilder.Entity<PostingRoutineHeader>(entity =>
        {
            entity.HasKey(e => e.code).HasName("PK_PostingRootingHeader");

            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.componentNavigation).WithMany(p => p.PostingRoutineHeaders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PostingRoutineHeader_CNETComponent");
        });

        modelBuilder.Entity<PostingSchedule>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.packageHeaderNavigation).WithMany(p => p.PostingSchedules)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PostingSchedule_Package");
        });

        modelBuilder.Entity<PreferedOrganizationList_View>(entity =>
        {
            entity.ToView("PreferedOrganizationList_View", "common");
        });

        modelBuilder.Entity<Preference>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<PreferenceAccess>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.deviceNavigation).WithMany(p => p.PreferenceAccesses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PreferenceAccess_Device");

            entity.HasOne(d => d.preferenceNavigation).WithMany(p => p.PreferenceAccesses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PreferenceAccess_Preference");

            entity.HasOne(d => d.voucherDefnNavigation).WithMany(p => p.PreferenceAccesses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PreferenceAccess_VoucherDefinition");
        });

        modelBuilder.Entity<PreferenceValueFactor>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.preferenceNavigation).WithMany(p => p.PreferenceValueFactors).HasConstraintName("FK_PreferenceValueFactor_Preference");

            entity.HasOne(d => d.valueFactorDefinitionNavigation).WithMany(p => p.PreferenceValueFactors).HasConstraintName("FK_PreferenceValueFactor_PreferenceValueFactor1");

            entity.HasOne(d => d.voucherNavigation).WithMany(p => p.PreferenceValueFactors).HasConstraintName("FK_PreferenceValueFactor_PreferenceValueFactor");
        });

        modelBuilder.Entity<PreferenceView>(entity =>
        {
            entity.ToView("PreferenceView", "common");
        });

        modelBuilder.Entity<Preference_Attachment_View>(entity =>
        {
            entity.ToView("Preference_Attachment_View", "pos");
        });

        modelBuilder.Entity<Process>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.categoryNavigation).WithMany(p => p.ProcesscategoryNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Process_Lookup1");

            entity.HasOne(d => d.typeNavigation).WithMany(p => p.ProcesstypeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Process_Lookup");
        });

        modelBuilder.Entity<ProcessTaskMap>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.alertTypeNavigation).WithMany(p => p.ProcessTaskMaps)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProcessTaskMap_Lookup");

            entity.HasOne(d => d.processNavigation).WithMany(p => p.ProcessTaskMaps)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProcessTaskMap_Process");

            entity.HasOne(d => d.scheduleHeaderNavigation).WithMany(p => p.ProcessTaskMaps)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProcessTaskMap_ScheduleHeader");
        });

        modelBuilder.Entity<ProductExtension>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.articleNavigation).WithMany(p => p.ProductExtensions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductExtension_Article");
        });

        modelBuilder.Entity<ProgressTaxRate>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasKey(e => e.code).HasName("PK_Project_1");

            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<ProjectTimeRequirment>(entity =>
        {
            entity.Property(e => e.ID).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<PromotionView>(entity =>
        {
            entity.ToView("PromotionView", "common");
        });

        modelBuilder.Entity<QCTest>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.activityNavigation).WithMany(p => p.QCTests)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QCTest_Activity");
        });

        modelBuilder.Entity<Question>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<RMSExtension>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<Range>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<Rate>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.rateCodeNavigation).WithMany(p => p.Rates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Rate_RateCode");
        });

        modelBuilder.Entity<RateAdjustment>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<RateCategory>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.parentNavigation).WithMany(p => p.InverseparentNavigation).HasConstraintName("FK_RateCategory_RateCategory");
        });

        modelBuilder.Entity<RateCategoryRateStrategy>(entity =>
        {
            entity.HasOne(d => d.rateCategoryNavigation).WithMany(p => p.RateCategoryRateStrategies).HasConstraintName("FK_RateCategoryRateStrategy_RateCategory");

            entity.HasOne(d => d.rateStrategyNavigation).WithMany(p => p.RateCategoryRateStrategies).HasConstraintName("FK_RateCategoryRateStrategy_RateStrategy");
        });

        modelBuilder.Entity<RateCodeCategoryCurrency_View>(entity =>
        {
            entity.ToView("RateCodeCategoryCurrency_View", "common");
        });

        modelBuilder.Entity<RateCodeDetail>(entity =>
        {
            entity.HasKey(e => e.code).HasName("PK_RateCodeDetail_1");

            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.rateCodeHeaderNavigation).WithMany(p => p.RateCodeDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RateCodeDetail_RateCodeHeader");

            entity.HasOne(d => d.stayDurationNavigation).WithMany(p => p.RateCodeDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RateCodeDetail_Range");
        });

        modelBuilder.Entity<RateCodeDetailGuestCount>(entity =>
        {
            entity.HasKey(e => e.code).HasName("PK_RateCodeDetailGuestCount_1");

            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.rateCodeDetailNavigation).WithMany(p => p.RateCodeDetailGuestCounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RateCodeDetailGuestCount_RateCodeDetail");
        });

        modelBuilder.Entity<RateCodeDetailRoomType>(entity =>
        {
            entity.HasKey(e => e.code).HasName("PK_RateCodeDetailRoomType_1");

            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.rateCodeDetailNavigation).WithMany(p => p.RateCodeDetailRoomTypes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RateCodeDetailRoomType_RateCodeDetail");

            entity.HasOne(d => d.roomTypeNavigation).WithMany(p => p.RateCodeDetailRoomTypes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RateCodeDetailRoomType_RoomType");
        });

        modelBuilder.Entity<RateCodeHeader>(entity =>
        {
            entity.HasKey(e => e.code).HasName("PK_RateCode");

            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<RateCodePackage>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.packageHeaderNavigation).WithMany(p => p.RateCodePackages)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RateCodePackages_PackageHeader");

            entity.HasOne(d => d.rateCodeHeaderNavigation).WithMany(p => p.RateCodePackages)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RateCodePackages_RateCodeHeader");
        });

        modelBuilder.Entity<RateCodeRateStrategy>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.rateCodeNavigation).WithMany(p => p.RateCodeRateStrategies).HasConstraintName("FK_RateCodeRateStrategy_RateCode");

            entity.HasOne(d => d.rateStrategyNavigation).WithMany(p => p.RateCodeRateStrategies).HasConstraintName("FK_RateCodeRateStrategy_RateStrategy");
        });

        modelBuilder.Entity<RateCodeRoomType>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.rateCodeNavigation).WithMany(p => p.RateCodeRoomTypes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RateCodeRoomTypes_RateCodeRoomTypes");

            entity.HasOne(d => d.roomTypeNavigation).WithMany(p => p.RateCodeRoomTypes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RateCodeRoomTypes_RoomType");
        });

        modelBuilder.Entity<RateComponent>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.componentNavigation).WithMany(p => p.RateComponents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RateComponents_Lookup");

            entity.HasOne(d => d.rateCodeNavigation).WithMany(p => p.RateComponents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RateComponents_RateCode");
        });

        modelBuilder.Entity<RateDetailRoomTypeWeek_View>(entity =>
        {
            entity.ToView("RateDetailRoomTypeWeek_View", "PMS");
        });

        modelBuilder.Entity<RateDetailRoomType_View>(entity =>
        {
            entity.ToView("RateDetailRoomType_View", "PMS");
        });

        modelBuilder.Entity<RatePackage>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.packageNavigation).WithMany(p => p.RatePackages)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RatePackages_PackageHeader");

            entity.HasOne(d => d.rateCodeNavigation).WithMany(p => p.RatePackages)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RatePackages_RateCode");
        });

        modelBuilder.Entity<RatePackage_View>(entity =>
        {
            entity.ToView("RatePackage_View", "PMS");
        });

        modelBuilder.Entity<RateQuery_View>(entity =>
        {
            entity.ToView("RateQuery_View", "PMS");
        });

        modelBuilder.Entity<RateStrategy>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<ReconciliationDetail>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.reconSumNavigation).WithMany(p => p.ReconciliationDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReconciliationDetail_ReconciliationSummary");

            entity.HasOne(d => d.voucherDefnitionNavigation).WithMany(p => p.ReconciliationDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReconciliationDetail_VoucherDefinition");
        });

        modelBuilder.Entity<ReconciliationDetailView>(entity =>
        {
            entity.ToView("ReconciliationDetailView", "common");
        });

        modelBuilder.Entity<ReconciliationSummary>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.comparisionNavigation).WithMany(p => p.ReconciliationSummarycomparisionNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReconciliationSummary_Lookup1");

            entity.HasOne(d => d.comparisionTypeNavigation).WithMany(p => p.ReconciliationSummarycomparisionTypeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReconciliationSummary_Lookup");
        });

        modelBuilder.Entity<ReconciliationSummaryView>(entity =>
        {
            entity.ToView("ReconciliationSummaryView", "common");
        });

        modelBuilder.Entity<RegionalDetail>(entity =>
        {
            entity.HasOne(d => d.RegionNavigation).WithMany(p => p.RegionalDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RegionalDetail_Lookup");
        });

        modelBuilder.Entity<RegistrationDetail>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.rateCodeDetailNavigation).WithMany(p => p.RegistrationDetails).HasConstraintName("FK_RegistrationDetail_RateCodeDetail");

            entity.HasOne(d => d.voucherNavigation).WithMany(p => p.RegistrationDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RegistrationDetail_Voucher");
        });

        modelBuilder.Entity<RegistrationExtension>(entity =>
        {
            entity.HasKey(e => e.code).HasName("PK_Registration");

            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.SpecialsNavigation).WithMany(p => p.RegistrationExtensionSpecialsNavigations).HasConstraintName("FK_RegistrationHeader_Lookup2");

            entity.HasOne(d => d.paymentTypeNavigation).WithMany(p => p.RegistrationExtensionpaymentTypeNavigations).HasConstraintName("FK_RegistrationHeader_Lookup");

            entity.HasOne(d => d.resTypeNavigation).WithMany(p => p.RegistrationExtensionresTypeNavigations).HasConstraintName("FK_RegistrationHeader_Lookup1");

            entity.HasOne(d => d.voucherNavigation).WithMany(p => p.RegistrationExtensions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Registration_Voucher");
        });

        modelBuilder.Entity<RegistrationPrivllege>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.voucherNavigation).WithMany(p => p.RegistrationPrivlleges)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RegistrationPrivllege_Voucher");
        });

        modelBuilder.Entity<Relation>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.referenceObjectNavigation).WithMany(p => p.Relations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Relation_Article");

            entity.HasOne(d => d.referenceObject1).WithMany(p => p.Relations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Relation_Organization");

            entity.HasOne(d => d.referenceObject2).WithMany(p => p.Relations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Relation_Person");

            entity.HasOne(d => d.referenceObject3).WithMany(p => p.Relations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Relation_Vouchers");
        });

        modelBuilder.Entity<RelationDetail>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.remark).IsFixedLength();

            entity.HasOne(d => d.relationNavigation).WithMany(p => p.RelationDetails).HasConstraintName("FK_RelationDetail_RelationDetail");

            entity.HasOne(d => d.voucherDefnNavigation).WithMany(p => p.RelationDetails).HasConstraintName("FK_RelationDetail_VoucherDefinition");
        });

        modelBuilder.Entity<RelationDetail_View>(entity =>
        {
            entity.ToView("RelationDetail_View", "common");
        });

        modelBuilder.Entity<RelationalState>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.relationNavigation).WithMany(p => p.RelationalStates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RelationalState_Relation");

            entity.HasOne(d => d.stateNavigation).WithMany(p => p.RelationalStates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RelationalState_ObjectState");
        });

        modelBuilder.Entity<RemovedItem>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.activityNavigation).WithMany(p => p.RemovedItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RemovedItems_Activity");

            entity.HasOne(d => d.articleNavigation).WithMany(p => p.RemovedItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RemovedItems_Article");

            entity.HasOne(d => d.voucherNavigation).WithMany(p => p.RemovedItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RemovedItems_Voucher");
        });

        modelBuilder.Entity<Report>(entity =>
        {
            entity.HasKey(e => e.code).HasName("PK_Report_1");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<ReportCriterion>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.controlTypeNavigation).WithMany(p => p.ReportCriteria).HasConstraintName("FK_ReportCriteria_Lookup");
        });

        modelBuilder.Entity<ReportHistory>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<RequiredGSLDetail>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.gslTypeNavigation).WithMany(p => p.RequiredGSLDetails).HasConstraintName("FK_RequiredGSLDetail_GSLTypeList");

            entity.HasOne(d => d.requiredGSLNavigation).WithMany(p => p.RequiredGSLDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RequiredGSLDetail_RequriedGSL");
        });

        modelBuilder.Entity<RequiredGSL_View>(entity =>
        {
            entity.ToView("RequiredGSL_View", "common");
        });

        modelBuilder.Entity<RequriedGSL>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.typeNavigation).WithMany(p => p.RequriedGSLs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RequriedGSL_Lookup");

            entity.HasOne(d => d.voucherDefnNavigation).WithMany(p => p.RequriedGSLs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RequriedGSL_VoucherDefinition");
        });

        modelBuilder.Entity<Reservation_View>(entity =>
        {
            entity.ToView("Reservation_View", "PMS");
        });

        modelBuilder.Entity<ResidentSummary>(entity =>
        {
            entity.HasOne(d => d.guestNavigation).WithMany(p => p.ResidentSummaries).HasConstraintName("FK_ResidentSummary_OrganizationUnitDefinition");

            entity.HasOne(d => d.guest1).WithMany(p => p.ResidentSummaries).HasConstraintName("FK_ResidentSummary_Person");

            entity.HasOne(d => d.registrationNavigation).WithMany(p => p.ResidentSummaries)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ResidentSummary_Registration");

            entity.HasOne(d => d.roomNavigation).WithMany(p => p.ResidentSummaries)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ResidentSummary_RoomDetail");
        });

        modelBuilder.Entity<RestaurantTable>(entity =>
        {
            entity.HasKey(e => e.code).HasName("PK_[RestaurantTable");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.SpaceNavigation).WithMany(p => p.RestaurantTables)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RestaurantTable_Space");
        });

        modelBuilder.Entity<RestaurantTree>(entity =>
        {
            entity.ToView("RestaurantTree", "pos");
        });

        modelBuilder.Entity<RoleActivity>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.activityDefinitionNavigation).WithMany(p => p.RoleActivities)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoleActivity_ActivityDefinition");
        });

        modelBuilder.Entity<RoomActivityView>(entity =>
        {
            entity.ToView("RoomActivityView", "PMS");
        });

        modelBuilder.Entity<RoomDetail>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.roomTypeNavigation).WithMany(p => p.RoomDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoomDetail_RoomType");

            entity.HasOne(d => d.spaceNavigation).WithMany(p => p.RoomDetails).HasConstraintName("FK_RoomDetail_Space");
        });

        modelBuilder.Entity<RoomFeature>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.componentNavigation).WithMany(p => p.RoomFeatures)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoomFeature_CNETComponent");

            entity.HasOne(d => d.referenceNavigation).WithMany(p => p.RoomFeatures)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoomFeature_RoomType");
        });

        modelBuilder.Entity<RoomInventory_View>(entity =>
        {
            entity.ToView("RoomInventory_View", "PMS");
        });

        modelBuilder.Entity<RoomType>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.roomClassNavigation).WithMany(p => p.RoomTypes).HasConstraintName("FK_RoomType_Lookup");
        });

        modelBuilder.Entity<RoomTypeRateStrategy>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.rateStrategyNavigation).WithMany(p => p.RoomTypeRateStrategies).HasConstraintName("FK_RoomTypeRateStrategy_RateStrategy");

            entity.HasOne(d => d.roomTypeNavigation).WithMany(p => p.RoomTypeRateStrategies).HasConstraintName("FK_RoomTypeRateStrategy_RoomType");
        });

        modelBuilder.Entity<Route>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<RouteSale>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.orgUnitNavigation).WithMany(p => p.RouteSales)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RouteSales_OrganizationUnitDefinition");

            entity.HasOne(d => d.scheduleHeaderNavigation).WithMany(p => p.RouteSales)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RouteSales_ScheduleHeader");

            entity.HasOne(d => d.spaceNavigation).WithMany(p => p.RouteSales)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RouteSales_Space");
        });

        modelBuilder.Entity<SalesReportHeiniken>(entity =>
        {
            entity.ToView("SalesReportHeiniken");
        });

        modelBuilder.Entity<Schedule>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.referenceNavigation).WithMany(p => p.Schedules).HasConstraintName("FK_Schedule_LineItem");

            entity.HasOne(d => d.scheduledHeaderNavigation).WithMany(p => p.Schedules).HasConstraintName("FK_Schedule_ScheduleHeader");
        });

        modelBuilder.Entity<ScheduleControllerMapView>(entity =>
        {
            entity.ToView("ScheduleControllerMapView", "AccessControl");
        });

        modelBuilder.Entity<ScheduleDetail>(entity =>
        {
            entity.HasKey(e => e.code).HasName("PK_ScheduleTime");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<ScheduleHeader>(entity =>
        {
            entity.HasKey(e => e.code).HasName("PK_TaskSetup");

            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.cateogryNavigation).WithMany(p => p.ScheduleHeadercateogryNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ScheduleHeader_Lookup1");

            entity.HasOne(d => d.typeNavigation).WithMany(p => p.ScheduleHeadertypeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ScheduleHeader_Lookup");
        });

        modelBuilder.Entity<ScheduleHeader_view>(entity =>
        {
            entity.ToView("ScheduleHeader_view", "common");
        });

        modelBuilder.Entity<SeasonalMessage>(entity =>
        {
            entity.HasKey(e => e.code).HasName("PK_SeasonalMEssage");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.periodNavigation).WithMany(p => p.SeasonalMessages)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SeasonalMessage_Period");
        });

        modelBuilder.Entity<SeatArrangement>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<SeatTransaction>(entity =>
        {
            entity.ToTable("SeatTransaction", "cinema", tb => tb.HasTrigger("SeatTransactiontTrigger"));

            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<SelectedValueFactor_VIEW>(entity =>
        {
            entity.ToView("SelectedValueFactor_VIEW", "common");
        });

        modelBuilder.Entity<SerialCode>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.serialDefinitionNavigation).WithMany(p => p.SerialCodes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SerialCode_SerialDefinition");
        });

        modelBuilder.Entity<SerialDefinition>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.articleNavigation).WithMany(p => p.SerialDefinitions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SerialDefinition_Article");
        });

        modelBuilder.Entity<SerialDefinition_View>(entity =>
        {
            entity.ToView("SerialDefinition_View", "common");
        });

        modelBuilder.Entity<SerialParameter>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.baudRateNavigation).WithMany(p => p.SerialParameterbaudRateNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SerialParameter_Lookup");

            entity.HasOne(d => d.deviceNavigation).WithMany(p => p.SerialParameters)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SerialParameter_Device");

            entity.HasOne(d => d.parityNavigation).WithMany(p => p.SerialParameterparityNavigations).HasConstraintName("FK_SerialParameter_Lookup1");
        });

        modelBuilder.Entity<Session>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<ShapeMapper>(entity =>
        {
            entity.HasKey(e => e.code).HasName("PK_ShpeMapper");

            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<Shift>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<Space>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.CatagoryNavigation).WithMany(p => p.SpaceCatagoryNavigations).HasConstraintName("FK_Space_Lookup1");

            entity.HasOne(d => d.ParentNavigation).WithMany(p => p.InverseParentNavigation).HasConstraintName("FK_Space_Space");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.SpaceTypeNavigations).HasConstraintName("FK_Space_Lookup");
        });

        modelBuilder.Entity<SpaceCapacity>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.spaceNavigation).WithMany(p => p.SpaceCapacities)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SpaceCapacity_Space");

            entity.HasOne(d => d.spaceArrangmentNavigation).WithMany(p => p.SpaceCapacities).HasConstraintName("FK_SpaceCapacity_Lookup");
        });

        modelBuilder.Entity<SpaceDirection>(entity =>
        {
            entity.HasKey(e => e.code).HasName("PK_Direction");

            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.deviceNavigation).WithMany(p => p.SpaceDirections)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Direction_Device");

            entity.HasOne(d => d.directionNavigation).WithMany(p => p.SpaceDirections)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Direction_Lookup");

            entity.HasOne(d => d.spaceNavigation).WithMany(p => p.SpaceDirections)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Direction_Space");
        });

        modelBuilder.Entity<Space_View>(entity =>
        {
            entity.ToView("Space_View", "common");
        });

        modelBuilder.Entity<Specification>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.articleNavigation).WithMany(p => p.Specifications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Specification_Article");

            entity.HasOne(d => d.categoryNavigation).WithMany(p => p.SpecificationcategoryNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Specification_Lookup1");

            entity.HasOne(d => d.typeNavigation).WithMany(p => p.SpecificationtypeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Specification_Lookup");
        });

        modelBuilder.Entity<StockBalance>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.articleNavigation).WithMany(p => p.StockBalances)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockBalance_Article");

            entity.HasOne(d => d.periodNavigation).WithMany(p => p.StockBalances).HasConstraintName("FK_StockBalance_Period");

            entity.HasOne(d => d.storeNavigation).WithMany(p => p.StockBalances)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockBalance_OrganizationUnitDefinition");
        });

        modelBuilder.Entity<StockLevel>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.articleNavigation).WithMany(p => p.StockLevels)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockLevel_Article");

            entity.HasOne(d => d.storeNavigation).WithMany(p => p.StockLevels)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockLevel_OrganizationUnitDefinition");
        });

        modelBuilder.Entity<StockLevelView>(entity =>
        {
            entity.ToView("StockLevelView", "common");
        });

        modelBuilder.Entity<Stockbalance_view>(entity =>
        {
            entity.ToView("Stockbalance_view", "common");
        });

        modelBuilder.Entity<StoreTransaction>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.destinationNavigation).WithMany(p => p.StoreTransactiondestinationNavigations).HasConstraintName("FK_StoreTransaction_OrganizationUnitDefinitionSource");

            entity.HasOne(d => d.sourceNavigation).WithMany(p => p.StoreTransactionsourceNavigations).HasConstraintName("FK_StoreTransaction_OrganizationUnitDefinitionDestination");

            entity.HasOne(d => d.voucherNavigation).WithMany(p => p.StoreTransactions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StoreTransaction_Voucher");
        });

        modelBuilder.Entity<Subcountry>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.gpsNavigation).WithMany(p => p.Subcountries).HasConstraintName("FK_Subcountry_GPS");

            entity.HasOne(d => d.parentNavigation).WithMany(p => p.InverseparentNavigation).HasConstraintName("FK_Subcountry_Subcountry1");

            entity.HasOne(d => d.typeNavigation).WithMany(p => p.Subcountries).HasConstraintName("FK_Subcountry_Lookup");
        });

        modelBuilder.Entity<SubscriptionControllerMapView>(entity =>
        {
            entity.ToView("SubscriptionControllerMapView", "AccessControl");
        });

        modelBuilder.Entity<SubscriptionView>(entity =>
        {
            entity.ToView("SubscriptionView", "AccessControl");
        });

        modelBuilder.Entity<Subtitle>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.languageNavigation).WithMany(p => p.Subtitles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Subtitle_Language");

            entity.HasOne(d => d.mediaNavigation).WithMany(p => p.Subtitles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Subtitle_CNETMedia");
        });

        modelBuilder.Entity<Tax>(entity =>
        {
            entity.HasKey(e => e.code).HasName("PK_Tax_1");

            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.categoryNavigation).WithMany(p => p.Taxes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tax_LookUp");
        });

        modelBuilder.Entity<TaxTransaction>(entity =>
        {
            entity.ToTable("TaxTransaction", "common", tb => tb.HasTrigger("Prevent_Update_TaxTrx_Trigger"));

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.taxTypeNavigation).WithMany(p => p.TaxTransactions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TaxTransaction_TaxTransaction");

            entity.HasOne(d => d.voucherNavigation).WithMany(p => p.TaxTransactions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TaxTransaction_Voucher");
        });

        modelBuilder.Entity<TaxWithCategory>(entity =>
        {
            entity.ToView("TaxWithCategory", "common");
        });

        modelBuilder.Entity<TermList>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.categoryNavigation).WithMany(p => p.TermLists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TermList_Lookup");

            entity.HasOne(d => d.voucherDefnNavigation).WithMany(p => p.TermLists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TermList_VoucherDefinition");
        });

        modelBuilder.Entity<TimeSheet>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.referenceNavigation).WithMany(p => p.TimeSheetreferenceNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TimeSheet_Voucher1");

            entity.HasOne(d => d.voucherNavigation).WithMany(p => p.TimeSheetvoucherNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TimeSheet_Voucher");
        });

        modelBuilder.Entity<TranReferenceReconciliation_View>(entity =>
        {
            entity.ToView("TranReferenceReconciliation_View", "common");
        });

        modelBuilder.Entity<TranRoutingDetail>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.articleNavigation).WithMany(p => p.TranRoutingDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TranRoutingDetail_Article");

            entity.HasOne(d => d.tranRoutingHeaderNavigation).WithMany(p => p.TranRoutingDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TranRoutingDetail_TranRoutingHeader");
        });

        modelBuilder.Entity<TranRoutingHeader>(entity =>
        {
            entity.HasKey(e => e.code).HasName("PK_TranRoutingHeader_1");

            entity.HasOne(d => d.componentNavigation).WithMany(p => p.TranRoutingHeaders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TranRoutingHeader_CNETComponent");

            entity.HasOne(d => d.referenceNavigation).WithMany(p => p.TranRoutingHeaders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TranRoutingHeader_RegistrationHeader");

            entity.HasOne(d => d.typeNavigation).WithMany(p => p.TranRoutingHeaders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TranRoutingHeader_Lookup");
        });

        modelBuilder.Entity<TransactionCurrency>(entity =>
        {
            entity.HasKey(e => e.code).HasName("PK_TransactionReference");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.currencyNavigation).WithMany(p => p.TransactionCurrencies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransactionCurrency_Currency");

            entity.HasOne(d => d.voucherNavigation).WithMany(p => p.TransactionCurrencies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransactionCurrency_Voucher");
        });

        modelBuilder.Entity<TransactionLimit>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.referenceNavigation).WithMany(p => p.TransactionLimits)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransactionLimit_Article");

            entity.HasOne(d => d.reference1).WithMany(p => p.TransactionLimits)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransactionLimit_Organization");

            entity.HasOne(d => d.reference2).WithMany(p => p.TransactionLimits)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransactionLimit_Person");

            entity.HasOne(d => d.typeNavigation).WithMany(p => p.TransactionLimits)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransactionLimit_Lookup");
        });

        modelBuilder.Entity<TransactionReference>(entity =>
        {
            entity.HasKey(e => e.code).HasName("PK_TransactionReference_1");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.referencedNavigation).WithMany(p => p.TransactionReferencereferencedNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransactionReference_TransactionReference");

            entity.HasOne(d => d.refereningNavigation).WithMany(p => p.TransactionReferencerefereningNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransactionReference_TransactionReference1");
        });

        modelBuilder.Entity<TransactionReferenceVoucherView>(entity =>
        {
            entity.ToView("TransactionReferenceVoucherView", "common");
        });

        modelBuilder.Entity<Translation>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.referenceNavigation).WithMany(p => p.Translations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Translation_Article");

            entity.HasOne(d => d.reference1).WithMany(p => p.Translations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Translation_Organization");

            entity.HasOne(d => d.reference2).WithMany(p => p.Translations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Translation_Person");
        });

        modelBuilder.Entity<TravelDetail>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<TrialBalance>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.type).HasDefaultValueSql("(N'worksheet')");

            entity.HasOne(d => d.periodNavigation).WithMany(p => p.TrialBalances)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TrialBalance_Period");
        });

        modelBuilder.Entity<TurnDown>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.roomDetailNavigation).WithMany(p => p.TurnDowns).HasConstraintName("FK_TurnDown_RoomDetail");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.personNavigation).WithMany(p => p.Users)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_Person");
        });

        modelBuilder.Entity<UserRoleMapper>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.roleNavigation).WithMany(p => p.UserRoleMappers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserRoleMapper_RoleActivity");

            entity.HasOne(d => d.userNavigation).WithMany(p => p.UserRoleMappers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserRoleMapper_User");
        });

        modelBuilder.Entity<VOD_View>(entity =>
        {
            entity.ToView("VOD_View", "PMS");
        });

        modelBuilder.Entity<Value>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.articleNavigation).WithMany(p => p.Values)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Value_Article");

            entity.HasOne(d => d.currencyNavigation).WithMany(p => p.Values)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Value_Currency");
        });

        modelBuilder.Entity<ValueFactor>(entity =>
        {
            entity.HasKey(e => e.code).HasName("PK__ValueFac__357D4CF8ED5D7756");

            entity.Property(e => e.id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.componentNavigation).WithMany(p => p.ValueFactors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ValueFactor_Lookup");

            entity.HasOne(d => d.referenceNavigation).WithMany(p => p.ValueFactors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ValueFactor_Article");

            entity.HasOne(d => d.reference1).WithMany(p => p.ValueFactors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ValueFactor_Organization");

            entity.HasOne(d => d.reference2).WithMany(p => p.ValueFactors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ValueFactor_Person");

            entity.HasOne(d => d.reference3).WithMany(p => p.ValueFactors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ValueFactor_TermList");
        });

        modelBuilder.Entity<ValueFactorDefinition>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<ValueFactorSetup>(entity =>
        {
            entity.Property(e => e.voucherDefinition).ValueGeneratedNever();

            entity.HasOne(d => d.valueFactorDefinitionNavigation).WithMany(p => p.ValueFactorSetups)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ValueFactorSetup_ValueFactorDefinition");

            entity.HasOne(d => d.voucherDefinitionNavigation).WithOne(p => p.ValueFactorSetup)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ValueFactorSetup_VoucherDefinition");
        });

        modelBuilder.Entity<Value_View>(entity =>
        {
            entity.ToView("Value_View", "common");
        });

        modelBuilder.Entity<VauesSummaryByReferenceView>(entity =>
        {
            entity.ToView("VauesSummaryByReferenceView", "common");
        });

        modelBuilder.Entity<ViewDeviceByReference>(entity =>
        {
            entity.ToView("ViewDeviceByReference", "common");
        });

        modelBuilder.Entity<ViewFont>(entity =>
        {
            entity.ToView("ViewFont", "common");
        });

        modelBuilder.Entity<ViewGetVoucherExtTran>(entity =>
        {
            entity.ToView("ViewGetVoucherExtTrans", "common");
        });

        modelBuilder.Entity<ViewHolidayPeriod>(entity =>
        {
            entity.ToView("ViewHolidayPeriod", "common");
        });

        modelBuilder.Entity<ViewOrganizationUnitInfo>(entity =>
        {
            entity.ToView("ViewOrganizationUnitInfo", "common");
        });

        modelBuilder.Entity<ViewWorkFlow>(entity =>
        {
            entity.ToView("ViewWorkFlow", "common");
        });

        modelBuilder.Entity<View_1>(entity =>
        {
            entity.ToView("View_1");
        });

        modelBuilder.Entity<View_2>(entity =>
        {
            entity.ToView("View_2");
        });

        modelBuilder.Entity<View_ArticlePrice>(entity =>
        {
            entity.ToView("View_ArticlePrice", "common");
        });

        modelBuilder.Entity<View_GetIssuedCardInfo>(entity =>
        {
            entity.ToView("View_GetIssuedCardInfo", "common");
        });

        modelBuilder.Entity<VoidLastPlacement>(entity =>
        {
            entity.ToView("VoidLastPlacement", "hrms");
        });

        modelBuilder.Entity<Voucher>(entity =>
        {
            entity.ToTable("Voucher", "common", tb => tb.HasTrigger("Prevent_Update_Trigger"));

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.LastObjectStateNavigation).WithMany(p => p.Vouchers).HasConstraintName("FK_Voucher_ObjectStateDefinition");

            entity.HasOne(d => d.consigneeNavigation).WithMany(p => p.Vouchers).HasConstraintName("FK_Voucher_Organization");

            entity.HasOne(d => d.consignee1).WithMany(p => p.Vouchers).HasConstraintName("FK_Voucher_Person");

            entity.HasOne(d => d.periodNavigation).WithMany(p => p.Vouchers).HasConstraintName("FK_Voucher_Period");

            entity.HasOne(d => d.typeNavigation).WithMany(p => p.Vouchers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Voucher_Lookup");

            entity.HasOne(d => d.voucherDefinitionNavigation).WithMany(p => p.Vouchers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Voucher_VoucherDefinition");
        });

        modelBuilder.Entity<VoucherAccount>(entity =>
        {
            entity.ToTable("VoucherAccount", "common", tb => tb.HasTrigger("Prevent_Update_VoucherAccount_Trigger"));

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.voucherNavigation).WithMany(p => p.VoucherAccounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VoucherAccount_Voucher");
        });

        modelBuilder.Entity<VoucherAccount_View>(entity =>
        {
            entity.ToView("VoucherAccount_View", "common");
        });

        modelBuilder.Entity<VoucherAttachmentView>(entity =>
        {
            entity.ToView("VoucherAttachmentView", "common");
        });

        modelBuilder.Entity<VoucherDashBoardPrivilege>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<VoucherDefinition>(entity =>
        {
            entity.Property(e => e.code).ValueGeneratedNever();
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<VoucherDetail_View>(entity =>
        {
            entity.ToView("VoucherDetail_View", "common");
        });

        modelBuilder.Entity<VoucherExtension>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.typeNavigation).WithMany(p => p.VoucherExtensions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VoucherExtension_Lookup");

            entity.HasOne(d => d.voucherDefnNavigation).WithMany(p => p.VoucherExtensions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VoucherExtension_VoucherDefinition");
        });

        modelBuilder.Entity<VoucherExtensionTransaction>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.voucherNavigation).WithMany(p => p.VoucherExtensionTransactions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VoucherExtensionTransaction_Voucher");

            entity.HasOne(d => d.voucherExtensionNavigation).WithMany(p => p.VoucherExtensionTransactions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VoucherExtensionTransaction_VoucherExtension");
        });

        modelBuilder.Entity<VoucherExtension_View>(entity =>
        {
            entity.ToView("VoucherExtension_View", "common");
        });

        modelBuilder.Entity<VoucherLineItemView>(entity =>
        {
            entity.ToView("VoucherLineItemView", "common");
        });

        modelBuilder.Entity<VoucherLookupDetail>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<VoucherNote>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.voucherNavigation).WithMany(p => p.VoucherNotes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VoucherNote_Voucher");
        });

        modelBuilder.Entity<VoucherOperation>(entity =>
        {
            entity.ToView("VoucherOperation", "common");
        });

        modelBuilder.Entity<VoucherRegistrationView>(entity =>
        {
            entity.ToView("VoucherRegistrationView", "PMS");
        });

        modelBuilder.Entity<VoucherStoreMapping>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.storeNavigation).WithMany(p => p.VoucherStoreMappings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VoucherStoreMapping_OrganizationUnitDefinition");

            entity.HasOne(d => d.voucherDefnNavigation).WithMany(p => p.VoucherStoreMappings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VoucherStoreMapping_VoucherDefinition");
        });

        modelBuilder.Entity<VoucherTerm>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.termNavigation).WithMany(p => p.VoucherTerms)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VoucherTerm_TermList");

            entity.HasOne(d => d.voucherNavigation).WithMany(p => p.VoucherTerms)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VoucherTerm_Voucher");
        });

        modelBuilder.Entity<VoucherValue>(entity =>
        {
            entity.ToTable("VoucherValues", "common", tb => tb.HasTrigger("Prevent_Update_VoucherValues_Trigger"));

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.voucherNavigation).WithMany(p => p.VoucherValues)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VoucherValues_Voucher");
        });

        modelBuilder.Entity<Voucher_BackwardReferenceReport_View>(entity =>
        {
            entity.ToView("Voucher_BackwardReferenceReport_View", "report");
        });

        modelBuilder.Entity<Voucher_DetailExtensionReport_View>(entity =>
        {
            entity.ToView("Voucher_DetailExtensionReport_View", "report");
        });

        modelBuilder.Entity<Voucher_DetailReport_View>(entity =>
        {
            entity.ToView("Voucher_DetailReport_View", "common");
        });

        modelBuilder.Entity<Voucher_DetailReport_View1>(entity =>
        {
            entity.ToView("Voucher_DetailReport_View", "report");
        });

        modelBuilder.Entity<Voucher_ForwardReferenceReport_View>(entity =>
        {
            entity.ToView("Voucher_ForwardReferenceReport_View", "report");
        });

        modelBuilder.Entity<Voucher_HeaderReport_view>(entity =>
        {
            entity.ToView("Voucher_HeaderReport_view", "report");
        });

        modelBuilder.Entity<Voucher_ReferenceReport_View>(entity =>
        {
            entity.ToView("Voucher_ReferenceReport_View", "report");
        });

        modelBuilder.Entity<Voucher_Relation_View>(entity =>
        {
            entity.ToView("Voucher_Relation_View", "common");
        });

        modelBuilder.Entity<Voucher_RemovedArticleReport_View>(entity =>
        {
            entity.ToView("Voucher_RemovedArticleReport_View", "report");
        });

        modelBuilder.Entity<Voucher_SalesBySupplier_View>(entity =>
        {
            entity.ToView("Voucher_SalesBySupplier_View", "report");
        });

        modelBuilder.Entity<Voucher_View>(entity =>
        {
            entity.ToView("Voucher_View", "common");
        });

        modelBuilder.Entity<Voucher_WorkflowReport_View>(entity =>
        {
            entity.ToView("Voucher_WorkflowReport_View", "report");
        });

        modelBuilder.Entity<Vw_ModificationHistory>(entity =>
        {
            entity.ToView("Vw_ModificationHistory", "common");
        });

        modelBuilder.Entity<WeekDay>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.componentNavigation).WithMany(p => p.WeekDays)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WeekDays_CNETComponent");

            entity.HasOne(d => d.referenceNavigation).WithMany(p => p.WeekDays)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WeekDays_PackageDetail");

            entity.HasOne(d => d.reference1).WithMany(p => p.WeekDays)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WeekDays_RateCodeHeader");

            entity.HasOne(d => d.reference2).WithMany(p => p.WeekDays)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WeekDays_RateStrategy");
        });

        modelBuilder.Entity<WriteUp>(entity =>
        {
            entity.Property(e => e.id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<_Address_CityProvince_View>(entity =>
        {
            entity.ToView("_Address_CityProvince_View", "common");
        });

        modelBuilder.Entity<_Address_EXTENSION_View>(entity =>
        {
            entity.ToView("_Address_EXTENSION_View", "common");
        });

        modelBuilder.Entity<_Address_Email_View>(entity =>
        {
            entity.ToView("_Address_Email_View", "common");
        });

        modelBuilder.Entity<_Address_Fax_View>(entity =>
        {
            entity.ToView("_Address_Fax_View", "common");
        });

        modelBuilder.Entity<_Address_HOME_PHONE_View>(entity =>
        {
            entity.ToView("_Address_HOME_PHONE_View", "common");
        });

        modelBuilder.Entity<_Address_HouseNo_View>(entity =>
        {
            entity.ToView("_Address_HouseNo_View", "common");
        });

        modelBuilder.Entity<_Address_LINKED_IN_View>(entity =>
        {
            entity.ToView("_Address_LINKED_IN_View", "common");
        });

        modelBuilder.Entity<_Address_Mobilephone_View>(entity =>
        {
            entity.ToView("_Address_Mobilephone_View", "common");
        });

        modelBuilder.Entity<_Address_PHYSICAL_ADDRESS_View>(entity =>
        {
            entity.ToView("_Address_PHYSICAL_ADDRESS_View", "common");
        });

        modelBuilder.Entity<_Address_POBox_View>(entity =>
        {
            entity.ToView("_Address_POBox_View", "common");
        });

        modelBuilder.Entity<_Address_Region_View>(entity =>
        {
            entity.ToView("_Address_Region_View", "common");
        });

        modelBuilder.Entity<_Address_SMTP_Server_View>(entity =>
        {
            entity.ToView("_Address_SMTP_Server_View", "common");
        });

        modelBuilder.Entity<_Address_SOCAIL_MEDIA_View>(entity =>
        {
            entity.ToView("_Address_SOCAIL_MEDIA_View", "common");
        });

        modelBuilder.Entity<_Address_Specific_Location_View>(entity =>
        {
            entity.ToView("_Address_Specific_Location_View", "common");
        });

        modelBuilder.Entity<_Address_Website_View>(entity =>
        {
            entity.ToView("_Address_Website_View", "common");
        });

        modelBuilder.Entity<_Address_WorkMobile_View>(entity =>
        {
            entity.ToView("_Address_WorkMobile_View", "common");
        });

        modelBuilder.Entity<_Address_kebele_View>(entity =>
        {
            entity.ToView("_Address_kebele_View", "common");
        });

        modelBuilder.Entity<_Address_subCity_View>(entity =>
        {
            entity.ToView("_Address_subCity_View", "common");
        });

        modelBuilder.Entity<_Address_twitter_View>(entity =>
        {
            entity.ToView("_Address_twitter_View", "common");
        });

        modelBuilder.Entity<_Address_wereda_View>(entity =>
        {
            entity.ToView("_Address_wereda_View", "common");
        });

        modelBuilder.Entity<allSalesReportView>(entity =>
        {
            entity.ToView("allSalesReportView");
        });

        modelBuilder.Entity<beauty_supply_items_view>(entity =>
        {
            entity.ToView("beauty_supply_items_view", "ecommerce");
        });

        modelBuilder.Entity<cloth_items_view>(entity =>
        {
            entity.ToView("cloth_items_view", "ecommerce");
        });

        modelBuilder.Entity<consolidated_beauty_supply_items_view>(entity =>
        {
            entity.ToView("consolidated_beauty_supply_items_view", "ecommerce");
        });

        modelBuilder.Entity<consolidated_cloth_items_view>(entity =>
        {
            entity.ToView("consolidated_cloth_items_view", "ecommerce");
        });

        modelBuilder.Entity<consolidated_electrical_items_view>(entity =>
        {
            entity.ToView("consolidated_electrical_items_view", "ecommerce");
        });

        modelBuilder.Entity<consolidated_electronics_items_view>(entity =>
        {
            entity.ToView("consolidated_electronics_items_view", "ecommerce");
        });

        modelBuilder.Entity<consolidated_furniture_items_view>(entity =>
        {
            entity.ToView("consolidated_furniture_items_view", "ecommerce");
        });

        modelBuilder.Entity<consolidated_grocery_items_view>(entity =>
        {
            entity.ToView("consolidated_grocery_items_view", "ecommerce");
        });

        modelBuilder.Entity<consolidated_household_items_view>(entity =>
        {
            entity.ToView("consolidated_household_items_view", "ecommerce");
        });

        modelBuilder.Entity<consolidated_pharmacy_items_view>(entity =>
        {
            entity.ToView("consolidated_pharmacy_items_view", "ecommerce");
        });

        modelBuilder.Entity<consolidated_restaurant_items_view>(entity =>
        {
            entity.ToView("consolidated_restaurant_items_view", "ecommerce");
        });

        modelBuilder.Entity<db__vw_RelationDetal>(entity =>
        {
            entity.ToView("db.[vw_RelationDetal", "common");
        });

        modelBuilder.Entity<electrical_items_view>(entity =>
        {
            entity.ToView("electrical_items_view", "ecommerce");
        });

        modelBuilder.Entity<electronics_items_view>(entity =>
        {
            entity.ToView("electronics_items_view", "ecommerce");
        });

        modelBuilder.Entity<furniture_items_view>(entity =>
        {
            entity.ToView("furniture_items_view", "ecommerce");
        });

        modelBuilder.Entity<grocery_items_view>(entity =>
        {
            entity.ToView("grocery_items_view", "ecommerce");
        });

        modelBuilder.Entity<household_items_view>(entity =>
        {
            entity.ToView("household_items_view", "ecommerce");
        });

        modelBuilder.Entity<organizationAddressView>(entity =>
        {
            entity.ToView("organizationAddressView", "common");
        });

        modelBuilder.Entity<pharmacy_items_view>(entity =>
        {
            entity.ToView("pharmacy_items_view", "ecommerce");
        });

        modelBuilder.Entity<restaurant_items_view>(entity =>
        {
            entity.ToView("restaurant_items_view", "ecommerce");
        });

        modelBuilder.Entity<rptItemList>(entity =>
        {
            entity.ToView("rptItemList", "common");
        });

        modelBuilder.Entity<rptTransactionReference>(entity =>
        {
            entity.ToView("rptTransactionReference", "common");
        });

        modelBuilder.Entity<rptVoucherAttachment>(entity =>
        {
            entity.ToView("rptVoucherAttachment", "common");
        });

        modelBuilder.Entity<rptVoucherOperation>(entity =>
        {
            entity.ToView("rptVoucherOperation", "common");

            entity.Property(e => e.IssuedDate).IsFixedLength();
        });

        modelBuilder.Entity<rptsummarized>(entity =>
        {
            entity.ToView("rptsummarized", "common");

            entity.Property(e => e.IssuedDate).IsFixedLength();
        });

        modelBuilder.Entity<scheduleView>(entity =>
        {
            entity.ToView("scheduleView", "hrms");
        });

        modelBuilder.Entity<testView>(entity =>
        {
            entity.ToView("testView");
        });

        modelBuilder.Entity<viewAccountBeginningBalance>(entity =>
        {
            entity.ToView("viewAccountBeginningBalance", "common");
        });

        modelBuilder.Entity<viewActivepersonRole>(entity =>
        {
            entity.ToView("viewActivepersonRole", "common");
        });

        modelBuilder.Entity<viewActivityDefinition>(entity =>
        {
            entity.ToView("viewActivityDefinition", "common");
        });

        modelBuilder.Entity<viewFunctWithAccessM>(entity =>
        {
            entity.ToView("viewFunctWithAccessM", "common");
        });

        modelBuilder.Entity<viewGetLineItemSpanByReference>(entity =>
        {
            entity.ToView("viewGetLineItemSpanByReference", "common");
        });

        modelBuilder.Entity<viewLineItemModifierNoteValFactor>(entity =>
        {
            entity.ToView("viewLineItemModifierNoteValFactor", "common");
        });

        modelBuilder.Entity<viewLineItemRef>(entity =>
        {
            entity.ToView("viewLineItemRef", "common");
        });

        modelBuilder.Entity<viewOrgPersonByType>(entity =>
        {
            entity.ToView("viewOrgPersonByType", "common");
        });

        modelBuilder.Entity<viewPriceTag>(entity =>
        {
            entity.ToView("viewPriceTag", "common");
        });

        modelBuilder.Entity<viewRelationOjbect>(entity =>
        {
            entity.ToView("viewRelationOjbect", "common");
        });

        modelBuilder.Entity<viewReport>(entity =>
        {
            entity.ToView("viewReport", "common");
        });

        modelBuilder.Entity<viewReportCriteriaValue>(entity =>
        {
            entity.ToView("viewReportCriteriaValue", "common");
        });

        modelBuilder.Entity<viewRoleActivitywithRange>(entity =>
        {
            entity.ToView("viewRoleActivitywithRange", "common");
        });

        modelBuilder.Entity<viewSpaceLocation>(entity =>
        {
            entity.ToView("viewSpaceLocation", "common");
        });

        modelBuilder.Entity<viewTransactionDenomination>(entity =>
        {
            entity.ToView("viewTransactionDenomination", "common");
        });

        modelBuilder.Entity<view_Lookup>(entity =>
        {
            entity.ToView("view_Lookup", "common");
        });

        modelBuilder.Entity<voucherActivity_View>(entity =>
        {
            entity.ToView("voucherActivity_View", "common");
        });

        modelBuilder.Entity<vwSerialCode_description>(entity =>
        {
            entity.ToView("vwSerialCode_description", "common");
        });

        modelBuilder.Entity<vwSynchronization_view>(entity =>
        {
            entity.ToView("vwSynchronization_view", "common");
        });

        modelBuilder.Entity<vw_ACLogView>(entity =>
        {
            entity.ToView("vw_ACLogView", "AccessControl");
        });

        modelBuilder.Entity<vw_AccessControlDisplayView>(entity =>
        {
            entity.ToView("vw_AccessControlDisplayView", "AccessControl");
        });

        modelBuilder.Entity<vw_AccessControlLogDetailnfo>(entity =>
        {
            entity.ToView("vw_AccessControlLogDetailnfo", "AccessControl");
        });

        modelBuilder.Entity<vw_AccompanyingView>(entity =>
        {
            entity.ToView("vw_AccompanyingView", "PMS");
        });

        modelBuilder.Entity<vw_AccountMapView>(entity =>
        {
            entity.ToView("vw_AccountMapView", "common");
        });

        modelBuilder.Entity<vw_AccountView>(entity =>
        {
            entity.ToView("vw_AccountView", "common");
        });

        modelBuilder.Entity<vw_Account_AccountMap>(entity =>
        {
            entity.ToView("vw_Account_AccountMap", "common");
        });

        modelBuilder.Entity<vw_AccountingConsigneeView>(entity =>
        {
            entity.ToView("vw_AccountingConsigneeView", "common");
        });

        modelBuilder.Entity<vw_AccrualVoucher>(entity =>
        {
            entity.ToView("vw_AccrualVoucher", "common");
        });

        modelBuilder.Entity<vw_ActivityDefByCompAndRef>(entity =>
        {
            entity.ToView("vw_ActivityDefByCompAndRef", "common");
        });

        modelBuilder.Entity<vw_ActivitySecurity>(entity =>
        {
            entity.ToView("vw_ActivitySecurity", "common");
        });

        modelBuilder.Entity<vw_AddressDetailView>(entity =>
        {
            entity.ToView("vw_AddressDetailView", "common");
        });

        modelBuilder.Entity<vw_AddressValue>(entity =>
        {
            entity.ToView("vw_AddressValue", "common");
        });

        modelBuilder.Entity<vw_AddressWithValue>(entity =>
        {
            entity.ToView("vw_AddressWithValue", "common");
        });

        modelBuilder.Entity<vw_AgingMainVoucherView>(entity =>
        {
            entity.ToView("vw_AgingMainVoucherView", "common");
        });

        modelBuilder.Entity<vw_AgingVoucherView>(entity =>
        {
            entity.ToView("vw_AgingVoucherView", "common");
        });

        modelBuilder.Entity<vw_AllArticleOptionalCode>(entity =>
        {
            entity.ToView("vw_AllArticleOptionalCodes", "common");
        });

        modelBuilder.Entity<vw_AllLineItemArticle>(entity =>
        {
            entity.ToView("vw_AllLineItemArticles", "common");
        });

        modelBuilder.Entity<vw_AllPersonOrganizationName>(entity =>
        {
            entity.ToView("vw_AllPersonOrganizationNames", "common");
        });

        modelBuilder.Entity<vw_AllPersonOrganizationNamesAndPreference>(entity =>
        {
            entity.ToView("vw_AllPersonOrganizationNamesAndPreference", "common");
        });

        modelBuilder.Entity<vw_AllPersonView>(entity =>
        {
            entity.ToView("vw_AllPersonView", "common");
        });

        modelBuilder.Entity<vw_ArtPrefNoCatagory>(entity =>
        {
            entity.ToView("vw_ArtPrefNoCatagory", "common");
        });

        modelBuilder.Entity<vw_ArticleAccountMap>(entity =>
        {
            entity.ToView("vw_ArticleAccountMap", "common");
        });

        modelBuilder.Entity<vw_ArticleActivity>(entity =>
        {
            entity.ToView("vw_ArticleActivity", "common");
        });

        modelBuilder.Entity<vw_ArticleBeginningView>(entity =>
        {
            entity.ToView("vw_ArticleBeginningView", "common");
        });

        modelBuilder.Entity<vw_ArticleCBView>(entity =>
        {
            entity.ToView("vw_ArticleCBView", "common");
        });

        modelBuilder.Entity<vw_ArticleComponentWithDescription>(entity =>
        {
            entity.ToView("vw_ArticleComponentWithDescription", "Internal");
        });

        modelBuilder.Entity<vw_ArticleHeader>(entity =>
        {
            entity.ToView("vw_ArticleHeader", "common");
        });

        modelBuilder.Entity<vw_ArticlePhysicalDiman>(entity =>
        {
            entity.ToView("vw_ArticlePhysicalDimen", "common");
        });

        modelBuilder.Entity<vw_ArticlePreviousStockBalance>(entity =>
        {
            entity.ToView("vw_ArticlePreviousStockBalance", "common");
        });

        modelBuilder.Entity<vw_ArticleProductExtension>(entity =>
        {
            entity.ToView("vw_ArticleProductExtension", "common");
        });

        modelBuilder.Entity<vw_ArticleStockBalanceBySerialNumber>(entity =>
        {
            entity.ToView("vw_ArticleStockBalanceBySerialNumber", "common");
        });

        modelBuilder.Entity<vw_ArticleStockBalanceView>(entity =>
        {
            entity.ToView("vw_ArticleStockBalanceView", "common");
        });

        modelBuilder.Entity<vw_ArticleStoreList>(entity =>
        {
            entity.ToView("vw_ArticleStoreList", "common");
        });

        modelBuilder.Entity<vw_ArticleTransactionHistory>(entity =>
        {
            entity.ToView("vw_ArticleTransactionHistory", "common");
        });

        modelBuilder.Entity<vw_ArticleView>(entity =>
        {
            entity.ToView("vw_ArticleView", "common");
        });

        modelBuilder.Entity<vw_ArticleViewINFO>(entity =>
        {
            entity.ToView("vw_ArticleViewINFO", "common");
        });

        modelBuilder.Entity<vw_ArticleWithAccountMap>(entity =>
        {
            entity.ToView("vw_ArticleWithAccountMap", "common");
        });

        modelBuilder.Entity<vw_AttendanceException>(entity =>
        {
            entity.ToView("vw_AttendanceException", "hrms");
        });

        modelBuilder.Entity<vw_AttendanceExceptionView>(entity =>
        {
            entity.ToView("vw_AttendanceExceptionView", "hrms");
        });

        modelBuilder.Entity<vw_AttendanceIdentification>(entity =>
        {
            entity.ToView("vw_AttendanceIdentification", "hrms");
        });

        modelBuilder.Entity<vw_AttendanceLog>(entity =>
        {
            entity.ToView("vw_AttendanceLog", "hrms");
        });

        modelBuilder.Entity<vw_AuditEmployeeView>(entity =>
        {
            entity.ToView("vw_AuditEmployeeView", "common");
        });

        modelBuilder.Entity<vw_AuditPlacementVoucher>(entity =>
        {
            entity.ToView("vw_AuditPlacementVoucher", "hrms");
        });

        modelBuilder.Entity<vw_BackwardReference>(entity =>
        {
            entity.ToView("vw_BackwardReferences", "common");
        });

        modelBuilder.Entity<vw_BankBalanceView>(entity =>
        {
            entity.ToView("vw_BankBalanceView", "common");
        });

        modelBuilder.Entity<vw_BankTransferView>(entity =>
        {
            entity.ToView("vw_BankTransferView", "common");
        });

        modelBuilder.Entity<vw_BatchExpiryDateNotificationView>(entity =>
        {
            entity.ToView("vw_BatchExpiryDateNotificationView", "common");
        });

        modelBuilder.Entity<vw_BiometericID>(entity =>
        {
            entity.ToView("vw_BiometericID", "common");
        });

        modelBuilder.Entity<vw_BookedTransactionView>(entity =>
        {
            entity.ToView("vw_BookedTransactionView", "cinema");
        });

        modelBuilder.Entity<vw_CardIssuedView>(entity =>
        {
            entity.ToView("vw_CardIssuedView", "common");
        });

        modelBuilder.Entity<vw_CareerView>(entity =>
        {
            entity.ToView("vw_CareerView", "hrms");
        });

        modelBuilder.Entity<vw_CartView>(entity =>
        {
            entity.ToView("vw_CartView", "common");
        });

        modelBuilder.Entity<vw_CaseVoucherView>(entity =>
        {
            entity.ToView("vw_CaseVoucherView", "Internal");
        });

        modelBuilder.Entity<vw_CashDepositView>(entity =>
        {
            entity.ToView("vw_CashDepositView", "common");
        });

        modelBuilder.Entity<vw_ChangeLogVoucherDetail>(entity =>
        {
            entity.ToView("vw_ChangeLogVoucherDetail", "common");
        });

        modelBuilder.Entity<vw_ClientsLicense>(entity =>
        {
            entity.ToView("vw_ClientsLicense", "Internal");
        });

        modelBuilder.Entity<vw_CnetComponentWithLicence>(entity =>
        {
            entity.ToView("vw_CnetComponentWithLicence", "common");
        });

        modelBuilder.Entity<vw_CompanyPensionTaxtransaction>(entity =>
        {
            entity.ToView("vw_CompanyPensionTaxtransactions", "common");
        });

        modelBuilder.Entity<vw_ConsigneeView>(entity =>
        {
            entity.ToView("vw_ConsigneeView", "common");
        });

        modelBuilder.Entity<vw_ConsolidatedCompanyRating>(entity =>
        {
            entity.ToView("vw_ConsolidatedCompanyRating", "common");
        });

        modelBuilder.Entity<vw_ConsolidatedCompanyRatingDetail>(entity =>
        {
            entity.ToView("vw_ConsolidatedCompanyRatingDetail", "ecommerce");
        });

        modelBuilder.Entity<vw_CreditReceiptView>(entity =>
        {
            entity.ToView("vw_CreditReceiptView", "common");
        });

        modelBuilder.Entity<vw_CreditValidationView>(entity =>
        {
            entity.ToView("vw_CreditValidationView", "AccessControl");
        });

        modelBuilder.Entity<vw_CurrentArticleStockBalance>(entity =>
        {
            entity.ToView("vw_CurrentArticleStockBalance", "common");
        });

        modelBuilder.Entity<vw_DailyClosingDetail>(entity =>
        {
            entity.ToView("vw_DailyClosingDetail", "common");
        });

        modelBuilder.Entity<vw_DailySalesSummary>(entity =>
        {
            entity.ToView("vw_DailySalesSummary", "PMS");
        });

        modelBuilder.Entity<vw_DashboardProfile>(entity =>
        {
            entity.ToView("vw_DashboardProfile", "hrms");
        });

        modelBuilder.Entity<vw_DeliverDriver>(entity =>
        {
            entity.ToView("vw_DeliverDrivers", "pos");
        });

        modelBuilder.Entity<vw_Device_Name>(entity =>
        {
            entity.ToView("vw_Device_Name", "pos");
        });

        modelBuilder.Entity<vw_DiscountFactor>(entity =>
        {
            entity.ToView("vw_DiscountFactor", "common");
        });

        modelBuilder.Entity<vw_DistributionLookup>(entity =>
        {
            entity.ToView("vw_DistributionLookup", "common");
        });

        modelBuilder.Entity<vw_DocumentRangeView>(entity =>
        {
            entity.ToView("vw_DocumentRangeView", "common");
        });

        modelBuilder.Entity<vw_ERCASalesView>(entity =>
        {
            entity.ToView("vw_ERCASalesView", "common");
        });

        modelBuilder.Entity<vw_EcommerceOrderUnionView>(entity =>
        {
            entity.ToView("vw_EcommerceOrderUnionView", "ecommerce");
        });

        modelBuilder.Entity<vw_EcommerceOrderView>(entity =>
        {
            entity.ToView("vw_EcommerceOrderView", "ecommerce");
        });

        modelBuilder.Entity<vw_EmployeeAttachmentView>(entity =>
        {
            entity.ToView("vw_EmployeeAttachmentView", "hrms");
        });

        modelBuilder.Entity<vw_EmployeeLastPlacement>(entity =>
        {
            entity.ToView("vw_EmployeeLastPlacement", "hrms");
        });

        modelBuilder.Entity<vw_EmployeeMobile>(entity =>
        {
            entity.ToView("vw_EmployeeMobile", "common");
        });

        modelBuilder.Entity<vw_EmployeePensionTaxtransaction>(entity =>
        {
            entity.ToView("vw_EmployeePensionTaxtransactions", "common");
        });

        modelBuilder.Entity<vw_EmployeeView>(entity =>
        {
            entity.ToView("vw_EmployeeView", "common");
        });

        modelBuilder.Entity<vw_EquipmentDatum>(entity =>
        {
            entity.ToView("vw_EquipmentData", "common");
        });

        modelBuilder.Entity<vw_EscalationVoucherView>(entity =>
        {
            entity.ToView("vw_EscalationVoucherView", "Internal");
        });

        modelBuilder.Entity<vw_EvaluationSheet>(entity =>
        {
            entity.ToView("vw_EvaluationSheet", "common");
        });

        modelBuilder.Entity<vw_EventDetailView>(entity =>
        {
            entity.ToView("vw_EventDetailView", "cnetEvent");

            entity.Property(e => e.description).IsFixedLength();
        });

        modelBuilder.Entity<vw_EventDisplayView>(entity =>
        {
            entity.ToView("vw_EventDisplayView", "cnetEvent");

            entity.Property(e => e.EventDetailDescription).IsFixedLength();
        });

        modelBuilder.Entity<vw_EventRequirementView>(entity =>
        {
            entity.ToView("vw_EventRequirementView", "cnetEvent");
        });

        modelBuilder.Entity<vw_EventView>(entity =>
        {
            entity.ToView("vw_EventView", "common");
        });

        modelBuilder.Entity<vw_Extension>(entity =>
        {
            entity.ToView("vw_Extensions", "pos");
        });

        modelBuilder.Entity<vw_FirstActivityVoucher>(entity =>
        {
            entity.ToView("vw_FirstActivityVoucher", "common");
        });

        modelBuilder.Entity<vw_FirstLineItemArticle>(entity =>
        {
            entity.ToView("vw_FirstLineItemArticle", "common");
        });

        modelBuilder.Entity<vw_FirstNonCashTransaction>(entity =>
        {
            entity.ToView("vw_FirstNonCashTransaction", "common");
        });

        modelBuilder.Entity<vw_FirstPlacement>(entity =>
        {
            entity.ToView("vw_FirstPlacement", "common");
        });

        modelBuilder.Entity<vw_FirstPlacementDate>(entity =>
        {
            entity.ToView("vw_FirstPlacementDate", "hrms");
        });

        modelBuilder.Entity<vw_FirstPlacementVoucher>(entity =>
        {
            entity.ToView("vw_FirstPlacementVoucher", "hrms");
        });

        modelBuilder.Entity<vw_FixedAssetAcquisitionValue>(entity =>
        {
            entity.ToView("vw_FixedAssetAcquisitionValue", "common");
        });

        modelBuilder.Entity<vw_FixedAssetBookValue>(entity =>
        {
            entity.ToView("vw_FixedAssetBookValue", "common");
        });

        modelBuilder.Entity<vw_FixedAssetBookValueComparison>(entity =>
        {
            entity.ToView("vw_FixedAssetBookValueComparison", "common");
        });

        modelBuilder.Entity<vw_FixedAssetDepView>(entity =>
        {
            entity.ToView("vw_FixedAssetDepView", "common");
        });

        modelBuilder.Entity<vw_FixedAssetDepriciationLineItem>(entity =>
        {
            entity.ToView("vw_FixedAssetDepriciationLineItem", "common");
        });

        modelBuilder.Entity<vw_FixedAssetMarketValue>(entity =>
        {
            entity.ToView("vw_FixedAssetMarketValue", "common");
        });

        modelBuilder.Entity<vw_FixedAssetSalvageValue>(entity =>
        {
            entity.ToView("vw_FixedAssetSalvageValue", "common");
        });

        modelBuilder.Entity<vw_FormulationView>(entity =>
        {
            entity.ToView("vw_FormulationView", "common");
        });

        modelBuilder.Entity<vw_ForwardReference>(entity =>
        {
            entity.ToView("vw_ForwardReferences", "common");
        });

        modelBuilder.Entity<vw_GSLTaxList>(entity =>
        {
            entity.ToView("vw_GSLTaxList", "common");
        });

        modelBuilder.Entity<vw_GetAttachmentTypeByLookUp>(entity =>
        {
            entity.ToView("vw_GetAttachmentTypeByLookUp", "common");
        });

        modelBuilder.Entity<vw_GroupedLineitemCategory>(entity =>
        {
            entity.ToView("vw_GroupedLineitemCategory", "common");
        });

        modelBuilder.Entity<vw_GuestComment>(entity =>
        {
            entity.ToView("vw_GuestComment", "common");
        });

        modelBuilder.Entity<vw_IdentificationBioId>(entity =>
        {
            entity.ToView("vw_IdentificationBioId", "common");
        });

        modelBuilder.Entity<vw_IdentificationBiometric>(entity =>
        {
            entity.ToView("vw_IdentificationBiometric", "common");
        });

        modelBuilder.Entity<vw_IdentificationTIN>(entity =>
        {
            entity.ToView("vw_IdentificationTIN", "common");
        });

        modelBuilder.Entity<vw_IncomeTaxtransaction>(entity =>
        {
            entity.ToView("vw_IncomeTaxtransactions", "common");
        });

        modelBuilder.Entity<vw_Industry>(entity =>
        {
            entity.ToView("vw_Industries", "ecommerce");
        });

        modelBuilder.Entity<vw_IndustryInvolvedOrganization>(entity =>
        {
            entity.ToView("vw_IndustryInvolvedOrganization", "common");
        });

        modelBuilder.Entity<vw_InternalReference>(entity =>
        {
            entity.ToView("vw_InternalReference", "common");
        });

        modelBuilder.Entity<vw_ItemReconciliationUnionView>(entity =>
        {
            entity.ToView("vw_ItemReconciliationUnionView", "common");
        });

        modelBuilder.Entity<vw_ItemReconciliationView>(entity =>
        {
            entity.ToView("vw_ItemReconciliationView", "common");
        });

        modelBuilder.Entity<vw_JobCardActivityDetail>(entity =>
        {
            entity.ToView("vw_JobCardActivityDetail", "common");
        });

        modelBuilder.Entity<vw_JobCardActivityDetailRange>(entity =>
        {
            entity.ToView("vw_JobCardActivityDetailRange", "common");
        });

        modelBuilder.Entity<vw_JobCardActivityHeader>(entity =>
        {
            entity.ToView("vw_JobCardActivityHeader", "common");
        });

        modelBuilder.Entity<vw_JobCardView>(entity =>
        {
            entity.ToView("vw_JobCardView", "common");
        });

        modelBuilder.Entity<vw_JournalDetailReconcilation>(entity =>
        {
            entity.ToView("vw_JournalDetailReconcilation", "common");
        });

        modelBuilder.Entity<vw_JournalDetailTransactionReference>(entity =>
        {
            entity.ToView("vw_JournalDetailTransactionReference", "common");
        });

        modelBuilder.Entity<vw_JournalDetailView>(entity =>
        {
            entity.ToView("vw_JournalDetailView", "common");
        });

        modelBuilder.Entity<vw_JournalDoubleReference>(entity =>
        {
            entity.ToView("vw_JournalDoubleReference", "common");
        });

        modelBuilder.Entity<vw_KDSMultipleQueueView>(entity =>
        {
            entity.ToView("vw_KDSMultipleQueueView", "pos");
        });

        modelBuilder.Entity<vw_KDSOrderView>(entity =>
        {
            entity.ToView("vw_KDSOrderView", "pos");
        });

        modelBuilder.Entity<vw_KDSPreparedView>(entity =>
        {
            entity.ToView("vw_KDSPreparedView", "pos");
        });

        modelBuilder.Entity<vw_LastActivity>(entity =>
        {
            entity.ToView("vw_LastActivity", "common");
        });

        modelBuilder.Entity<vw_LastActivityArticle>(entity =>
        {
            entity.ToView("vw_LastActivityArticle", "common");
        });

        modelBuilder.Entity<vw_LastActivityOrganization>(entity =>
        {
            entity.ToView("vw_LastActivityOrganization", "common");
        });

        modelBuilder.Entity<vw_LastActivityPerson>(entity =>
        {
            entity.ToView("vw_LastActivityPerson", "common");
        });

        modelBuilder.Entity<vw_LastActivityWithObjectState>(entity =>
        {
            entity.ToView("vw_LastActivityWithObjectState", "common");
        });

        modelBuilder.Entity<vw_LastCareer>(entity =>
        {
            entity.ToView("vw_LastCareer", "hrms");
        });

        modelBuilder.Entity<vw_LastPlacement>(entity =>
        {
            entity.ToView("vw_LastPlacement", "common");
        });

        modelBuilder.Entity<vw_LastPlacementVoucher>(entity =>
        {
            entity.ToView("vw_LastPlacementVoucher", "hrms");
        });

        modelBuilder.Entity<vw_LeaveAllocationView>(entity =>
        {
            entity.ToView("vw_LeaveAllocationView", "common");
        });

        modelBuilder.Entity<vw_LeaveBalance>(entity =>
        {
            entity.ToView("vw_LeaveBalance", "hrms");
        });

        modelBuilder.Entity<vw_LeaveLineItemRef>(entity =>
        {
            entity.ToView("vw_LeaveLineItemRef", "hrms");
        });

        modelBuilder.Entity<vw_LeaveVoucherView>(entity =>
        {
            entity.ToView("vw_LeaveVoucherView", "common");
        });

        modelBuilder.Entity<vw_LedgerTransactionsView>(entity =>
        {
            entity.ToView("vw_LedgerTransactionsView", "common");
        });

        modelBuilder.Entity<vw_LedgerView>(entity =>
        {
            entity.ToView("vw_LedgerView", "common");
        });

        modelBuilder.Entity<vw_LicenseGenerationView>(entity =>
        {
            entity.ToView("vw_LicenseGenerationView", "Internal");
        });

        modelBuilder.Entity<vw_LicenseVoucher>(entity =>
        {
            entity.ToView("vw_LicenseVoucher", "common");
        });

        modelBuilder.Entity<vw_LifeSpanDetail>(entity =>
        {
            entity.ToView("vw_LifeSpanDetail", "common");
        });

        modelBuilder.Entity<vw_LineItemActDashboardDetail>(entity =>
        {
            entity.ToView("vw_LineItemActDashboardDetail", "common");
        });

        modelBuilder.Entity<vw_LineItemActivityDetail>(entity =>
        {
            entity.ToView("vw_LineItemActivityDetail", "common");
        });

        modelBuilder.Entity<vw_LineItemActivityHeader>(entity =>
        {
            entity.ToView("vw_LineItemActivityHeader", "common");
        });

        modelBuilder.Entity<vw_LineItemCategoryView>(entity =>
        {
            entity.ToView("vw_LineItemCategoryView", "common");
        });

        modelBuilder.Entity<vw_LineItemClosedJob>(entity =>
        {
            entity.ToView("vw_LineItemClosedJobs", "common");
        });

        modelBuilder.Entity<vw_LineItemCount>(entity =>
        {
            entity.ToView("vw_LineItemCount", "common");
        });

        modelBuilder.Entity<vw_LineItemJournalDetailDatum>(entity =>
        {
            entity.ToView("vw_LineItemJournalDetailData", "common");
        });

        modelBuilder.Entity<vw_LineItemLifeSpan>(entity =>
        {
            entity.ToView("vw_LineItemLifeSpan", "common");
        });

        modelBuilder.Entity<vw_LineItemModifier>(entity =>
        {
            entity.ToView("vw_LineItemModifier", "common");
        });

        modelBuilder.Entity<vw_LineItemQtySum>(entity =>
        {
            entity.ToView("vw_LineItemQtySum", "common");
        });

        modelBuilder.Entity<vw_LineItemScheduleView>(entity =>
        {
            entity.ToView("vw_LineItemScheduleView", "common");
        });

        modelBuilder.Entity<vw_LineItemSerialCode>(entity =>
        {
            entity.ToView("vw_LineItemSerialCode", "common");
        });

        modelBuilder.Entity<vw_LineitemActivityDetailRange>(entity =>
        {
            entity.ToView("vw_LineitemActivityDetailRange", "common");
        });

        modelBuilder.Entity<vw_LineitemActivityRange>(entity =>
        {
            entity.ToView("vw_LineitemActivityRange", "common");
        });

        modelBuilder.Entity<vw_LineitemActivityRangeInMin>(entity =>
        {
            entity.ToView("vw_LineitemActivityRangeInMin", "common");
        });

        modelBuilder.Entity<vw_LineitemReferrenceSummary>(entity =>
        {
            entity.ToView("vw_LineitemReferrenceSummary", "common");
        });

        modelBuilder.Entity<vw_ListOfOnceReferedVouchersbyUser>(entity =>
        {
            entity.ToView("vw_ListOfOnceReferedVouchersbyUser", "common");
        });

        modelBuilder.Entity<vw_ListOfUnReferedVoucher>(entity =>
        {
            entity.ToView("vw_ListOfUnReferedVouchers", "common");
        });

        modelBuilder.Entity<vw_LogActivity>(entity =>
        {
            entity.ToView("vw_LogActivity", "common");
        });

        modelBuilder.Entity<vw_LogisticCenter>(entity =>
        {
            entity.ToView("vw_LogisticCenter", "common");
        });

        modelBuilder.Entity<vw_MailVoucher>(entity =>
        {
            entity.ToView("vw_MailVoucher", "common");
        });

        modelBuilder.Entity<vw_MemberLogView>(entity =>
        {
            entity.ToView("vw_MemberLogView", "AccessControl");
        });

        modelBuilder.Entity<vw_MinStockLevel>(entity =>
        {
            entity.ToView("vw_MinStockLevel", "common");
        });

        modelBuilder.Entity<vw_MobileMovieCompaniesView>(entity =>
        {
            entity.ToView("vw_MobileMovieCompaniesView", "cinema");
        });

        modelBuilder.Entity<vw_MoblieMovieScheduleView>(entity =>
        {
            entity.ToView("vw_MoblieMovieScheduleView", "cinema");
        });

        modelBuilder.Entity<vw_Movie>(entity =>
        {
            entity.ToView("vw_Movies", "cinema");
        });

        modelBuilder.Entity<vw_MovieScheduleCountView>(entity =>
        {
            entity.ToView("vw_MovieScheduleCountView", "cinema");
        });

        modelBuilder.Entity<vw_MovieScheduleView>(entity =>
        {
            entity.ToView("vw_MovieScheduleView", "cinema");
        });

        modelBuilder.Entity<vw_MovieTransaction>(entity =>
        {
            entity.ToView("vw_MovieTransaction", "cinema");
        });

        modelBuilder.Entity<vw_MovieTransactionDetail>(entity =>
        {
            entity.ToView("vw_MovieTransactionDetail", "cinema");
        });

        modelBuilder.Entity<vw_MovieTransactionView>(entity =>
        {
            entity.ToView("vw_MovieTransactionView", "cinema");
        });

        modelBuilder.Entity<vw_MovieView>(entity =>
        {
            entity.ToView("vw_MovieView", "cinema");
        });

        modelBuilder.Entity<vw_MultiCompanyIndustry>(entity =>
        {
            entity.ToView("vw_MultiCompanyIndustries", "common");
        });

        modelBuilder.Entity<vw_MutliCompanyIndustriesArticleCategory>(entity =>
        {
            entity.ToView("vw_MutliCompanyIndustriesArticleCategory", "common");
        });

        modelBuilder.Entity<vw_NoCashPayment>(entity =>
        {
            entity.ToView("vw_NoCashPayment", "common");
        });

        modelBuilder.Entity<vw_NonCashPayment>(entity =>
        {
            entity.ToView("vw_NonCashPayments", "common");
        });

        modelBuilder.Entity<vw_NonCashPaymentView>(entity =>
        {
            entity.ToView("vw_NonCashPaymentView", "common");
        });

        modelBuilder.Entity<vw_NonCashTransaction>(entity =>
        {
            entity.ToView("vw_NonCashTransaction", "common");
        });

        modelBuilder.Entity<vw_NonCashTransactionView>(entity =>
        {
            entity.ToView("vw_NonCashTransactionView", "common");
        });

        modelBuilder.Entity<vw_NonLineItemVoucherHeader>(entity =>
        {
            entity.ToView("vw_NonLineItemVoucherHeader", "common");
        });

        modelBuilder.Entity<vw_NonTaxableTransaction>(entity =>
        {
            entity.ToView("vw_NonTaxableTransactions", "common");
        });

        modelBuilder.Entity<vw_OrgMapper>(entity =>
        {
            entity.ToView("vw_OrgMapper", "common");
        });

        modelBuilder.Entity<vw_OrgPrefNoCatagory>(entity =>
        {
            entity.ToView("vw_OrgPrefNoCatagory", "common");
        });

        modelBuilder.Entity<vw_OrgUnitDefView>(entity =>
        {
            entity.ToView("vw_OrgUnitDefView", "common");
        });

        modelBuilder.Entity<vw_OrgWithIdentification>(entity =>
        {
            entity.ToView("vw_OrgWithIdentification", "common");
        });

        modelBuilder.Entity<vw_OrgaUnitDevice>(entity =>
        {
            entity.ToView("vw_OrgaUnitDevices", "common");
        });

        modelBuilder.Entity<vw_OrganizationActivity>(entity =>
        {
            entity.ToView("vw_OrganizationActivity", "common");
        });

        modelBuilder.Entity<vw_OrganizationCity>(entity =>
        {
            entity.ToView("vw_OrganizationCity", "common");
        });

        modelBuilder.Entity<vw_OrganizationCountry>(entity =>
        {
            entity.ToView("vw_OrganizationCountry", "common");
        });

        modelBuilder.Entity<vw_OrganizationHeader>(entity =>
        {
            entity.ToView("vw_OrganizationHeader", "common");
        });

        modelBuilder.Entity<vw_OrganizationIdentification>(entity =>
        {
            entity.ToView("vw_OrganizationIdentification", "common");
        });

        modelBuilder.Entity<vw_OrganizationRelation>(entity =>
        {
            entity.ToView("vw_OrganizationRelations", "common");
        });

        modelBuilder.Entity<vw_OrganizationStructure>(entity =>
        {
            entity.ToView("vw_OrganizationStructure", "common");
        });

        modelBuilder.Entity<vw_OrganizationTIN>(entity =>
        {
            entity.ToView("vw_OrganizationTIN", "common");
        });

        modelBuilder.Entity<vw_OrganizationTelephone>(entity =>
        {
            entity.ToView("vw_OrganizationTelephone", "common");
        });

        modelBuilder.Entity<vw_OrganizationView>(entity =>
        {
            entity.ToView("vw_OrganizationView", "common");
        });

        modelBuilder.Entity<vw_OrganizationWithAccountMap>(entity =>
        {
            entity.ToView("vw_OrganizationWithAccountMap", "common");
        });

        modelBuilder.Entity<vw_OrganizationsOwner>(entity =>
        {
            entity.ToView("vw_OrganizationsOwners", "common");
        });

        modelBuilder.Entity<vw_OtherConsigneeFirst>(entity =>
        {
            entity.ToView("vw_OtherConsigneeFirst", "common");
        });

        modelBuilder.Entity<vw_OtherConsigneeSecond>(entity =>
        {
            entity.ToView("vw_OtherConsigneeSecond", "common");
        });

        modelBuilder.Entity<vw_OtherConsigneeThird>(entity =>
        {
            entity.ToView("vw_OtherConsigneeThird", "common");
        });

        modelBuilder.Entity<vw_OtherConsigneeView>(entity =>
        {
            entity.ToView("vw_OtherConsigneeView", "common");
        });

        modelBuilder.Entity<vw_OvertimeDetailView>(entity =>
        {
            entity.ToView("vw_OvertimeDetailView", "common");
        });

        modelBuilder.Entity<vw_OvertimeView>(entity =>
        {
            entity.ToView("vw_OvertimeView", "common");
        });

        modelBuilder.Entity<vw_POSArticleView>(entity =>
        {
            entity.ToView("vw_POSArticleView", "pos");
        });

        modelBuilder.Entity<vw_PackageView>(entity =>
        {
            entity.ToView("vw_PackageView", "PMS");
        });

        modelBuilder.Entity<vw_PayrollEmployeeView>(entity =>
        {
            entity.ToView("vw_PayrollEmployeeView", "common");
        });

        modelBuilder.Entity<vw_PayrollSlip>(entity =>
        {
            entity.ToView("vw_PayrollSlip", "common");
        });

        modelBuilder.Entity<vw_PerPrefNoCatagory>(entity =>
        {
            entity.ToView("vw_PerPrefNoCatagory", "common");
        });

        modelBuilder.Entity<vw_PersionNationalityView>(entity =>
        {
            entity.ToView("vw_PersionNationalityView", "common");
        });

        modelBuilder.Entity<vw_Person>(entity =>
        {
            entity.ToView("vw_Person", "hrms");
        });

        modelBuilder.Entity<vw_PersonActivity>(entity =>
        {
            entity.ToView("vw_PersonActivity", "common");
        });

        modelBuilder.Entity<vw_PersonDashboard>(entity =>
        {
            entity.ToView("vw_PersonDashboard", "hrms");
        });

        modelBuilder.Entity<vw_PersonHeader>(entity =>
        {
            entity.ToView("vw_PersonHeader", "common");
        });

        modelBuilder.Entity<vw_PersonTelephone>(entity =>
        {
            entity.ToView("vw_PersonTelephone", "common");
        });

        modelBuilder.Entity<vw_PersonView>(entity =>
        {
            entity.ToView("vw_PersonView", "common");
        });

        modelBuilder.Entity<vw_PersonWithAccountMap>(entity =>
        {
            entity.ToView("vw_PersonWithAccountMap", "common");
        });

        modelBuilder.Entity<vw_PersonnelList>(entity =>
        {
            entity.ToView("vw_PersonnelList", "common");
        });

        modelBuilder.Entity<vw_Personview1>(entity =>
        {
            entity.ToView("vw_Personview", "PMS");
        });

        modelBuilder.Entity<vw_PlacementEmploymentDate>(entity =>
        {
            entity.ToView("vw_PlacementEmploymentDate", "hrms");
        });

        modelBuilder.Entity<vw_PlacementTransferView>(entity =>
        {
            entity.ToView("vw_PlacementTransferView", "hrms");
        });

        modelBuilder.Entity<vw_PlacementVoucher>(entity =>
        {
            entity.ToView("vw_PlacementVoucher", "hrms");
        });

        modelBuilder.Entity<vw_PlanAndbudget>(entity =>
        {
            entity.ToView("vw_PlanAndbudget", "common");
        });

        modelBuilder.Entity<vw_PoliceView>(entity =>
        {
            entity.ToView("vw_PoliceView", "PMS");
        });

        modelBuilder.Entity<vw_PreferenceWithDevice>(entity =>
        {
            entity.ToView("vw_PreferenceWithDevice", "common");
        });

        modelBuilder.Entity<vw_ProductionReferenceView>(entity =>
        {
            entity.ToView("vw_ProductionReferenceView", "common");
        });

        modelBuilder.Entity<vw_ProductionView>(entity =>
        {
            entity.ToView("vw_ProductionView", "common");
        });

        modelBuilder.Entity<vw_ProfitabilityReport>(entity =>
        {
            entity.ToView("vw_ProfitabilityReport", "common");
        });

        modelBuilder.Entity<vw_ProgressTaxRate>(entity =>
        {
            entity.ToView("vw_ProgressTaxRate", "common");
        });

        modelBuilder.Entity<vw_ProjectReportVoucher>(entity =>
        {
            entity.ToView("vw_ProjectReportVoucher", "common");
        });

        modelBuilder.Entity<vw_ProjectView>(entity =>
        {
            entity.ToView("vw_ProjectView", "Internal");
        });

        modelBuilder.Entity<vw_ProjectVoucherDetail>(entity =>
        {
            entity.ToView("vw_ProjectVoucherDetails", "common");
        });

        modelBuilder.Entity<vw_PromotionReportView>(entity =>
        {
            entity.ToView("vw_PromotionReportView", "hrms");
        });

        modelBuilder.Entity<vw_PurchasedArticle>(entity =>
        {
            entity.ToView("vw_PurchasedArticle", "common");
        });

        modelBuilder.Entity<vw_RMSExtension>(entity =>
        {
            entity.ToView("vw_RMSExtension", "pos");
        });

        modelBuilder.Entity<vw_RMSHeldView>(entity =>
        {
            entity.ToView("vw_RMSHeldView", "pos");
        });

        modelBuilder.Entity<vw_RateAdjustment>(entity =>
        {
            entity.ToView("vw_RateAdjustment", "PMS");
        });

        modelBuilder.Entity<vw_RateComponent>(entity =>
        {
            entity.ToView("vw_RateComponent", "PMS");
        });

        modelBuilder.Entity<vw_RateStrategyView>(entity =>
        {
            entity.ToView("vw_RateStrategyView", "PMS");
        });

        modelBuilder.Entity<vw_ReferenceTreeView>(entity =>
        {
            entity.ToView("vw_ReferenceTreeView", "common");
        });

        modelBuilder.Entity<vw_ReferencedVoucherHeader>(entity =>
        {
            entity.ToView("vw_ReferencedVoucherHeader", "common");
        });

        modelBuilder.Entity<vw_RefernceObjectState>(entity =>
        {
            entity.ToView("vw_RefernceObjectStates", "common");
        });

        modelBuilder.Entity<vw_RegistrationDetailView>(entity =>
        {
            entity.ToView("vw_RegistrationDetailView", "PMS");
        });

        modelBuilder.Entity<vw_RegistrationDetailWithMonth>(entity =>
        {
            entity.ToView("vw_RegistrationDetailWithMonth", "PMS");
        });

        modelBuilder.Entity<vw_RegistrationDocument>(entity =>
        {
            entity.ToView("vw_RegistrationDocument", "PMS");
        });

        modelBuilder.Entity<vw_RegistrationDocumentView>(entity =>
        {
            entity.ToView("vw_RegistrationDocumentView", "PMS");
        });

        modelBuilder.Entity<vw_RegistrationOperation>(entity =>
        {
            entity.ToView("vw_RegistrationOperations", "PMS");
        });

        modelBuilder.Entity<vw_RegistrationTransaction>(entity =>
        {
            entity.ToView("vw_RegistrationTransaction", "PMS");
        });

        modelBuilder.Entity<vw_RelationDetail>(entity =>
        {
            entity.ToView("vw_RelationDetail", "common");
        });

        modelBuilder.Entity<vw_RemovedItem>(entity =>
        {
            entity.ToView("vw_RemovedItems", "common");
        });

        modelBuilder.Entity<vw_ReportView>(entity =>
        {
            entity.ToView("vw_ReportView", "common");
        });

        modelBuilder.Entity<vw_RequiredGSL>(entity =>
        {
            entity.ToView("vw_RequiredGSL", "common");
        });

        modelBuilder.Entity<vw_Reservation>(entity =>
        {
            entity.ToView("vw_Reservation", "cnetEvent");

            entity.Property(e => e.description).IsFixedLength();
        });

        modelBuilder.Entity<vw_ResidentID>(entity =>
        {
            entity.ToView("vw_ResidentID", "common");
        });

        modelBuilder.Entity<vw_RevenuePostView>(entity =>
        {
            entity.ToView("vw_RevenuePostView", "common");
        });

        modelBuilder.Entity<vw_RoomDetailView>(entity =>
        {
            entity.ToView("vw_RoomDetailView", "PMS");
        });

        modelBuilder.Entity<vw_RoomFeature>(entity =>
        {
            entity.ToView("vw_RoomFeature", "PMS");
        });

        modelBuilder.Entity<vw_RoomIncome>(entity =>
        {
            entity.ToView("vw_RoomIncome", "PMS");
        });

        modelBuilder.Entity<vw_RouteView>(entity =>
        {
            entity.ToView("vw_RouteView", "common");
        });

        modelBuilder.Entity<vw_SEMId>(entity =>
        {
            entity.ToView("vw_SEMId", "common");
        });

        modelBuilder.Entity<vw_SEM_IDView>(entity =>
        {
            entity.ToView("vw_SEM_IDView");
        });

        modelBuilder.Entity<vw_SRV_GRV>(entity =>
        {
            entity.ToView("vw_SRV_GRV", "common");
        });

        modelBuilder.Entity<vw_SalesCoverView>(entity =>
        {
            entity.ToView("vw_SalesCoverView", "pos");
        });

        modelBuilder.Entity<vw_SalesReportByCategoryAndBrand>(entity =>
        {
            entity.ToView("vw_SalesReportByCategoryAndBrand", "common");
        });

        modelBuilder.Entity<vw_SalesReportBySupplier>(entity =>
        {
            entity.ToView("vw_SalesReportBySupplier", "common");
        });

        modelBuilder.Entity<vw_SalesReportForERCA>(entity =>
        {
            entity.ToView("vw_SalesReportForERCA", "common");
        });

        modelBuilder.Entity<vw_Sales_by_Timestamp>(entity =>
        {
            entity.ToView("vw_Sales_by_Timestamp", "common");
        });

        modelBuilder.Entity<vw_ScheduleValueView>(entity =>
        {
            entity.ToView("vw_ScheduleValueView", "common");
        });

        modelBuilder.Entity<vw_SecurityRoleAcessPrevilege>(entity =>
        {
            entity.ToView("vw_SecurityRoleAcessPrevilege", "common");
        });

        modelBuilder.Entity<vw_SecurityRoleActivityPrevilege>(entity =>
        {
            entity.ToView("vw_SecurityRoleActivityPrevilege", "common");
        });

        modelBuilder.Entity<vw_SecurityRoleReport>(entity =>
        {
            entity.ToView("vw_SecurityRoleReport", "common");
        });

        modelBuilder.Entity<vw_SecurityUserRoleMembership>(entity =>
        {
            entity.ToView("vw_SecurityUserRoleMembership", "common");
        });

        modelBuilder.Entity<vw_SelectAllMoviesView>(entity =>
        {
            entity.ToView("vw_SelectAllMoviesView", "cinema");
        });

        modelBuilder.Entity<vw_SequencedLastActivity>(entity =>
        {
            entity.ToView("vw_SequencedLastActivity", "common");
        });

        modelBuilder.Entity<vw_SerialCodeDescription>(entity =>
        {
            entity.ToView("vw_SerialCodeDescription", "common");
        });

        modelBuilder.Entity<vw_SerialCodeLifeSpan>(entity =>
        {
            entity.ToView("vw_SerialCodeLifeSpan", "common");
        });

        modelBuilder.Entity<vw_ServiceConsignee>(entity =>
        {
            entity.ToView("vw_ServiceConsignee", "common");
        });

        modelBuilder.Entity<vw_ServiceLineItemExtDetail>(entity =>
        {
            entity.ToView("vw_ServiceLineItemExtDetail", "common");
        });

        modelBuilder.Entity<vw_ShiftClosing>(entity =>
        {
            entity.ToView("vw_ShiftClosing", "pos");
        });

        modelBuilder.Entity<vw_ShiftClosingVoucherDetail>(entity =>
        {
            entity.ToView("vw_ShiftClosingVoucherDetail", "pos");
        });

        modelBuilder.Entity<vw_SoldArticlesView>(entity =>
        {
            entity.ToView("vw_SoldArticlesView", "common");
        });

        modelBuilder.Entity<vw_StoreTransactionView>(entity =>
        {
            entity.ToView("vw_StoreTransactionView", "common");
        });

        modelBuilder.Entity<vw_SubscriptionAgingView>(entity =>
        {
            entity.ToView("vw_SubscriptionAgingView", "AccessControl");
        });

        modelBuilder.Entity<vw_SubscriptionLogView>(entity =>
        {
            entity.ToView("vw_SubscriptionLogView", "AccessControl");
        });

        modelBuilder.Entity<vw_SummarizedReferenceView>(entity =>
        {
            entity.ToView("vw_SummarizedReferenceView", "common");
        });

        modelBuilder.Entity<vw_SummaryOfHRExpense>(entity =>
        {
            entity.ToView("vw_SummaryOfHRExpense", "hrms");
        });

        modelBuilder.Entity<vw_SuspensionView>(entity =>
        {
            entity.ToView("vw_SuspensionView", "hrms");
        });

        modelBuilder.Entity<vw_SyncDistributionView>(entity =>
        {
            entity.ToView("vw_SyncDistributionView", "common");
        });

        modelBuilder.Entity<vw_TOT1transaction>(entity =>
        {
            entity.ToView("vw_TOT1transactions", "common");
        });

        modelBuilder.Entity<vw_TOT2transaction>(entity =>
        {
            entity.ToView("vw_TOT2transactions", "common");
        });

        modelBuilder.Entity<vw_TaskControlView>(entity =>
        {
            entity.ToView("vw_TaskControlView", "common");
        });

        modelBuilder.Entity<vw_TaskFollowUpAndReport>(entity =>
        {
            entity.ToView("vw_TaskFollowUpAndReport", "common");
        });

        modelBuilder.Entity<vw_TaskFollowUpAndReportWithLineItem>(entity =>
        {
            entity.ToView("vw_TaskFollowUpAndReportWithLineItem", "common");
        });

        modelBuilder.Entity<vw_TaskIssueDetail>(entity =>
        {
            entity.ToView("vw_TaskIssueDetail", "common");
        });

        modelBuilder.Entity<vw_TaskVoucherDetail>(entity =>
        {
            entity.ToView("vw_TaskVoucherDetails", "common");
        });

        modelBuilder.Entity<vw_TaxTransactionView>(entity =>
        {
            entity.ToView("vw_TaxTransactionView", "common");
        });

        modelBuilder.Entity<vw_TelephoneAddress>(entity =>
        {
            entity.ToView("vw_TelephoneAddress", "common");
        });

        modelBuilder.Entity<vw_TerminatedEmployeeView>(entity =>
        {
            entity.ToView("vw_TerminatedEmployeeView", "hrms");
        });

        modelBuilder.Entity<vw_TerminatedNonClearedEmployee>(entity =>
        {
            entity.ToView("vw_TerminatedNonClearedEmployee", "hrms");
        });

        modelBuilder.Entity<vw_TerminatedPayrollHistory>(entity =>
        {
            entity.ToView("vw_TerminatedPayrollHistory", "hrms");
        });

        modelBuilder.Entity<vw_TerminationView>(entity =>
        {
            entity.ToView("vw_TerminationView", "hrms");
        });

        modelBuilder.Entity<vw_TimeSheet>(entity =>
        {
            entity.ToView("vw_TimeSheet", "common");
        });

        modelBuilder.Entity<vw_TotalJobCardTime>(entity =>
        {
            entity.ToView("vw_TotalJobCardTime", "common");
        });

        modelBuilder.Entity<vw_TransactionCloudSync>(entity =>
        {
            entity.ToView("vw_TransactionCloudSync", "common");
        });

        modelBuilder.Entity<vw_TravelDetail>(entity =>
        {
            entity.ToView("vw_TravelDetail", "PMS");
        });

        modelBuilder.Entity<vw_TravelDetailView>(entity =>
        {
            entity.ToView("vw_TravelDetailView", "hrms");
        });

        modelBuilder.Entity<vw_TrialBalanceView>(entity =>
        {
            entity.ToView("vw_TrialBalanceView", "common");
        });

        modelBuilder.Entity<vw_UserRoleWithActivityDefn>(entity =>
        {
            entity.ToView("vw_UserRoleWithActivityDefn", "common");
        });

        modelBuilder.Entity<vw_UserRoleWithFunctionalityAccessLevel>(entity =>
        {
            entity.ToView("vw_UserRoleWithFunctionalityAccessLevel", "common");
        });

        modelBuilder.Entity<vw_UserRoleWithReportAccessLevel>(entity =>
        {
            entity.ToView("vw_UserRoleWithReportAccessLevel", "common");
        });

        modelBuilder.Entity<vw_VATtransaction>(entity =>
        {
            entity.ToView("vw_VATtransactions", "common");
        });

        modelBuilder.Entity<vw_ValueHistoryView>(entity =>
        {
            entity.ToView("vw_ValueHistoryView", "common");
        });

        modelBuilder.Entity<vw_Voucher>(entity =>
        {
            entity.ToView("vw_Voucher", "common");
        });

        modelBuilder.Entity<vw_VoucherActivityView>(entity =>
        {
            entity.ToView("vw_VoucherActivityView", "common");
        });

        modelBuilder.Entity<vw_VoucherArticle>(entity =>
        {
            entity.ToView("vw_VoucherArticle", "common");
        });

        modelBuilder.Entity<vw_VoucherBySupplier>(entity =>
        {
            entity.ToView("vw_VoucherBySupplier", "common");
        });

        modelBuilder.Entity<vw_VoucherCalculatedValue>(entity =>
        {
            entity.ToView("vw_VoucherCalculatedValue", "common");
        });

        modelBuilder.Entity<vw_VoucherConsignee>(entity =>
        {
            entity.ToView("vw_VoucherConsignee", "common");
        });

        modelBuilder.Entity<vw_VoucherCurrencyView>(entity =>
        {
            entity.ToView("vw_VoucherCurrencyView", "common");
        });

        modelBuilder.Entity<vw_VoucherCustomer>(entity =>
        {
            entity.ToView("vw_VoucherCustomer", "pos");
        });

        modelBuilder.Entity<vw_VoucherDetailByWaiterName>(entity =>
        {
            entity.ToView("vw_VoucherDetailByWaiterName", "common");
        });

        modelBuilder.Entity<vw_VoucherDetailCCRView>(entity =>
        {
            entity.ToView("vw_VoucherDetailCCRView", "common");
        });

        modelBuilder.Entity<vw_VoucherDetailDisandAcharge>(entity =>
        {
            entity.ToView("vw_VoucherDetailDisandAcharge", "common");
        });

        modelBuilder.Entity<vw_VoucherDetailView>(entity =>
        {
            entity.ToView("vw_VoucherDetailView", "common");
        });

        modelBuilder.Entity<vw_VoucherDetailViewWithArticle>(entity =>
        {
            entity.ToView("vw_VoucherDetailViewWithArticle", "common");
        });

        modelBuilder.Entity<vw_VoucherDetailWithPaymentMethod>(entity =>
        {
            entity.ToView("vw_VoucherDetailWithPaymentMethod", "common");
        });

        modelBuilder.Entity<vw_VoucherDetailWithRoomDetail>(entity =>
        {
            entity.ToView("vw_VoucherDetailWithRoomDetail", "PMS");
        });

        modelBuilder.Entity<vw_VoucherDetailWithTransactionReference>(entity =>
        {
            entity.ToView("vw_VoucherDetailWithTransactionReference", "PMS");
        });

        modelBuilder.Entity<vw_VoucherExtensionFirst>(entity =>
        {
            entity.ToView("vw_VoucherExtensionFirst", "common");
        });

        modelBuilder.Entity<vw_VoucherExtensionFourth>(entity =>
        {
            entity.ToView("vw_VoucherExtensionFourth", "common");
        });

        modelBuilder.Entity<vw_VoucherExtensionSecond>(entity =>
        {
            entity.ToView("vw_VoucherExtensionSecond", "common");
        });

        modelBuilder.Entity<vw_VoucherExtensionThird>(entity =>
        {
            entity.ToView("vw_VoucherExtensionThird", "common");
        });

        modelBuilder.Entity<vw_VoucherExtensionTransactionView>(entity =>
        {
            entity.ToView("vw_VoucherExtensionTransactionView", "common");
        });

        modelBuilder.Entity<vw_VoucherHeader>(entity =>
        {
            entity.ToView("vw_VoucherHeader", "common");
        });

        modelBuilder.Entity<vw_VoucherHeaderCCRView>(entity =>
        {
            entity.ToView("vw_VoucherHeaderCCRView", "common");
        });

        modelBuilder.Entity<vw_VoucherHeaderLight>(entity =>
        {
            entity.ToView("vw_VoucherHeaderLight", "common");
        });

        modelBuilder.Entity<vw_VoucherHeaderMedium>(entity =>
        {
            entity.ToView("vw_VoucherHeaderMedium", "common");
        });

        modelBuilder.Entity<vw_VoucherHeaderReferenceView>(entity =>
        {
            entity.ToView("vw_VoucherHeaderReferenceView", "common");
        });

        modelBuilder.Entity<vw_VoucherHeaderView>(entity =>
        {
            entity.ToView("vw_VoucherHeaderView", "common");
        });

        modelBuilder.Entity<vw_VoucherHeaderViewWithArticle>(entity =>
        {
            entity.ToView("vw_VoucherHeaderViewWithArticle", "common");
        });

        modelBuilder.Entity<vw_VoucherHeaderViewWithOtherConsignee>(entity =>
        {
            entity.ToView("vw_VoucherHeaderViewWithOtherConsignees", "common");
        });

        modelBuilder.Entity<vw_VoucherHeaderWithRoomNo>(entity =>
        {
            entity.ToView("vw_VoucherHeaderWithRoomNo", "PMS");
        });

        modelBuilder.Entity<vw_VoucherHeaderWithTransactionReference>(entity =>
        {
            entity.ToView("vw_VoucherHeaderWithTransactionReference", "PMS");
        });

        modelBuilder.Entity<vw_VoucherIntegrityView>(entity =>
        {
            entity.ToView("vw_VoucherIntegrityView", "common");
        });

        modelBuilder.Entity<vw_VoucherLineItemDetail>(entity =>
        {
            entity.ToView("vw_VoucherLineItemDetail", "common");
        });

        modelBuilder.Entity<vw_VoucherOrgIdentification>(entity =>
        {
            entity.ToView("vw_VoucherOrgIdentification", "common");
        });

        modelBuilder.Entity<vw_VoucherOrganizationView>(entity =>
        {
            entity.ToView("vw_VoucherOrganizationView", "common");
        });

        modelBuilder.Entity<vw_VoucherPersonView>(entity =>
        {
            entity.ToView("vw_VoucherPersonView", "common");
        });

        modelBuilder.Entity<vw_VoucherReconcilationByArticle>(entity =>
        {
            entity.ToView("vw_VoucherReconcilationByArticle", "common");
        });

        modelBuilder.Entity<vw_VoucherReferenceSummary>(entity =>
        {
            entity.ToView("vw_VoucherReferenceSummary", "common");
        });

        modelBuilder.Entity<vw_VoucherReferenceView>(entity =>
        {
            entity.ToView("vw_VoucherReferenceView", "common");
        });

        modelBuilder.Entity<vw_VoucherReferenced>(entity =>
        {
            entity.ToView("vw_VoucherReferenced", "common");
        });

        modelBuilder.Entity<vw_VoucherReportDetailView>(entity =>
        {
            entity.ToView("vw_VoucherReportDetailView");
        });

        modelBuilder.Entity<vw_VoucherTaxSummaryView>(entity =>
        {
            entity.ToView("vw_VoucherTaxSummaryView", "common");
        });

        modelBuilder.Entity<vw_VoucherTaxSummaryWithTransactionReference>(entity =>
        {
            entity.ToView("vw_VoucherTaxSummaryWithTransactionReference", "PMS");
        });

        modelBuilder.Entity<vw_VoucherTaxTransaction>(entity =>
        {
            entity.ToView("vw_VoucherTaxTransaction", "common");
        });

        modelBuilder.Entity<vw_VoucherTaxTransactionReference>(entity =>
        {
            entity.ToView("vw_VoucherTaxTransactionReference", "PMS");
        });

        modelBuilder.Entity<vw_VoucherTermView>(entity =>
        {
            entity.ToView("vw_VoucherTermView", "common");
        });

        modelBuilder.Entity<vw_VoucherTransactionBranch>(entity =>
        {
            entity.ToView("vw_VoucherTransactionBranch");
        });

        modelBuilder.Entity<vw_VoucherUserNameDetailView>(entity =>
        {
            entity.ToView("vw_VoucherUserNameDetailView", "common");
        });

        modelBuilder.Entity<vw_VoucherValuePeriodView>(entity =>
        {
            entity.ToView("vw_VoucherValuePeriodView", "common");
        });

        modelBuilder.Entity<vw_VoucherValueSummaryView>(entity =>
        {
            entity.ToView("vw_VoucherValueSummaryView", "common");
        });

        modelBuilder.Entity<vw_VoucherWithGrade>(entity =>
        {
            entity.ToView("vw_VoucherWithGrade", "common");
        });

        modelBuilder.Entity<vw_WaiterEfficencyView>(entity =>
        {
            entity.ToView("vw_WaiterEfficencyView", "common");
        });

        modelBuilder.Entity<vw_WithholdingPostView>(entity =>
        {
            entity.ToView("vw_WithholdingPostView", "common");
        });

        modelBuilder.Entity<vw_WithholdingTransaction>(entity =>
        {
            entity.ToView("vw_WithholdingTransactions", "common");
        });

        modelBuilder.Entity<vw_WithholdingView>(entity =>
        {
            entity.ToView("vw_WithholdingView", "common");
        });

        modelBuilder.Entity<vw_WorkFlowAndActivity>(entity =>
        {
            entity.ToView("vw_WorkFlowAndActivity", "common");
        });

        modelBuilder.Entity<vw_WorkFlowByReferenceView>(entity =>
        {
            entity.ToView("vw_WorkFlowByReferenceView", "common");
        });

        modelBuilder.Entity<vw_WorkflowKey>(entity =>
        {
            entity.ToView("vw_WorkflowKey", "common");
        });

        modelBuilder.Entity<vw_accountMapOrgUnit>(entity =>
        {
            entity.ToView("vw_accountMapOrgUnit", "common");
        });

        modelBuilder.Entity<vw_accountOrganization>(entity =>
        {
            entity.ToView("vw_accountOrganization", "common");
        });

        modelBuilder.Entity<vw_agingIssuedTransactionReference>(entity =>
        {
            entity.ToView("vw_agingIssuedTransactionReference", "common");
        });

        modelBuilder.Entity<vw_allAddressView>(entity =>
        {
            entity.ToView("vw_allAddressView", "common");
        });

        modelBuilder.Entity<vw_articleWithpreference>(entity =>
        {
            entity.ToView("vw_articleWithpreference", "common");
        });

        modelBuilder.Entity<vw_attendanceExceptionDetail>(entity =>
        {
            entity.ToView("vw_attendanceExceptionDetail", "hrms");
        });

        modelBuilder.Entity<vw_attendanceModification>(entity =>
        {
            entity.ToView("vw_attendanceModification", "hrms");
        });

        modelBuilder.Entity<vw_attendanceSummary>(entity =>
        {
            entity.ToView("vw_attendanceSummary", "hrms");
        });

        modelBuilder.Entity<vw_bankAccountDetail>(entity =>
        {
            entity.ToView("vw_bankAccountDetail", "common");
        });

        modelBuilder.Entity<vw_bankBegView>(entity =>
        {
            entity.ToView("vw_bankBegView", "common");
        });

        modelBuilder.Entity<vw_bankBeginning>(entity =>
        {
            entity.ToView("vw_bankBeginning", "common");
        });

        modelBuilder.Entity<vw_bincardSummaryView>(entity =>
        {
            entity.ToView("vw_bincardSummaryView", "common");
        });

        modelBuilder.Entity<vw_branch_view>(entity =>
        {
            entity.ToView("vw_branch_view", "ecommerce");
        });

        modelBuilder.Entity<vw_chartOfAccountDetail>(entity =>
        {
            entity.ToView("vw_chartOfAccountDetail", "common");
        });

        modelBuilder.Entity<vw_childPrentPreferenceAccountMap>(entity =>
        {
            entity.ToView("vw_childPrentPreferenceAccountMap", "common");
        });

        modelBuilder.Entity<vw_companyRating>(entity =>
        {
            entity.ToView("vw_companyRating", "common");
        });

        modelBuilder.Entity<vw_configOstate>(entity =>
        {
            entity.ToView("vw_configOstate", "common");
        });

        modelBuilder.Entity<vw_consolidatedDeliveryDispatchView>(entity =>
        {
            entity.ToView("vw_consolidatedDeliveryDispatchView", "ecommerce");
        });

        modelBuilder.Entity<vw_consolidatedItemView>(entity =>
        {
            entity.ToView("vw_consolidatedItemView", "common");
        });

        modelBuilder.Entity<vw_consolidated_branch_view>(entity =>
        {
            entity.ToView("vw_consolidated_branch_view", "ecommerce");
        });

        modelBuilder.Entity<vw_consolidated_order_noncash_transaction_view>(entity =>
        {
            entity.ToView("vw_consolidated_order_noncash_transaction_view", "ecommerce");
        });

        modelBuilder.Entity<vw_consolidated_product_company_review_view>(entity =>
        {
            entity.ToView("vw_consolidated_product_company_review_view", "ecommerce");
        });

        modelBuilder.Entity<vw_consolidated_sales_noncash_transaction_view>(entity =>
        {
            entity.ToView("vw_consolidated_sales_noncash_transaction_view", "ecommerce");
        });

        modelBuilder.Entity<vw_consolidated_wishlist>(entity =>
        {
            entity.ToView("vw_consolidated_wishlist", "ecommerce");
        });

        modelBuilder.Entity<vw_countryAndCity>(entity =>
        {
            entity.ToView("vw_countryAndCity", "common");
        });

        modelBuilder.Entity<vw_currentPeriod>(entity =>
        {
            entity.ToView("vw_currentPeriod", "common");
        });

        modelBuilder.Entity<vw_customer_sales_route>(entity =>
        {
            entity.ToView("vw_customer_sales_route", "common");
        });

        modelBuilder.Entity<vw_dailyPackageDetail>(entity =>
        {
            entity.ToView("vw_dailyPackageDetail", "PMS");
        });

        modelBuilder.Entity<vw_dailyResidentCategoryView>(entity =>
        {
            entity.ToView("vw_dailyResidentCategoryView", "common");
        });

        modelBuilder.Entity<vw_deliveryDispatchView>(entity =>
        {
            entity.ToView("vw_deliveryDispatchView", "ecommerce");
        });

        modelBuilder.Entity<vw_deliveryOrgUnit>(entity =>
        {
            entity.ToView("vw_deliveryOrgUnit", "ecommerce");
        });

        modelBuilder.Entity<vw_depreciatedView>(entity =>
        {
            entity.ToView("vw_depreciatedView", "common");
        });

        modelBuilder.Entity<vw_discrepancy>(entity =>
        {
            entity.ToView("vw_discrepancy", "PMS");
        });

        modelBuilder.Entity<vw_displayOrderSingle>(entity =>
        {
            entity.ToView("vw_displayOrderSingle", "common");

            entity.Property(e => e.id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<vw_distinctSalesRoute>(entity =>
        {
            entity.ToView("vw_distinctSalesRoutes", "common");
        });

        modelBuilder.Entity<vw_doorLock>(entity =>
        {
            entity.ToView("vw_doorLock", "PMS");
        });

        modelBuilder.Entity<vw_eCommerce_Items_View>(entity =>
        {
            entity.ToView("vw_eCommerce_Items_View", "common");
        });

        modelBuilder.Entity<vw_ePaymentOption>(entity =>
        {
            entity.ToView("vw_ePaymentOptions", "common");
        });

        modelBuilder.Entity<vw_employeeWorkTime>(entity =>
        {
            entity.ToView("vw_employeeWorkTime", "hrms");
        });

        modelBuilder.Entity<vw_eventHeaderView>(entity =>
        {
            entity.ToView("vw_eventHeaderView", "cnetEvent");
        });

        modelBuilder.Entity<vw_expenseShareView>(entity =>
        {
            entity.ToView("vw_expenseShareView", "common");
        });

        modelBuilder.Entity<vw_fsExtensionView>(entity =>
        {
            entity.ToView("vw_fsExtensionView", "pos");
        });

        modelBuilder.Entity<vw_groupedNonCashTransaction>(entity =>
        {
            entity.ToView("vw_groupedNonCashTransaction", "common");
        });

        modelBuilder.Entity<vw_invAndCsJournalDetailAccount>(entity =>
        {
            entity.ToView("vw_invAndCsJournalDetailAccounts", "common");
        });

        modelBuilder.Entity<vw_invJournalVSinvDocument>(entity =>
        {
            entity.ToView("vw_invJournalVSinvDocument", "common");
        });

        modelBuilder.Entity<vw_journalDetailLight>(entity =>
        {
            entity.ToView("vw_journalDetailLight", "common");
        });

        modelBuilder.Entity<vw_journalDetailLineItemView>(entity =>
        {
            entity.ToView("vw_journalDetailLineItemView", "common");
        });

        modelBuilder.Entity<vw_journalIncomeAccountSummary>(entity =>
        {
            entity.ToView("vw_journalIncomeAccountSummary", "common");
        });

        modelBuilder.Entity<vw_journalIncomeStatementByBranch>(entity =>
        {
            entity.ToView("vw_journalIncomeStatementByBranch", "common");
        });

        modelBuilder.Entity<vw_journalPostView>(entity =>
        {
            entity.ToView("vw_journalPostView", "common");
        });

        modelBuilder.Entity<vw_journalVoucherReference>(entity =>
        {
            entity.ToView("vw_journalVoucherReference", "common");
        });

        modelBuilder.Entity<vw_lastPlacementDate>(entity =>
        {
            entity.ToView("vw_lastPlacementDate", "hrms");
        });

        modelBuilder.Entity<vw_latestBeginning>(entity =>
        {
            entity.ToView("vw_latestBeginning", "common");
        });

        modelBuilder.Entity<vw_latestBeginningCost>(entity =>
        {
            entity.ToView("vw_latestBeginningCost", "common");
        });

        modelBuilder.Entity<vw_latestBeginningDetail>(entity =>
        {
            entity.ToView("vw_latestBeginningDetail", "common");
        });

        modelBuilder.Entity<vw_latestBeginningForWorkingBalance>(entity =>
        {
            entity.ToView("vw_latestBeginningForWorkingBalance", "common");
        });

        modelBuilder.Entity<vw_ledgerViewByBranch>(entity =>
        {
            entity.ToView("vw_ledgerViewByBranch", "common");
        });

        modelBuilder.Entity<vw_lineitemPostView>(entity =>
        {
            entity.ToView("vw_lineitemPostView", "common");
        });

        modelBuilder.Entity<vw_order_noncash_transaction_view>(entity =>
        {
            entity.ToView("vw_order_noncash_transaction_view", "ecommerce");
        });

        modelBuilder.Entity<vw_orgGP>(entity =>
        {
            entity.ToView("vw_orgGPS", "common");
        });

        modelBuilder.Entity<vw_packageAuditView>(entity =>
        {
            entity.ToView("vw_packageAuditView", "PMS");
        });

        modelBuilder.Entity<vw_payableReceivablePostView>(entity =>
        {
            entity.ToView("vw_payableReceivablePostView", "common");
        });

        modelBuilder.Entity<vw_payrollDefinitionView>(entity =>
        {
            entity.ToView("vw_payrollDefinitionView", "hrms");
        });

        modelBuilder.Entity<vw_payrollSheetView>(entity =>
        {
            entity.ToView("vw_payrollSheetView", "hrms");
        });

        modelBuilder.Entity<vw_payrollTaxView>(entity =>
        {
            entity.ToView("vw_payrollTaxView", "hrms");
        });

        modelBuilder.Entity<vw_payrollVoucherView>(entity =>
        {
            entity.ToView("vw_payrollVoucherView", "hrms");
        });

        modelBuilder.Entity<vw_personGP>(entity =>
        {
            entity.ToView("vw_personGPS", "common");
        });

        modelBuilder.Entity<vw_personRole>(entity =>
        {
            entity.ToView("vw_personRole", "common");
        });

        modelBuilder.Entity<vw_pickupOrgUnit>(entity =>
        {
            entity.ToView("vw_pickupOrgUnit", "ecommerce");
        });

        modelBuilder.Entity<vw_pictureAttachment>(entity =>
        {
            entity.ToView("vw_pictureAttachment", "common");
        });

        modelBuilder.Entity<vw_placementBranchView>(entity =>
        {
            entity.ToView("vw_placementBranchView", "hrms");
        });

        modelBuilder.Entity<vw_placementDepartmentView>(entity =>
        {
            entity.ToView("vw_placementDepartmentView", "hrms");
        });

        modelBuilder.Entity<vw_placementRoleView>(entity =>
        {
            entity.ToView("vw_placementRoleView", "hrms");
        });

        modelBuilder.Entity<vw_placementView>(entity =>
        {
            entity.ToView("vw_placementView");
        });

        modelBuilder.Entity<vw_preparedActivity>(entity =>
        {
            entity.ToView("vw_preparedActivity", "common");
        });

        modelBuilder.Entity<vw_priceChange>(entity =>
        {
            entity.ToView("vw_priceChange", "common");
        });

        modelBuilder.Entity<vw_product_company_review_view>(entity =>
        {
            entity.ToView("vw_product_company_review_view", "ecommerce");
        });

        modelBuilder.Entity<vw_productionProcessView>(entity =>
        {
            entity.ToView("vw_productionProcessView", "common");
        });

        modelBuilder.Entity<vw_rating_identification>(entity =>
        {
            entity.ToView("vw_rating_identification", "ecommerce");
        });

        modelBuilder.Entity<vw_roomManagment>(entity =>
        {
            entity.ToView("vw_roomManagment", "PMS");
        });

        modelBuilder.Entity<vw_roomPOSCharge>(entity =>
        {
            entity.ToView("vw_roomPOSCharges", "PMS");
        });

        modelBuilder.Entity<vw_routeDetail>(entity =>
        {
            entity.ToView("vw_routeDetail", "common");
        });

        modelBuilder.Entity<vw_salesDepositView>(entity =>
        {
            entity.ToView("vw_salesDepositView", "common");
        });

        modelBuilder.Entity<vw_salesSummary>(entity =>
        {
            entity.ToView("vw_salesSummary", "PMS");
        });

        modelBuilder.Entity<vw_salesSummaryDetailView>(entity =>
        {
            entity.ToView("vw_salesSummaryDetailView", "PMS");
        });

        modelBuilder.Entity<vw_sales_noncash_transaction_view>(entity =>
        {
            entity.ToView("vw_sales_noncash_transaction_view", "ecommerce");
        });

        modelBuilder.Entity<vw_scheduleDetail>(entity =>
        {
            entity.ToView("vw_scheduleDetail", "PMS");
        });

        modelBuilder.Entity<vw_serviceRequest>(entity =>
        {
            entity.ToView("vw_serviceRequest", "PMS");
        });

        modelBuilder.Entity<vw_sessionDetail>(entity =>
        {
            entity.ToView("vw_sessionDetail", "hrms");
        });

        modelBuilder.Entity<vw_sessionShift>(entity =>
        {
            entity.ToView("vw_sessionShift", "hrms");
        });

        modelBuilder.Entity<vw_singleVoucherNote>(entity =>
        {
            entity.ToView("vw_singleVoucherNotes", "common");
        });

        modelBuilder.Entity<vw_specialStockLedgerVoucher>(entity =>
        {
            entity.ToView("vw_specialStockLedgerVouchers", "common");
        });

        modelBuilder.Entity<vw_stockConsolidatedUnionView>(entity =>
        {
            entity.ToView("vw_stockConsolidatedUnionView", "common");
        });

        modelBuilder.Entity<vw_stockConsolidatedView>(entity =>
        {
            entity.ToView("vw_stockConsolidatedView", "common");
        });

        modelBuilder.Entity<vw_stock_balance_activity>(entity =>
        {
            entity.ToView("vw_stock_balance_activity", "common");
        });

        modelBuilder.Entity<vw_taxPostView>(entity =>
        {
            entity.ToView("vw_taxPostView", "common");
        });

        modelBuilder.Entity<vw_transactionRefDetailView>(entity =>
        {
            entity.ToView("vw_transactionRefDetailView", "common");
        });

        modelBuilder.Entity<vw_turndown>(entity =>
        {
            entity.ToView("vw_turndown", "PMS");
        });

        modelBuilder.Entity<vw_usersView>(entity =>
        {
            entity.ToView("vw_usersView", "common");
        });

        modelBuilder.Entity<vw_voucherDefWithComponent>(entity =>
        {
            entity.ToView("vw_voucherDefWithComponent", "common");
        });

        modelBuilder.Entity<vw_voucherGP>(entity =>
        {
            entity.ToView("vw_voucherGPS", "common");
        });

        modelBuilder.Entity<vw_voucherOtherConsgineeFirst>(entity =>
        {
            entity.ToView("vw_voucherOtherConsgineeFirst", "common");
        });

        modelBuilder.Entity<vw_wishlist>(entity =>
        {
            entity.ToView("vw_wishlist", "ecommerce");
        });

        modelBuilder.Entity<wacCalculation_view>(entity =>
        {
            entity.ToView("wacCalculation_view", "common");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
