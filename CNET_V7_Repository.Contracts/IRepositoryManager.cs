
using CNET_V7_Repository.Contracts.SecuritySchema;
using CNET_V7_Repository.Contracts.AccountingSchema;
using CNET_V7_Repository.Contracts.CommonSchema;
using CNET_V7_Repository.Contracts.SettingSchema;
using CNET_V7_Repository.Contracts.QuestionarySchema;
using CNET_V7_Repository.Contracts.ArticleSchema;
using CNET_V7_Repository.Contracts.HrmsSchema;
using CNET_V7_Repository.Contracts.ConsigneeSchema;
using CNET_V7_Repository.Contracts.TransactionSchema;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET_V7_Repository.Contracts
{
    public interface IRepositoryManager
    {
        void Save();
        
		IAccessMatrixRepository AccessMatrix { get; }

		IAccountRepository Account { get; }

		IAccountMapRepository AccountMap { get; }

		IAcLogRepository AcLog { get; }

		IActivityRepository Activity { get; }

		IActivityDefinitionRepository ActivityDefinition { get; }

		IAnswerKeyRepository AnswerKey { get; }

		IAnswerSheetRepository AnswerSheet { get; }

		IArticleRepository Article { get; }

		IArticleUserRepository ArticleUser { get; }

		IAttachmentRepository Attachment { get; }

		IAttendanceLogRepository AttendanceLog { get; }

		IBankAccountDetailRepository BankAccountDetail { get; }

		IBeginingBalanceRepository BeginingBalance { get; }

		IBeginingTransactionRepository BeginingTransaction { get; }

		IBlankFillRepository BlankFill { get; }

		ICardRepository Card { get; }

		IChooseRepository Choose { get; }

		IClosedRelationRepository ClosedRelation { get; }

		ICloudSyncRepository CloudSync { get; }

		ICnetlicenseRepository Cnetlicense { get; }

		ICnetmediumRepository Cnetmedium { get; }

		IConfigurationRepository Configuration { get; }

		IConsigneeRepository Consignee { get; }

		IConsigneeUnitRepository ConsigneeUnit { get; }

		IConsigneeUserRepository ConsigneeUser { get; }

		IControlAccountRepository ControlAccount { get; }

		IConversionDefinitionRepository ConversionDefinition { get; }

		ICountryRepository Country { get; }

		ICurrencyRepository Currency { get; }

		IDelegateRepository Delegate { get; }

		IDenominationRepository Denomination { get; }

		IDenominationDetailRepository DenominationDetail { get; }

		IDepreciationRuleRepository DepreciationRule { get; }

		IDeviceRepository Device { get; }

		IDiscountFactorRepository DiscountFactor { get; }

		IDistributionRepository Distribution { get; }

		IEvaluationSheetRepository EvaluationSheet { get; }

		IExchangeRateRepository ExchangeRate { get; }

		IFieldFormatRepository FieldFormat { get; }

		IFunctionalityRepository Functionality { get; }

		IGslacctRequirementRepository GslacctRequirement { get; }

		IGsltaxRepository Gsltax { get; }

		IGsluserRepository Gsluser { get; }

		IHolidayRepository Holiday { get; }

		IHolidayDefinitionRepository HolidayDefinition { get; }

		IIddefinitionRepository Iddefinition { get; }

		IIdentificationRepository Identification { get; }

		IIdsettingRepository Idsetting { get; }

		IIssuedCardRepository IssuedCard { get; }

		IJournalDetailRepository JournalDetail { get; }

		ILanguageRepository Language { get; }

		ILanguagePreferenceRepository LanguagePreference { get; }

		ILineItemRepository LineItem { get; }

		ILineItemConversionRepository LineItemConversion { get; }

		ILineItemReferenceRepository LineItemReference { get; }

		ILineItemValueFactorRepository LineItemValueFactor { get; }

		ILocationRepository Location { get; }

		ILookupRepository Lookup { get; }

		IMenuDesignerRepository MenuDesigner { get; }

		IMovieRepository Movie { get; }

		IMovieScheduleRepository MovieSchedule { get; }

		INonCashTransactionRepository NonCashTransaction { get; }

		IObjectStateRepository ObjectState { get; }

		IObjectStateDefinitionRepository ObjectStateDefinition { get; }

		IOrderStationMapRepository OrderStationMap { get; }

		IPeriodRepository Period { get; }

		IPreferenceRepository Preference { get; }

		IPreferenceAccessRepository PreferenceAccess { get; }

		IPreferentialValueFactorRepository PreferentialValueFactor { get; }

		IProgressTaxRateRepository ProgressTaxRate { get; }

		IQuestionRepository Question { get; }

		IQuestionDetailRepository QuestionDetail { get; }

		IQuestionRouterRepository QuestionRouter { get; }

		IRangeRepository Range { get; }

		IReconciliationDetailRepository ReconciliationDetail { get; }

		IReconciliationSummaryRepository ReconciliationSummary { get; }

		IRelationRepository Relation { get; }

		IRelationalStateRepository RelationalState { get; }

		IReportRepository Report { get; }

		IReportHistoryRepository ReportHistory { get; }

		IRequiredGslRepository RequiredGsl { get; }

		IRequiredGsldetailRepository RequiredGsldetail { get; }

		IRoleActivityRepository RoleActivity { get; }

		IRouteRepository Route { get; }

		IRouteAssignmentRepository RouteAssignment { get; }

		IScheduleRepository Schedule { get; }

		IScheduleDetailRepository ScheduleDetail { get; }

		IScheduleHeaderRepository ScheduleHeader { get; }

		ISeasonalMessageRepository SeasonalMessage { get; }

		ISeatArrangementRepository SeatArrangement { get; }

		ISeatTransactionRepository SeatTransaction { get; }

		ISerialDefinitionRepository SerialDefinition { get; }

		ISpaceRepository Space { get; }

		ISpaceDirectionRepository SpaceDirection { get; }

		ISpecificationRepository Specification { get; }

		IStockBalanceRepository StockBalance { get; }

		IStockLevelRepository StockLevel { get; }

		ISubCountryRepository SubCountry { get; }

		ISubtitleRepository Subtitle { get; }

		ISystemConstantRepository SystemConstant { get; }

		ITaxRepository Tax { get; }

		ITaxTransactionRepository TaxTransaction { get; }

		ITermDefinitionRepository TermDefinition { get; }

		ITransactionCurrencyRepository TransactionCurrency { get; }

		ITransactionLimitRepository TransactionLimit { get; }

		ITransactionReferenceRepository TransactionReference { get; }

		ITrialBalanceRepository TrialBalance { get; }

		IUserRepository User { get; }

		IUserRoleMapperRepository UserRoleMapper { get; }

		IValueRepository Value { get; }

		IValueChangeLogRepository ValueChangeLog { get; }

		IValueFactorRepository ValueFactor { get; }

		IValueFactorDefinitionRepository ValueFactorDefinition { get; }

		IValueFactorSetupRepository ValueFactorSetup { get; }

		IVoucherRepository Voucher { get; }

		IVoucherAccountRepository VoucherAccount { get; }

		IVoucherConsigneeListRepository VoucherConsigneeList { get; }

		IVoucherExtensionRepository VoucherExtension { get; }

		IVoucherLookupListRepository VoucherLookupList { get; }

		IVoucherStoreMappingRepository VoucherStoreMapping { get; }

		IVoucherTermRepository VoucherTerm { get; }

		IWriteUpRepository WriteUp { get; }

    }
}
    