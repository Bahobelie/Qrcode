
using CNET_V7_Service.Contracts.SecuritySchema;
using CNET_V7_Service.Contracts.AccountingSchema;
using CNET_V7_Service.Contracts.CommonSchema;
using CNET_V7_Service.Contracts.SettingSchema;
using CNET_V7_Service.Contracts.QuestionarySchema;
using CNET_V7_Service.Contracts.ArticleSchema;
using CNET_V7_Service.Contracts.HrmsSchema;
using CNET_V7_Service.Contracts.ConsigneeSchema;
using CNET_V7_Service.Contracts.TransactionSchema;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET_V7_Service.Contracts
{
    public interface IServiceManager
    {
		IAccessMatrixService accessMatrixService { get; }
		IAccountService accountService { get; }
		IAccountMapService accountMapService { get; }
		IAcLogService acLogService { get; }
		IActivityService activityService { get; }
		IActivityDefinitionService activityDefinitionService { get; }
		IAnswerKeyService answerKeyService { get; }
		IAnswerSheetService answerSheetService { get; }
		IArticleService articleService { get; }
		IArticleUserService articleUserService { get; }
		IAttachmentService attachmentService { get; }
		IAttendanceLogService attendanceLogService { get; }
		IBankAccountDetailService bankAccountDetailService { get; }
		IBeginingBalanceService beginingBalanceService { get; }
		IBeginingTransactionService beginingTransactionService { get; }
		IBlankFillService blankFillService { get; }
		ICardService cardService { get; }
		IChooseService chooseService { get; }
		IClosedRelationService closedRelationService { get; }
		ICloudSyncService cloudSyncService { get; }
		ICnetlicenseService cnetlicenseService { get; }
		ICnetmediumService cnetmediumService { get; }
		IConfigurationService configurationService { get; }
		IConsigneeService consigneeService { get; }
		IConsigneeUnitService consigneeUnitService { get; }
		IConsigneeUserService consigneeUserService { get; }
		IControlAccountService controlAccountService { get; }
		IConversionDefinitionService conversionDefinitionService { get; }
		ICountryService countryService { get; }
		ICurrencyService currencyService { get; }
		IDelegateService delegateService { get; }
		IDenominationService denominationService { get; }
		IDenominationDetailService denominationDetailService { get; }
		IDepreciationRuleService depreciationRuleService { get; }
		IDeviceService deviceService { get; }
		IDiscountFactorService discountFactorService { get; }
		IDistributionService distributionService { get; }
		IEvaluationSheetService evaluationSheetService { get; }
		IExchangeRateService exchangeRateService { get; }
		IFieldFormatService fieldFormatService { get; }
		IFunctionalityService functionalityService { get; }
		IGslacctRequirementService gslacctRequirementService { get; }
		IGsltaxService gsltaxService { get; }
		IGsluserService gsluserService { get; }
		IHolidayService holidayService { get; }
		IHolidayDefinitionService holidayDefinitionService { get; }
		IIddefinitionService iddefinitionService { get; }
		IIdentificationService identificationService { get; }
		IIdsettingService idsettingService { get; }
		IIssuedCardService issuedCardService { get; }
		IJournalDetailService journalDetailService { get; }
		ILanguageService languageService { get; }
		ILanguagePreferenceService languagePreferenceService { get; }
		ILineItemService lineItemService { get; }
		ILineItemConversionService lineItemConversionService { get; }
		ILineItemReferenceService lineItemReferenceService { get; }
		ILineItemValueFactorService lineItemValueFactorService { get; }
		ILocationService locationService { get; }
		ILookupService lookupService { get; }
		IMenuDesignerService menuDesignerService { get; }
		IMovieService movieService { get; }
		IMovieScheduleService movieScheduleService { get; }
		INonCashTransactionService nonCashTransactionService { get; }
		IObjectStateService objectStateService { get; }
		IObjectStateDefinitionService objectStateDefinitionService { get; }
		IOrderStationMapService orderStationMapService { get; }
		IPeriodService periodService { get; }
		IPreferenceService preferenceService { get; }
		IPreferenceAccessService preferenceAccessService { get; }
		IPreferentialValueFactorService preferentialValueFactorService { get; }
		IProgressTaxRateService progressTaxRateService { get; }
		IQuestionService questionService { get; }
		IQuestionDetailService questionDetailService { get; }
		IQuestionRouterService questionRouterService { get; }
		IRangeService rangeService { get; }
		IReconciliationDetailService reconciliationDetailService { get; }
		IReconciliationSummaryService reconciliationSummaryService { get; }
		IRelationService relationService { get; }
		IRelationalStateService relationalStateService { get; }
		IReportService reportService { get; }
		IReportHistoryService reportHistoryService { get; }
		IRequiredGslService requiredGslService { get; }
		IRequiredGsldetailService requiredGsldetailService { get; }
		IRoleActivityService roleActivityService { get; }
		IRouteService routeService { get; }
		IRouteAssignmentService routeAssignmentService { get; }
		IScheduleService scheduleService { get; }
		IScheduleDetailService scheduleDetailService { get; }
		IScheduleHeaderService scheduleHeaderService { get; }
		ISeasonalMessageService seasonalMessageService { get; }
		ISeatArrangementService seatArrangementService { get; }
		ISeatTransactionService seatTransactionService { get; }
		ISerialDefinitionService serialDefinitionService { get; }
		ISpaceService spaceService { get; }
		ISpaceDirectionService spaceDirectionService { get; }
		ISpecificationService specificationService { get; }
		IStockBalanceService stockBalanceService { get; }
		IStockLevelService stockLevelService { get; }
		ISubCountryService subCountryService { get; }
		ISubtitleService subtitleService { get; }
		ISystemConstantService systemConstantService { get; }
		ITaxService taxService { get; }
		ITaxTransactionService taxTransactionService { get; }
		ITermDefinitionService termDefinitionService { get; }
		ITransactionCurrencyService transactionCurrencyService { get; }
		ITransactionLimitService transactionLimitService { get; }
		ITransactionReferenceService transactionReferenceService { get; }
		ITrialBalanceService trialBalanceService { get; }
		IUserService userService { get; }
		IUserRoleMapperService userRoleMapperService { get; }
		IValueService valueService { get; }
		IValueChangeLogService valueChangeLogService { get; }
		IValueFactorService valueFactorService { get; }
		IValueFactorDefinitionService valueFactorDefinitionService { get; }
		IValueFactorSetupService valueFactorSetupService { get; }
		IVoucherService voucherService { get; }
		IVoucherAccountService voucherAccountService { get; }
		IVoucherConsigneeListService voucherConsigneeListService { get; }
		IVoucherExtensionService voucherExtensionService { get; }
		IVoucherLookupListService voucherLookupListService { get; }
		IVoucherStoreMappingService voucherStoreMappingService { get; }
		IVoucherTermService voucherTermService { get; }
		IWriteUpService writeUpService { get; }

    }
}

    