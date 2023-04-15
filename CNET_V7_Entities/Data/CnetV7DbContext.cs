using System;
using System.Collections.Generic;
using CNET_V7_Entities.DataModels;
using Microsoft.EntityFrameworkCore;

namespace CNET_V7_Entities.Data;

public partial class CnetV7DbContext : DbContext
{
    public CnetV7DbContext()
    {
    }

    public CnetV7DbContext(DbContextOptions<CnetV7DbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AcLog> AcLogs { get; set; }

    public virtual DbSet<AccessMatrix> AccessMatrices { get; set; }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<AccountMap> AccountMaps { get; set; }

    public virtual DbSet<Activity> Activities { get; set; }

    public virtual DbSet<ActivityDefinition> ActivityDefinitions { get; set; }

    public virtual DbSet<AnswerKey> AnswerKeys { get; set; }

    public virtual DbSet<AnswerSheet> AnswerSheets { get; set; }

    public virtual DbSet<Article> Articles { get; set; }

    public virtual DbSet<ArticleUser> ArticleUsers { get; set; }

    public virtual DbSet<Attachment> Attachments { get; set; }

    public virtual DbSet<AttendanceLog> AttendanceLogs { get; set; }

    public virtual DbSet<BankAccountDetail> BankAccountDetails { get; set; }

    public virtual DbSet<BeginingBalance> BeginingBalances { get; set; }

    public virtual DbSet<BeginingTransaction> BeginingTransactions { get; set; }

    public virtual DbSet<BlankFill> BlankFills { get; set; }

    public virtual DbSet<Card> Cards { get; set; }

    public virtual DbSet<Choose> Chooses { get; set; }

    public virtual DbSet<ClosedRelation> ClosedRelations { get; set; }

    public virtual DbSet<CloudSync> CloudSyncs { get; set; }

    public virtual DbSet<Cnetlicense> Cnetlicenses { get; set; }

    public virtual DbSet<Cnetmedium> Cnetmedia { get; set; }

    public virtual DbSet<Configuration> Configurations { get; set; }

    public virtual DbSet<Consignee> Consignees { get; set; }

    public virtual DbSet<ConsigneeUnit> ConsigneeUnits { get; set; }

    public virtual DbSet<ConsigneeUser> ConsigneeUsers { get; set; }

    public virtual DbSet<ControlAccount> ControlAccounts { get; set; }

    public virtual DbSet<ConversionDefinition> ConversionDefinitions { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Currency> Currencies { get; set; }

    public virtual DbSet<CNET_V7_Entities.DataModels.Delegate> Delegates { get; set; }

    public virtual DbSet<Denomination> Denominations { get; set; }

    public virtual DbSet<DenominationDetail> DenominationDetails { get; set; }

    public virtual DbSet<DepreciationRule> DepreciationRules { get; set; }

    public virtual DbSet<Device> Devices { get; set; }

    public virtual DbSet<DiscountFactor> DiscountFactors { get; set; }

    public virtual DbSet<Distribution> Distributions { get; set; }

    public virtual DbSet<EvaluationSheet> EvaluationSheets { get; set; }

    public virtual DbSet<ExchangeRate> ExchangeRates { get; set; }

    public virtual DbSet<FieldFormat> FieldFormats { get; set; }

    public virtual DbSet<Functionality> Functionalities { get; set; }

    public virtual DbSet<GslacctRequirement> GslacctRequirements { get; set; }

    public virtual DbSet<Gsltax> Gsltaxes { get; set; }

    public virtual DbSet<Gsluser> Gslusers { get; set; }

    public virtual DbSet<Holiday> Holidays { get; set; }

    public virtual DbSet<HolidayDefinition> HolidayDefinitions { get; set; }

    public virtual DbSet<Iddefinition> Iddefinitions { get; set; }

    public virtual DbSet<Identification> Identifications { get; set; }

    public virtual DbSet<Idsetting> Idsettings { get; set; }

    public virtual DbSet<IssuedCard> IssuedCards { get; set; }

    public virtual DbSet<JournalDetail> JournalDetails { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<LanguagePreference> LanguagePreferences { get; set; }

    public virtual DbSet<LineItem> LineItems { get; set; }

    public virtual DbSet<LineItemConversion> LineItemConversions { get; set; }

    public virtual DbSet<LineItemReference> LineItemReferences { get; set; }

    public virtual DbSet<LineItemValueFactor> LineItemValueFactors { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<Lookup> Lookups { get; set; }

    public virtual DbSet<MenuDesigner> MenuDesigners { get; set; }

    public virtual DbSet<Movie> Movies { get; set; }

    public virtual DbSet<MovieSchedule> MovieSchedules { get; set; }

    public virtual DbSet<NonCashTransaction> NonCashTransactions { get; set; }

    public virtual DbSet<ObjectState> ObjectStates { get; set; }

    public virtual DbSet<ObjectStateDefinition> ObjectStateDefinitions { get; set; }

    public virtual DbSet<OrderStationMap> OrderStationMaps { get; set; }

    public virtual DbSet<Period> Periods { get; set; }

    public virtual DbSet<Preference> Preferences { get; set; }

    public virtual DbSet<PreferenceAccess> PreferenceAccesses { get; set; }

    public virtual DbSet<PreferentialValueFactor> PreferentialValueFactors { get; set; }

    public virtual DbSet<ProgressTaxRate> ProgressTaxRates { get; set; }

    public virtual DbSet<Question> Questions { get; set; }

    public virtual DbSet<QuestionDetail> QuestionDetails { get; set; }

    public virtual DbSet<QuestionRouter> QuestionRouters { get; set; }

    public virtual DbSet<CNET_V7_Entities.DataModels.Range> Ranges { get; set; }

    public virtual DbSet<ReconciliationDetail> ReconciliationDetails { get; set; }

    public virtual DbSet<ReconciliationSummary> ReconciliationSummaries { get; set; }

    public virtual DbSet<Relation> Relations { get; set; }

    public virtual DbSet<RelationalState> RelationalStates { get; set; }

    public virtual DbSet<Report> Reports { get; set; }

    public virtual DbSet<ReportHistory> ReportHistories { get; set; }

    public virtual DbSet<RequiredGsl> RequiredGsls { get; set; }

    public virtual DbSet<RequiredGsldetail> RequiredGsldetails { get; set; }

    public virtual DbSet<RoleActivity> RoleActivities { get; set; }

    public virtual DbSet<Route> Routes { get; set; }

    public virtual DbSet<RouteAssignment> RouteAssignments { get; set; }

    public virtual DbSet<Schedule> Schedules { get; set; }

    public virtual DbSet<ScheduleDetail> ScheduleDetails { get; set; }

    public virtual DbSet<ScheduleHeader> ScheduleHeaders { get; set; }

    public virtual DbSet<SeasonalMessage> SeasonalMessages { get; set; }

    public virtual DbSet<SeatArrangement> SeatArrangements { get; set; }

    public virtual DbSet<SeatTransaction> SeatTransactions { get; set; }

    public virtual DbSet<SerialDefinition> SerialDefinitions { get; set; }

    public virtual DbSet<Space> Spaces { get; set; }

    public virtual DbSet<SpaceDirection> SpaceDirections { get; set; }

    public virtual DbSet<Specification> Specifications { get; set; }

    public virtual DbSet<StockBalance> StockBalances { get; set; }

    public virtual DbSet<StockLevel> StockLevels { get; set; }

    public virtual DbSet<SubCountry> SubCountries { get; set; }

    public virtual DbSet<Subtitle> Subtitles { get; set; }

    public virtual DbSet<SystemConstant> SystemConstants { get; set; }

    public virtual DbSet<Tax> Taxes { get; set; }

    public virtual DbSet<TaxTransaction> TaxTransactions { get; set; }

    public virtual DbSet<TermDefinition> TermDefinitions { get; set; }

    public virtual DbSet<TransactionCurrency> TransactionCurrencies { get; set; }

    public virtual DbSet<TransactionLimit> TransactionLimits { get; set; }

    public virtual DbSet<TransactionReference> TransactionReferences { get; set; }

    public virtual DbSet<TrialBalance> TrialBalances { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserRoleMapper> UserRoleMappers { get; set; }

    public virtual DbSet<Value> Values { get; set; }

    public virtual DbSet<ValueChangeLog> ValueChangeLogs { get; set; }

    public virtual DbSet<ValueFactor> ValueFactors { get; set; }

    public virtual DbSet<ValueFactorDefinition> ValueFactorDefinitions { get; set; }

    public virtual DbSet<ValueFactorSetup> ValueFactorSetups { get; set; }

    public virtual DbSet<Voucher> Vouchers { get; set; }

    public virtual DbSet<VoucherAccount> VoucherAccounts { get; set; }

    public virtual DbSet<VoucherConsigneeList> VoucherConsigneeLists { get; set; }

    public virtual DbSet<VoucherExtension> VoucherExtensions { get; set; }

    public virtual DbSet<VoucherLookupList> VoucherLookupLists { get; set; }

    public virtual DbSet<VoucherStoreMapping> VoucherStoreMappings { get; set; }

    public virtual DbSet<VoucherTerm> VoucherTerms { get; set; }

    public virtual DbSet<WriteUp> WriteUps { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=192.168.1.11\\CNET_V7;Initial Catalog=CNET_V7_DB;Persist Security Info=True;User ID=sa;password=rdpass;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AcLog>(entity =>
        {
            entity.ToTable("AcLog", "security");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AcDevice).HasColumnName("acDevice");
            entity.Property(e => e.Card).HasColumnName("card");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.IsClosed).HasColumnName("isClosed");
            entity.Property(e => e.IsEntry).HasColumnName("isEntry");
            entity.Property(e => e.IsGranted).HasColumnName("isGranted");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Reader)
                .HasMaxLength(50)
                .HasColumnName("reader");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.TimeStamp)
                .HasColumnType("datetime")
                .HasColumnName("timeStamp");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.AcDeviceNavigation).WithMany(p => p.AcLogs)
                .HasForeignKey(d => d.AcDevice)
                .HasConstraintName("FK_AcLog_Device");
        });

        modelBuilder.Entity<AccessMatrix>(entity =>
        {
            entity.ToTable("AccessMatrix", "security");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccessLevel)
                .HasMaxLength(50)
                .HasColumnName("accessLevel");
            entity.Property(e => e.Pointer).HasColumnName("pointer");
            entity.Property(e => e.Reference)
                .HasMaxLength(50)
                .HasColumnName("reference");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Role).HasColumnName("role");

            entity.HasOne(d => d.PointerNavigation).WithMany(p => p.AccessMatrices)
                .HasForeignKey(d => d.Pointer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccessMatrix_SystemConstant");

            entity.HasOne(d => d.RoleNavigation).WithMany(p => p.AccessMatrices)
                .HasForeignKey(d => d.Role)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccessMatrix_ConsigneeUnit");
        });

        modelBuilder.Entity<Account>(entity =>
        {
            entity.ToTable("Account", "accounting");

            entity.HasIndex(e => e.Code, "IX_Account").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasColumnName("code");
            entity.Property(e => e.ControlAccount).HasColumnName("controlAccount");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.ParentAccount)
                .HasMaxLength(50)
                .HasColumnName("parentAccount");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");

            entity.HasOne(d => d.ControlAccountNavigation).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.ControlAccount)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Account_ControlAccount");
        });

        modelBuilder.Entity<AccountMap>(entity =>
        {
            entity.ToTable("AccountMap", "accounting");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Account)
                .HasMaxLength(50)
                .HasColumnName("account");
            entity.Property(e => e.ConsigneeUnit).HasColumnName("consigneeUnit");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.Reference)
                .HasMaxLength(50)
                .HasColumnName("reference");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
        });

        modelBuilder.Entity<Activity>(entity =>
        {
            entity.ToTable("Activity", "common");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActivityDefinition).HasColumnName("activityDefinition");
            entity.Property(e => e.ConsigneeUnit).HasColumnName("consigneeUnit");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Device).HasColumnName("device");
            entity.Property(e => e.IpAdress)
                .HasMaxLength(50)
                .HasColumnName("ipAdress");
            entity.Property(e => e.Latitude)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("latitude");
            entity.Property(e => e.Longitude)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("longitude");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Period).HasColumnName("period");
            entity.Property(e => e.Platform)
                .HasMaxLength(50)
                .HasColumnName("platform");
            entity.Property(e => e.Pointer).HasColumnName("pointer");
            entity.Property(e => e.Reference)
                .HasMaxLength(50)
                .HasColumnName("reference");
            entity.Property(e => e.Remark).HasColumnName("remark");
            entity.Property(e => e.TimeStamp)
                .HasColumnType("datetime")
                .HasColumnName("timeStamp");
            entity.Property(e => e.User).HasColumnName("user");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.DeviceNavigation).WithMany(p => p.Activities)
                .HasForeignKey(d => d.Device)
                .HasConstraintName("FK_Activity_Device");

            entity.HasOne(d => d.PeriodNavigation).WithMany(p => p.Activities)
                .HasForeignKey(d => d.Period)
                .HasConstraintName("FK_Activity_Period");

            entity.HasOne(d => d.UserNavigation).WithMany(p => p.Activities)
                .HasForeignKey(d => d.User)
                .HasConstraintName("FK_Activity_User");
        });

        modelBuilder.Entity<ActivityDefinition>(entity =>
        {
            entity.ToTable("ActivityDefinition", "setting");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Componet).HasColumnName("componet");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Index).HasColumnName("index");
            entity.Property(e => e.IsManual).HasColumnName("isManual");
            entity.Property(e => e.IssuingEffect).HasColumnName("issuingEffect");
            entity.Property(e => e.MaxRepeat).HasColumnName("maxRepeat");
            entity.Property(e => e.NeedsPassCode).HasColumnName("needsPassCode");
            entity.Property(e => e.Reference).HasColumnName("reference");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.RequiredTime).HasColumnName("requiredTime");
            entity.Property(e => e.Sequence).HasColumnName("sequence");
            entity.Property(e => e.TimeFactor)
                .HasMaxLength(50)
                .HasColumnName("timeFactor");

            entity.HasOne(d => d.DescriptionNavigation).WithMany(p => p.ActivityDefinitions)
                .HasForeignKey(d => d.Description)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ActivityDefinition_ActivityDefinition");
        });

        modelBuilder.Entity<AnswerKey>(entity =>
        {
            entity.ToTable("AnswerKey", "questionnaire");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Answer)
                .HasMaxLength(50)
                .HasColumnName("answer");
            entity.Property(e => e.Question).HasColumnName("question");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");

            entity.HasOne(d => d.QuestionNavigation).WithMany(p => p.AnswerKeys)
                .HasForeignKey(d => d.Question)
                .HasConstraintName("FK_AnswerKey_Question");
        });

        modelBuilder.Entity<AnswerSheet>(entity =>
        {
            entity.ToTable("AnswerSheet", "questionnaire");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Answer)
                .HasMaxLength(50)
                .HasColumnName("answer");
            entity.Property(e => e.EvaluationSheet).HasColumnName("evaluationSheet");
            entity.Property(e => e.PointObtained)
                .HasMaxLength(50)
                .HasColumnName("pointObtained");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Voucher).HasColumnName("voucher");

            entity.HasOne(d => d.EvaluationSheetNavigation).WithMany(p => p.AnswerSheets)
                .HasForeignKey(d => d.EvaluationSheet)
                .HasConstraintName("FK_AnswerSheet_EvaluationSheet");

            entity.HasOne(d => d.VoucherNavigation).WithMany(p => p.AnswerSheets)
                .HasForeignKey(d => d.Voucher)
                .HasConstraintName("FK_AnswerSheet_Voucher");
        });

        modelBuilder.Entity<Article>(entity =>
        {
            entity.ToTable("Article", "article");

            entity.HasIndex(e => e.LocalCode, "IX_Article").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BarCode)
                .HasMaxLength(50)
                .HasColumnName("barCode");
            entity.Property(e => e.Brand).HasColumnName("brand");
            entity.Property(e => e.Color)
                .HasMaxLength(50)
                .HasColumnName("color");
            entity.Property(e => e.CountryOrigin).HasColumnName("countryOrigin");
            entity.Property(e => e.CreatedOn)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("createdOn");
            entity.Property(e => e.DefaultCurrency).HasColumnName("defaultCurrency");
            entity.Property(e => e.DefaultImageUrl).HasColumnName("defaultImageUrl");
            entity.Property(e => e.DefaultSupplier).HasColumnName("defaultSupplier");
            entity.Property(e => e.DefaultValue)
                .HasColumnType("money")
                .HasColumnName("defaultValue");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Generic)
                .HasMaxLength(50)
                .HasColumnName("generic");
            entity.Property(e => e.GslType).HasColumnName("gslType");
            entity.Property(e => e.Height)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("height");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LastModified)
                .HasColumnType("datetime")
                .HasColumnName("lastModified");
            entity.Property(e => e.Length)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("length");
            entity.Property(e => e.LifetimeFactor).HasColumnName("lifetimeFactor");
            entity.Property(e => e.LifetimeValue)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("lifetimeValue");
            entity.Property(e => e.LocalCode)
                .HasMaxLength(50)
                .HasColumnName("localCode");
            entity.Property(e => e.Locked).HasColumnName("locked");
            entity.Property(e => e.Manufacturer)
                .HasMaxLength(50)
                .HasColumnName("manufacturer");
            entity.Property(e => e.Model)
                .HasMaxLength(50)
                .HasColumnName("model");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.NeedsUomconversion).HasColumnName("needsUOMConversion");
            entity.Property(e => e.PackageForm).HasColumnName("packageForm");
            entity.Property(e => e.ParentId).HasColumnName("parentId");
            entity.Property(e => e.Preference).HasColumnName("preference");
            entity.Property(e => e.PreviousValue)
                .HasColumnType("money")
                .HasColumnName("previousValue");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Size)
                .HasMaxLength(50)
                .HasColumnName("size");
            entity.Property(e => e.Uom).HasColumnName("uom");
            entity.Property(e => e.User).HasColumnName("user");
            entity.Property(e => e.Weight)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("weight");
            entity.Property(e => e.Width)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("width");

            entity.HasOne(d => d.CountryOriginNavigation).WithMany(p => p.Articles)
                .HasForeignKey(d => d.CountryOrigin)
                .HasConstraintName("FK_Article_Country");

            entity.HasOne(d => d.GslTypeNavigation).WithMany(p => p.Articles)
                .HasForeignKey(d => d.GslType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Article_GSLTypeList");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("FK_Article_Article");

            entity.HasOne(d => d.PreferenceNavigation).WithMany(p => p.Articles)
                .HasForeignKey(d => d.Preference)
                .HasConstraintName("FK_Article_Preference");

            entity.HasOne(d => d.UomNavigation).WithMany(p => p.Articles)
                .HasForeignKey(d => d.Uom)
                .HasConstraintName("FK_Article_Lookup");
        });

        modelBuilder.Entity<ArticleUser>(entity =>
        {
            entity.ToTable("ArticleUser", "article");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Article).HasColumnName("article");
            entity.Property(e => e.ConsigneeUnit).HasColumnName("consigneeUnit");
            entity.Property(e => e.Remark).HasColumnName("remark");
            entity.Property(e => e.Role).HasColumnName("role");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Value)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("value");

            entity.HasOne(d => d.ArticleNavigation).WithMany(p => p.ArticleUsers)
                .HasForeignKey(d => d.Article)
                .HasConstraintName("FK_ArticleUser_Article");

            entity.HasOne(d => d.ConsigneeUnitNavigation).WithMany(p => p.ArticleUsers)
                .HasForeignKey(d => d.ConsigneeUnit)
                .HasConstraintName("FK_ArticleUser_ConsigneeUnit");
        });

        modelBuilder.Entity<Attachment>(entity =>
        {
            entity.ToTable("Attachment", "common");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.Index).HasColumnName("index");
            entity.Property(e => e.Reference).HasColumnName("reference");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Url).HasColumnName("url");

            entity.HasOne(d => d.CategoryNavigation).WithMany(p => p.AttachmentCategoryNavigations)
                .HasForeignKey(d => d.Category)
                .HasConstraintName("FK_Attachment_Lookup1");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.AttachmentTypeNavigations)
                .HasForeignKey(d => d.Type)
                .HasConstraintName("FK_Attachment_Lookup");
        });

        modelBuilder.Entity<AttendanceLog>(entity =>
        {
            entity.ToTable("AttendanceLog", "hrms");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Identification).HasColumnName("identification");
            entity.Property(e => e.MachineId).HasColumnName("machineId");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("timeStamp");

            entity.HasOne(d => d.IdentificationNavigation).WithMany(p => p.AttendanceLogs)
                .HasForeignKey(d => d.Identification)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AttendanceLog_Identification");

            entity.HasOne(d => d.Machine).WithMany(p => p.AttendanceLogs)
                .HasForeignKey(d => d.MachineId)
                .HasConstraintName("FK_AttendanceLog_Device");
        });

        modelBuilder.Entity<BankAccountDetail>(entity =>
        {
            entity.ToTable("BankAccountDetail", "consignee");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountNo)
                .HasMaxLength(50)
                .HasColumnName("accountNo");
            entity.Property(e => e.BankUnit).HasColumnName("bankUnit");
            entity.Property(e => e.Consignee).HasColumnName("consignee");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Type).HasColumnName("type");

            entity.HasOne(d => d.BankUnitNavigation).WithMany(p => p.BankAccountDetails)
                .HasForeignKey(d => d.BankUnit)
                .HasConstraintName("FK_BankAccountDetail_ConsigneeUnit");

            entity.HasOne(d => d.ConsigneeNavigation).WithMany(p => p.BankAccountDetails)
                .HasForeignKey(d => d.Consignee)
                .HasConstraintName("FK_BankAccountDetail_Consignee");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.BankAccountDetails)
                .HasForeignKey(d => d.Type)
                .HasConstraintName("FK_BankAccountDetail_SystemConstant");
        });

        modelBuilder.Entity<BeginingBalance>(entity =>
        {
            entity.ToTable("BeginingBalance", "common");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.IsProvisional).HasColumnName("isProvisional");
            entity.Property(e => e.Period).HasColumnName("period");
            entity.Property(e => e.Reference).HasColumnName("reference");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Value)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("value");

            entity.HasOne(d => d.PeriodNavigation).WithMany(p => p.BeginingBalances)
                .HasForeignKey(d => d.Period)
                .HasConstraintName("FK_BeginingBalance_Period");
        });

        modelBuilder.Entity<BeginingTransaction>(entity =>
        {
            entity.ToTable("BeginingTransaction", "accounting");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Account).HasMaxLength(50);
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Period).HasMaxLength(50);
            entity.Property(e => e.ReconciliationPeriod)
                .HasMaxLength(50)
                .HasColumnName("reconciliationPeriod");
            entity.Property(e => e.Reference).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(50);
        });

        modelBuilder.Entity<BlankFill>(entity =>
        {
            entity.ToTable("BlankFill", "questionnaire");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CharLength).HasColumnName("charLength");
            entity.Property(e => e.NoOfBlanks).HasColumnName("noOfBlanks");
            entity.Property(e => e.Question).HasColumnName("question");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");

            entity.HasOne(d => d.QuestionNavigation).WithMany(p => p.BlankFills)
                .HasForeignKey(d => d.Question)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BlankFill_Question");
        });

        modelBuilder.Entity<Card>(entity =>
        {
            entity.ToTable("Card", "security");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CardType).HasColumnName("cardType");
            entity.Property(e => e.Model).HasColumnName("model");
            entity.Property(e => e.RegistrationDate)
                .HasColumnType("datetime")
                .HasColumnName("registrationDate");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");

            entity.HasOne(d => d.CardTypeNavigation).WithMany(p => p.CardCardTypeNavigations)
                .HasForeignKey(d => d.CardType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Card_SystemConstant");

            entity.HasOne(d => d.ModelNavigation).WithMany(p => p.CardModelNavigations)
                .HasForeignKey(d => d.Model)
                .HasConstraintName("FK_Card_SystemConstant1");
        });

        modelBuilder.Entity<Choose>(entity =>
        {
            entity.ToTable("Choose", "questionnaire");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.Hint)
                .HasMaxLength(50)
                .HasColumnName("hint");
            entity.Property(e => e.Point)
                .HasMaxLength(50)
                .HasColumnName("point");
            entity.Property(e => e.Question).HasColumnName("question");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Symbol)
                .HasMaxLength(50)
                .HasColumnName("symbol");

            entity.HasOne(d => d.QuestionNavigation).WithMany(p => p.Chooses)
                .HasForeignKey(d => d.Question)
                .HasConstraintName("FK_Choose_Question");
        });

        modelBuilder.Entity<ClosedRelation>(entity =>
        {
            entity.ToTable("ClosedRelation", "transaction");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ReferredVouherDefn).HasColumnName("referredVouherDefn");
            entity.Property(e => e.ReferringVoucherDefn).HasColumnName("referringVoucherDefn");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.TimeStamp)
                .HasColumnType("datetime")
                .HasColumnName("timeStamp");
            entity.Property(e => e.Voucher).HasColumnName("voucher");

            entity.HasOne(d => d.ReferredVouherDefnNavigation).WithMany(p => p.ClosedRelationReferredVouherDefnNavigations)
                .HasForeignKey(d => d.ReferredVouherDefn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClosedRelation_SystemConstant");

            entity.HasOne(d => d.ReferringVoucherDefnNavigation).WithMany(p => p.ClosedRelationReferringVoucherDefnNavigations)
                .HasForeignKey(d => d.ReferringVoucherDefn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClosedRelation_SystemConstant1");

            entity.HasOne(d => d.VoucherNavigation).WithMany(p => p.ClosedRelations)
                .HasForeignKey(d => d.Voucher)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClosedRelation_Voucher");
        });

        modelBuilder.Entity<CloudSync>(entity =>
        {
            entity.ToTable("CloudSync", "common");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DownloadTimeStamp)
                .HasColumnType("datetime")
                .HasColumnName("downloadTimeStamp");
            entity.Property(e => e.OrganizationUnitDefinition).HasColumnName("organizationUnitDefinition");
            entity.Property(e => e.Pointer).HasColumnName("pointer");
            entity.Property(e => e.Reference)
                .HasMaxLength(50)
                .HasColumnName("reference");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TryCount).HasColumnName("tryCount");
            entity.Property(e => e.UploadTimeStamp)
                .HasColumnType("datetime")
                .HasColumnName("uploadTimeStamp");

            entity.HasOne(d => d.OrganizationUnitDefinitionNavigation).WithMany(p => p.CloudSyncs)
                .HasForeignKey(d => d.OrganizationUnitDefinition)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CloudSync_ConsgineeUnit");

            entity.HasOne(d => d.PointerNavigation).WithMany(p => p.CloudSyncs)
                .HasForeignKey(d => d.Pointer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CloudSync_SystemConstant");
        });

        modelBuilder.Entity<Cnetlicense>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CnetLicense");

            entity.ToTable("CNETLicense", "setting");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Device).HasColumnName("device");
            entity.Property(e => e.LicenseCode)
                .HasMaxLength(50)
                .HasColumnName("licenseCode");
            entity.Property(e => e.Reference).HasColumnName("reference");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");

            entity.HasOne(d => d.DeviceNavigation).WithMany(p => p.Cnetlicenses)
                .HasForeignKey(d => d.Device)
                .HasConstraintName("FK_CNETLicense_Device");

            entity.HasOne(d => d.ReferenceNavigation).WithMany(p => p.Cnetlicenses)
                .HasForeignKey(d => d.Reference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CNETLicense_SystemConstant");
        });

        modelBuilder.Entity<Cnetmedium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Media");

            entity.ToTable("CNETMedia", "common");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Article)
                .HasMaxLength(26)
                .HasColumnName("article");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Index).HasColumnName("index");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");
            entity.Property(e => e.StreamUrl)
                .HasMaxLength(1000)
                .HasColumnName("streamURL");
            entity.Property(e => e.Type).HasColumnName("type");

            entity.HasOne(d => d.CategoryNavigation).WithMany(p => p.CnetmediumCategoryNavigations)
                .HasForeignKey(d => d.Category)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CNETMedia_SystemConstant");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.CnetmediumTypeNavigations)
                .HasForeignKey(d => d.Type)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CNETMedia_SystemConstant1");
        });

        modelBuilder.Entity<Configuration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Configur__3213E83FB60A3F28");

            entity.ToTable("Configuration", "setting");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Attribute)
                .HasMaxLength(50)
                .HasColumnName("attribute");
            entity.Property(e => e.CurrentValue)
                .HasMaxLength(50)
                .HasColumnName("currentValue");
            entity.Property(e => e.Preference).HasColumnName("preference");
            entity.Property(e => e.PreviousValue)
                .HasMaxLength(50)
                .HasColumnName("previousValue");
            entity.Property(e => e.Reference).HasColumnName("reference");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
        });

        modelBuilder.Entity<Consignee>(entity =>
        {
            entity.ToTable("Consignee", "consignee");

            entity.HasIndex(e => e.Code, "IX_Consignee").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BusinessType).HasColumnName("businessType");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasColumnName("code");
            entity.Property(e => e.ComminicationSource).HasColumnName("comminicationSource");
            entity.Property(e => e.CreatedOn)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("createdOn");
            entity.Property(e => e.DefaultCurrency).HasColumnName("defaultCurrency");
            entity.Property(e => e.DefaultImageUrl).HasColumnName("defaultImageUrl");
            entity.Property(e => e.DefaultLanguage).HasColumnName("defaultLanguage");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("firstName");
            entity.Property(e => e.Gender).HasColumnName("gender");
            entity.Property(e => e.GslType).HasColumnName("gslType");
            entity.Property(e => e.IdNumber)
                .HasMaxLength(50)
                .HasColumnName("idNumber");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LastModified)
                .HasColumnType("datetime")
                .HasColumnName("lastModified");
            entity.Property(e => e.Locked).HasColumnName("locked");
            entity.Property(e => e.MainConsigneeUnit).HasColumnName("mainConsigneeUnit");
            entity.Property(e => e.MaritalStatus).HasColumnName("maritalStatus");
            entity.Property(e => e.Nationality).HasColumnName("nationality");
            entity.Property(e => e.Note)
                .HasMaxLength(50)
                .HasColumnName("note");
            entity.Property(e => e.ParentId).HasColumnName("parentId");
            entity.Property(e => e.Preference).HasColumnName("preference");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.SecondName)
                .HasMaxLength(50)
                .HasColumnName("secondName");
            entity.Property(e => e.StartDate)
                .HasColumnType("date")
                .HasColumnName("startDate");
            entity.Property(e => e.ThirdName)
                .HasMaxLength(50)
                .HasColumnName("thirdName");
            entity.Property(e => e.Tin)
                .HasMaxLength(50)
                .HasColumnName("tin");
            entity.Property(e => e.Title).HasColumnName("title");

            entity.HasOne(d => d.BusinessTypeNavigation).WithMany(p => p.ConsigneeBusinessTypeNavigations)
                .HasForeignKey(d => d.BusinessType)
                .HasConstraintName("FK_Consignee_SystemConstant2");

            entity.HasOne(d => d.DefaultCurrencyNavigation).WithMany(p => p.Consignees)
                .HasForeignKey(d => d.DefaultCurrency)
                .HasConstraintName("FK_Consignee_Currency");

            entity.HasOne(d => d.DefaultLanguageNavigation).WithMany(p => p.Consignees)
                .HasForeignKey(d => d.DefaultLanguage)
                .HasConstraintName("FK_Consignee_Language");

            entity.HasOne(d => d.GenderNavigation).WithMany(p => p.ConsigneeGenderNavigations)
                .HasForeignKey(d => d.Gender)
                .HasConstraintName("FK_Consignee_SystemConstant1");

            entity.HasOne(d => d.GslTypeNavigation).WithMany(p => p.ConsigneeGslTypeNavigations)
                .HasForeignKey(d => d.GslType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Consignee_GSLTypeList");

            entity.HasOne(d => d.MainConsigneeUnitNavigation).WithMany(p => p.Consignees)
                .HasForeignKey(d => d.MainConsigneeUnit)
                .HasConstraintName("FK_Consignee_ConsigneeUnit");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.ConsigneeMaritalStatusNavigations)
                .HasForeignKey(d => d.MaritalStatus)
                .HasConstraintName("FK_Consignee_SystemConstant3");

            entity.HasOne(d => d.NationalityNavigation).WithMany(p => p.Consignees)
                .HasForeignKey(d => d.Nationality)
                .HasConstraintName("FK_Consignee_Country");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("FK_Consignee_Consignee1");

            entity.HasOne(d => d.PreferenceNavigation).WithMany(p => p.Consignees)
                .HasForeignKey(d => d.Preference)
                .HasConstraintName("FK_Consignee_Preference");

            entity.HasOne(d => d.TitleNavigation).WithMany(p => p.ConsigneeTitleNavigations)
                .HasForeignKey(d => d.Title)
                .HasConstraintName("FK_Consignee_SystemConstant");
        });

        modelBuilder.Entity<ConsigneeUnit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Consigneeunit");

            entity.ToTable("ConsigneeUnit", "consignee");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Abrivation)
                .HasMaxLength(50)
                .HasColumnName("abrivation");
            entity.Property(e => e.AddressLine1).HasColumnName("addressLine1");
            entity.Property(e => e.AddressLine2).HasColumnName("addressLine2");
            entity.Property(e => e.AddressLine3).HasColumnName("addressLine3");
            entity.Property(e => e.City).HasColumnName("city");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Consignee).HasColumnName("consignee");
            entity.Property(e => e.Contact)
                .HasMaxLength(50)
                .HasColumnName("contact");
            entity.Property(e => e.Country).HasColumnName("country");
            entity.Property(e => e.CreatedOn)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("createdOn");
            entity.Property(e => e.DefaultImageUrl).HasColumnName("defaultImageUrl");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.HouseNumber)
                .HasMaxLength(50)
                .HasColumnName("houseNumber");
            entity.Property(e => e.IndustryInvolved).HasColumnName("industryInvolved");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsOnline).HasColumnName("isOnline");
            entity.Property(e => e.Kebele)
                .HasMaxLength(50)
                .HasColumnName("kebele");
            entity.Property(e => e.LastModified)
                .HasColumnType("datetime")
                .HasColumnName("lastModified");
            entity.Property(e => e.Latitude).HasColumnName("latitude");
            entity.Property(e => e.Locked).HasColumnName("locked");
            entity.Property(e => e.Longitude).HasColumnName("longitude");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.ParentId).HasColumnName("parentId");
            entity.Property(e => e.Phone1)
                .HasMaxLength(50)
                .HasColumnName("phone1");
            entity.Property(e => e.Phone2)
                .HasMaxLength(50)
                .HasColumnName("phone2");
            entity.Property(e => e.PoBox)
                .HasMaxLength(50)
                .HasColumnName("poBox");
            entity.Property(e => e.Preference).HasColumnName("preference");
            entity.Property(e => e.Purpose).HasColumnName("purpose");
            entity.Property(e => e.Region).HasColumnName("region");
            entity.Property(e => e.Remark).HasColumnName("remark");
            entity.Property(e => e.SpecificAddress).HasColumnName("specificAddress");
            entity.Property(e => e.Street)
                .HasMaxLength(50)
                .HasColumnName("street");
            entity.Property(e => e.Subcity).HasColumnName("subcity");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Website)
                .HasMaxLength(50)
                .HasColumnName("website");
            entity.Property(e => e.Wereda)
                .HasMaxLength(50)
                .HasColumnName("wereda");

            entity.HasOne(d => d.ConsigneeNavigation).WithMany(p => p.ConsigneeUnits)
                .HasForeignKey(d => d.Consignee)
                .HasConstraintName("FK_ConsigneeUnit_Consignee");

            entity.HasOne(d => d.CountryNavigation).WithMany(p => p.ConsigneeUnits)
                .HasForeignKey(d => d.Country)
                .HasConstraintName("FK_ConsigneeUnit_Country");

            entity.HasOne(d => d.IndustryInvolvedNavigation).WithMany(p => p.ConsigneeUnitIndustryInvolvedNavigations)
                .HasForeignKey(d => d.IndustryInvolved)
                .HasConstraintName("FK_ConsigneeUnit_SystemConstant1");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("FK_ConsigneeUnit_ConsigneeUnit");

            entity.HasOne(d => d.PreferenceNavigation).WithMany(p => p.ConsigneeUnits)
                .HasForeignKey(d => d.Preference)
                .HasConstraintName("FK_ConsigneeUnit_Preference");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.ConsigneeUnitTypeNavigations)
                .HasForeignKey(d => d.Type)
                .HasConstraintName("FK_ConsigneeUnit_SystemConstant");
        });

        modelBuilder.Entity<ConsigneeUser>(entity =>
        {
            entity.ToTable("ConsigneeUser", "consignee");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ExternalConsignee).HasColumnName("externalConsignee");
            entity.Property(e => e.ExternalConsigneeUnit).HasColumnName("externalConsigneeUnit");
            entity.Property(e => e.OwnConsignee).HasColumnName("ownConsignee");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Role).HasColumnName("role");
            entity.Property(e => e.Type).HasColumnName("type");

            entity.HasOne(d => d.ExternalConsigneeNavigation).WithMany(p => p.ConsigneeUserExternalConsigneeNavigations)
                .HasForeignKey(d => d.ExternalConsignee)
                .HasConstraintName("FK_ConsigneeUser_Consignee1");

            entity.HasOne(d => d.ExternalConsigneeUnitNavigation).WithMany(p => p.ConsigneeUsers)
                .HasForeignKey(d => d.ExternalConsigneeUnit)
                .HasConstraintName("FK_ConsigneeUser_ConsigneeUnit");

            entity.HasOne(d => d.OwnConsigneeNavigation).WithMany(p => p.ConsigneeUserOwnConsigneeNavigations)
                .HasForeignKey(d => d.OwnConsignee)
                .HasConstraintName("FK_ConsigneeUser_Consignee");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.ConsigneeUsers)
                .HasForeignKey(d => d.Type)
                .HasConstraintName("FK_ConsigneeUser_SystemConstant");
        });

        modelBuilder.Entity<ControlAccount>(entity =>
        {
            entity.ToTable("ControlAccount", "accounting");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccCategory)
                .HasMaxLength(50)
                .HasColumnName("accCategory");
            entity.Property(e => e.AccType)
                .HasMaxLength(50)
                .HasColumnName("accType");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.NormalBalance)
                .HasMaxLength(50)
                .HasColumnName("normalBalance");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
        });

        modelBuilder.Entity<ConversionDefinition>(entity =>
        {
            entity.ToTable("ConversionDefinition", "article");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Article).HasColumnName("article");
            entity.Property(e => e.FromQty)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("fromQty");
            entity.Property(e => e.FromUom).HasColumnName("fromUom");
            entity.Property(e => e.Index).HasColumnName("index");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.ToQty).HasColumnName("toQty");

            entity.HasOne(d => d.ArticleNavigation).WithMany(p => p.ConversionDefinitions)
                .HasForeignKey(d => d.Article)
                .HasConstraintName("FK_ConversionDefinition_Article");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.ToTable("Country", "common");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Continent).HasColumnName("continent");
            entity.Property(e => e.IcaocountryCode)
                .HasMaxLength(50)
                .HasColumnName("ICAOCountryCode");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Nationality)
                .HasMaxLength(50)
                .HasColumnName("nationality");
            entity.Property(e => e.PoliticalName)
                .HasMaxLength(50)
                .HasColumnName("politicalName");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.TelephoneCode)
                .HasMaxLength(50)
                .HasColumnName("telephoneCode");
            entity.Property(e => e.TimeZone)
                .HasMaxLength(50)
                .HasColumnName("timeZone");
        });

        modelBuilder.Entity<Currency>(entity =>
        {
            entity.ToTable("Currency", "common");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Abbrivation)
                .HasMaxLength(50)
                .HasColumnName("abbrivation");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Country).HasColumnName("country");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.IsDefault).HasColumnName("isDefault");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Sign)
                .HasMaxLength(50)
                .HasColumnName("sign");

            entity.HasOne(d => d.CountryNavigation).WithMany(p => p.Currencies)
                .HasForeignKey(d => d.Country)
                .HasConstraintName("FK_Currency_Country");
        });

        modelBuilder.Entity<CNET_V7_Entities.DataModels.Delegate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Delegate");

            entity.ToTable("Delegates", "common");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Delegate1)
                .HasMaxLength(50)
                .HasColumnName("delegate");
            entity.Property(e => e.Delegating)
                .HasMaxLength(50)
                .HasColumnName("delegating");
            entity.Property(e => e.EndTimeStamp)
                .HasColumnType("datetime")
                .HasColumnName("endTimeStamp");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.StartTimeStamp)
                .HasColumnType("datetime")
                .HasColumnName("startTimeStamp");
        });

        modelBuilder.Entity<Denomination>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Denomina__3213E83F42FDCDC2");

            entity.ToTable("Denomination", "common");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");
            entity.Property(e => e.Weight)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("weight");

            entity.HasOne(d => d.CurrencyNavigation).WithMany(p => p.Denominations)
                .HasForeignKey(d => d.Currency)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Denomination_Currency");
        });

        modelBuilder.Entity<DenominationDetail>(entity =>
        {
            entity.ToTable("DenominationDetail", "transaction");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Denomination).HasColumnName("denomination");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Total)
                .HasColumnType("money")
                .HasColumnName("total");
            entity.Property(e => e.TransactionCurrencyRef).HasColumnName("transactionCurrencyRef");

            entity.HasOne(d => d.DenominationNavigation).WithMany(p => p.DenominationDetails)
                .HasForeignKey(d => d.Denomination)
                .HasConstraintName("FK_DenominationDetail_Denomination");

            entity.HasOne(d => d.TransactionCurrencyRefNavigation).WithMany(p => p.DenominationDetails)
                .HasForeignKey(d => d.TransactionCurrencyRef)
                .HasConstraintName("FK_DenominationDetail_TransactionCurrency");
        });

        modelBuilder.Entity<DepreciationRule>(entity =>
        {
            entity.ToTable("DepreciationRule", "accounting");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Declining)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("declining");
            entity.Property(e => e.Preference)
                .HasMaxLength(50)
                .HasColumnName("preference");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.StraightLine)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("straightLine");
        });

        modelBuilder.Entity<Device>(entity =>
        {
            entity.ToTable("Device", "setting");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Article).HasColumnName("article");
            entity.Property(e => e.BaudRate).HasColumnName("baudRate");
            entity.Property(e => e.ConnectionType).HasColumnName("connectionType");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("createdOn");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.DeviceValue)
                .HasMaxLength(50)
                .HasColumnName("deviceValue");
            entity.Property(e => e.Host)
                .HasMaxLength(50)
                .HasColumnName("host");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(50)
                .HasColumnName("ipAddress");
            entity.Property(e => e.IpPort).HasColumnName("ipPort");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsEvenParity).HasColumnName("isEvenParity");
            entity.Property(e => e.LastModified)
                .HasColumnType("datetime")
                .HasColumnName("lastModified");
            entity.Property(e => e.MacAddress)
                .HasMaxLength(50)
                .HasColumnName("macAddress");
            entity.Property(e => e.MachineName)
                .HasMaxLength(50)
                .HasColumnName("machineName");
            entity.Property(e => e.Preference)
                .HasMaxLength(50)
                .HasColumnName("preference");
            entity.Property(e => e.Remark).HasColumnName("remark");
            entity.Property(e => e.SerialPort).HasColumnName("serialPort");
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("timestamp");

            entity.HasOne(d => d.ArticleNavigation).WithMany(p => p.Devices)
                .HasForeignKey(d => d.Article)
                .HasConstraintName("FK_Device_Article");

            entity.HasOne(d => d.ConnectionTypeNavigation).WithMany(p => p.Devices)
                .HasForeignKey(d => d.ConnectionType)
                .HasConstraintName("FK_Device_SystemConstant");
        });

        modelBuilder.Entity<DiscountFactor>(entity =>
        {
            entity.ToTable("DiscountFactor", "setting");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("amount");
            entity.Property(e => e.Article).HasColumnName("article");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Pointer).HasColumnName("pointer");
            entity.Property(e => e.Range).HasColumnName("range");
            entity.Property(e => e.Reference)
                .HasMaxLength(50)
                .HasColumnName("reference");
            entity.Property(e => e.Remark).HasColumnName("remark");
            entity.Property(e => e.ValueFactoreDefinition).HasColumnName("valueFactoreDefinition");

            entity.HasOne(d => d.ArticleNavigation).WithMany(p => p.DiscountFactors)
                .HasForeignKey(d => d.Article)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountFactor_Article");

            entity.HasOne(d => d.PointerNavigation).WithMany(p => p.DiscountFactors)
                .HasForeignKey(d => d.Pointer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountFactor_SystemConstant");

            entity.HasOne(d => d.RangeNavigation).WithMany(p => p.DiscountFactors)
                .HasForeignKey(d => d.Range)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountFactor_Range");

            entity.HasOne(d => d.ValueFactoreDefinitionNavigation).WithMany(p => p.DiscountFactors)
                .HasForeignKey(d => d.ValueFactoreDefinition)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountFactor_ValueFactorDefinition");
        });

        modelBuilder.Entity<Distribution>(entity =>
        {
            entity.ToTable("Distribution", "setting");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.Destination).HasColumnName("destination");
            entity.Property(e => e.Index).HasColumnName("index");
            entity.Property(e => e.Pointer).HasColumnName("pointer");
            entity.Property(e => e.Reference)
                .HasMaxLength(50)
                .HasColumnName("reference");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Type).HasColumnName("type");

            entity.HasOne(d => d.DestinationNavigation).WithMany(p => p.Distributions)
                .HasForeignKey(d => d.Destination)
                .HasConstraintName("FK_Distribution_ConsigneeUnit");

            entity.HasOne(d => d.PointerNavigation).WithMany(p => p.DistributionPointerNavigations)
                .HasForeignKey(d => d.Pointer)
                .HasConstraintName("FK_Distribution_SystemConstant");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.DistributionTypeNavigations)
                .HasForeignKey(d => d.Type)
                .HasConstraintName("FK_Distribution_SystemConstant1");
        });

        modelBuilder.Entity<EvaluationSheet>(entity =>
        {
            entity.ToTable("EvaluationSheet", "questionnaire");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasColumnName("code");
            entity.Property(e => e.Index).HasColumnName("index");
            entity.Property(e => e.IsBonus)
                .HasMaxLength(50)
                .HasColumnName("isBonus");
            entity.Property(e => e.Point)
                .HasMaxLength(50)
                .HasColumnName("point");
            entity.Property(e => e.Question).HasColumnName("question");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.TimeRequired)
                .HasMaxLength(50)
                .HasColumnName("timeRequired");
            entity.Property(e => e.Voucher).HasColumnName("voucher");

            entity.HasOne(d => d.QuestionNavigation).WithMany(p => p.EvaluationSheets)
                .HasForeignKey(d => d.Question)
                .HasConstraintName("FK_EvaluationSheet_Question");

            entity.HasOne(d => d.VoucherNavigation).WithMany(p => p.EvaluationSheets)
                .HasForeignKey(d => d.Voucher)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EvaluationSheet_Voucher");
        });

        modelBuilder.Entity<ExchangeRate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Exchange__3213E83F9672BC70");

            entity.ToTable("ExchangeRate", "common");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Buying)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("buying");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Selling)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("selling");

            entity.HasOne(d => d.CurrencyNavigation).WithMany(p => p.ExchangeRates)
                .HasForeignKey(d => d.Currency)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExchangeRate_Currency");
        });

        modelBuilder.Entity<FieldFormat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FieldFor__3213E83FEB30C1E8");

            entity.ToTable("FieldFormat", "setting");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Caption).HasColumnName("caption");
            entity.Property(e => e.Color)
                .HasMaxLength(50)
                .HasColumnName("color");
            entity.Property(e => e.Font)
                .HasMaxLength(50)
                .HasColumnName("font");
            entity.Property(e => e.Index).HasColumnName("index");
            entity.Property(e => e.IsRequired).HasColumnName("isRequired");
            entity.Property(e => e.Pointer).HasColumnName("pointer");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.TargetPointer).HasColumnName("targetPointer");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Width).HasColumnName("width");

            entity.HasOne(d => d.PointerNavigation).WithMany(p => p.FieldFormatPointerNavigations)
                .HasForeignKey(d => d.Pointer)
                .HasConstraintName("FK_FieldFormat_SystemConstant1");

            entity.HasOne(d => d.TargetPointerNavigation).WithMany(p => p.FieldFormatTargetPointerNavigations)
                .HasForeignKey(d => d.TargetPointer)
                .HasConstraintName("FK_FieldFormat_SystemConstant2");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.FieldFormatTypeNavigations)
                .HasForeignKey(d => d.Type)
                .HasConstraintName("FK_FieldFormat_SystemConstant");
        });

        modelBuilder.Entity<Functionality>(entity =>
        {
            entity.ToTable("Functionality", "security");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.Function)
                .HasMaxLength(50)
                .HasColumnName("function");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.SubSystemComponent).HasColumnName("subSystemComponent");
            entity.Property(e => e.VisualComponent).HasColumnName("visualComponent");

            entity.HasOne(d => d.CategoryNavigation).WithMany(p => p.FunctionalityCategoryNavigations)
                .HasForeignKey(d => d.Category)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Functionality_SystemConstant");

            entity.HasOne(d => d.SubSystemComponentNavigation).WithMany(p => p.FunctionalitySubSystemComponentNavigations)
                .HasForeignKey(d => d.SubSystemComponent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Functionality_SystemConstant2");

            entity.HasOne(d => d.VisualComponentNavigation).WithMany(p => p.FunctionalityVisualComponentNavigations)
                .HasForeignKey(d => d.VisualComponent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Functionality_SystemConstant3");
        });

        modelBuilder.Entity<GslacctRequirement>(entity =>
        {
            entity.ToTable("GSLAcctRequirement", "accounting");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ContAcct).HasColumnName("contAcct");
            entity.Property(e => e.GslTypeList).HasColumnName("gslTypeList");
            entity.Property(e => e.IsMandatory).HasColumnName("isMandatory");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.RestrictSelection).HasColumnName("restrictSelection");

            entity.HasOne(d => d.ContAcctNavigation).WithMany(p => p.GslacctRequirements)
                .HasForeignKey(d => d.ContAcct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GSLAcctRequirement_ControlAccount");
        });

        modelBuilder.Entity<Gsltax>(entity =>
        {
            entity.ToTable("GSLTax", "common");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Reference).HasColumnName("reference");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Tax).HasColumnName("tax");

            entity.HasOne(d => d.TaxNavigation).WithMany(p => p.Gsltaxes)
                .HasForeignKey(d => d.Tax)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GSLTax_Tax");
        });

        modelBuilder.Entity<Gsluser>(entity =>
        {
            entity.ToTable("GSLUser", "common");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Article).HasColumnName("article");
            entity.Property(e => e.ConsigneeUnit).HasColumnName("consigneeUnit");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Role).HasColumnName("role");
            entity.Property(e => e.Type).HasColumnName("type");

            entity.HasOne(d => d.ArticleNavigation).WithMany(p => p.Gslusers)
                .HasForeignKey(d => d.Article)
                .HasConstraintName("FK_GSLUser_Article");

            entity.HasOne(d => d.ConsigneeUnitNavigation).WithMany(p => p.Gslusers)
                .HasForeignKey(d => d.ConsigneeUnit)
                .HasConstraintName("FK_GSLUser_ConsigneeUnit");
        });

        modelBuilder.Entity<Holiday>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Holiday__3213E83F75D7BADD");

            entity.ToTable("Holiday", "common");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActualPeriod).HasColumnName("actualPeriod");
            entity.Property(e => e.ForecastedPeriod).HasColumnName("forecastedPeriod");
            entity.Property(e => e.HolidayDefinition).HasColumnName("holidayDefinition");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");

            entity.HasOne(d => d.ActualPeriodNavigation).WithMany(p => p.HolidayActualPeriodNavigations)
                .HasForeignKey(d => d.ActualPeriod)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Holiday_Period1");

            entity.HasOne(d => d.ForecastedPeriodNavigation).WithMany(p => p.HolidayForecastedPeriodNavigations)
                .HasForeignKey(d => d.ForecastedPeriod)
                .HasConstraintName("FK_Holiday_Period");

            entity.HasOne(d => d.HolidayDefinitionNavigation).WithMany(p => p.Holidays)
                .HasForeignKey(d => d.HolidayDefinition)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Holiday_HolidayDefn");
        });

        modelBuilder.Entity<HolidayDefinition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__HolidayD__3213E83FA271F960");

            entity.ToTable("HolidayDefinition", "common");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AlertBefore).HasColumnName("alertBefore");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.IsFixed).HasColumnName("isFixed");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");
            entity.Property(e => e.WillClose).HasColumnName("willClose");
        });

        modelBuilder.Entity<Iddefinition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_IdDefinition");

            entity.ToTable("IDDefinition", "setting");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.Length).HasColumnName("length");
            entity.Property(e => e.Pointer).HasColumnName("pointer");
            entity.Property(e => e.Prefix)
                .HasMaxLength(50)
                .HasColumnName("prefix");
            entity.Property(e => e.PrefixSeparator)
                .HasMaxLength(50)
                .HasColumnName("prefixSeparator");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Suffix)
                .HasMaxLength(50)
                .HasColumnName("suffix");
            entity.Property(e => e.SuffixSeparator)
                .HasMaxLength(50)
                .HasColumnName("suffixSeparator");

            entity.HasOne(d => d.PointerNavigation).WithMany(p => p.Iddefinitions)
                .HasForeignKey(d => d.Pointer)
                .HasConstraintName("FK_IDDefinition_SystemConstant");
        });

        modelBuilder.Entity<Identification>(entity =>
        {
            entity.ToTable("Identification", "consignee");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Consignee).HasColumnName("consignee");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("date")
                .HasColumnName("expiryDate");
            entity.Property(e => e.IdNumber)
                .HasMaxLength(50)
                .HasColumnName("idNumber");
            entity.Property(e => e.IssueDate)
                .HasColumnType("date")
                .HasColumnName("issueDate");
            entity.Property(e => e.Issuer)
                .HasMaxLength(50)
                .HasColumnName("issuer");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Type).HasColumnName("type");

            entity.HasOne(d => d.ConsigneeNavigation).WithMany(p => p.Identifications)
                .HasForeignKey(d => d.Consignee)
                .HasConstraintName("FK_Identification_Consignee");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.Identifications)
                .HasForeignKey(d => d.Type)
                .HasConstraintName("FK_Identification_SystemConstant");
        });

        modelBuilder.Entity<Idsetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_IdSetting");

            entity.ToTable("IDSetting", "setting");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.CurrentValue).HasColumnName("currentValue");
            entity.Property(e => e.Device).HasColumnName("device");
            entity.Property(e => e.IsDefinition).HasColumnName("isDefinition");
            entity.Property(e => e.IsFlexible).HasColumnName("isFlexible");
            entity.Property(e => e.OrganizationUnit).HasColumnName("organizationUnit");
            entity.Property(e => e.Reference).HasColumnName("reference");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.StartFrom).HasColumnName("startFrom");

            entity.HasOne(d => d.DeviceNavigation).WithMany(p => p.Idsettings)
                .HasForeignKey(d => d.Device)
                .HasConstraintName("FK_IDSetting_Device");

            entity.HasOne(d => d.OrganizationUnitNavigation).WithMany(p => p.Idsettings)
                .HasForeignKey(d => d.OrganizationUnit)
                .HasConstraintName("FK_IDSetting_ConsigneeUnit");

            entity.HasOne(d => d.ReferenceNavigation).WithMany(p => p.Idsettings)
                .HasForeignKey(d => d.Reference)
                .HasConstraintName("FK_IDSetting_SystemConstant");
        });

        modelBuilder.Entity<IssuedCard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_IssuedCared");

            entity.ToTable("IssuedCard", "security");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Card).HasColumnName("card");
            entity.Property(e => e.Consignee).HasColumnName("consignee");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");

            entity.HasOne(d => d.CardNavigation).WithMany(p => p.IssuedCards)
                .HasForeignKey(d => d.Card)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IssuedCard_Card");

            entity.HasOne(d => d.ConsigneeNavigation).WithMany(p => p.IssuedCards)
                .HasForeignKey(d => d.Consignee)
                .HasConstraintName("FK_IssuedCard_Consignee");
        });

        modelBuilder.Entity<JournalDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Jornal");

            entity.ToTable("JournalDetail", "accounting");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Account)
                .HasMaxLength(50)
                .HasColumnName("account");
            entity.Property(e => e.Cart).HasColumnName("cart");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasColumnName("code");
            entity.Property(e => e.Credit)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("credit");
            entity.Property(e => e.Debit)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("debit");
            entity.Property(e => e.IsReconciled).HasColumnName("isReconciled");
            entity.Property(e => e.Locked).HasColumnName("locked");
            entity.Property(e => e.ReconPeriod).HasColumnName("reconPeriod");
            entity.Property(e => e.Remark).HasColumnName("remark");
            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("timeStamp");
            entity.Property(e => e.Voucher).HasColumnName("voucher");

            entity.HasOne(d => d.ReconPeriodNavigation).WithMany(p => p.JournalDetails)
                .HasForeignKey(d => d.ReconPeriod)
                .HasConstraintName("FK_JournalDetail_Period");

            entity.HasOne(d => d.VoucherNavigation).WithMany(p => p.JournalDetails)
                .HasForeignKey(d => d.Voucher)
                .HasConstraintName("FK_JournalDetail_Voucher");
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Language__3213E83F87FDF9A9");

            entity.ToTable("Language", "common");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.Pointer).HasColumnName("pointer");
            entity.Property(e => e.Reference)
                .HasMaxLength(50)
                .HasColumnName("reference");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Type).HasColumnName("type");

            entity.HasOne(d => d.PointerNavigation).WithMany(p => p.Languages)
                .HasForeignKey(d => d.Pointer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Language_SystemConstant");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.Languages)
                .HasForeignKey(d => d.Type)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Language_Lookup");
        });

        modelBuilder.Entity<LanguagePreference>(entity =>
        {
            entity.ToTable("LanguagePreference", "consignee");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Consignee).HasColumnName("consignee");
            entity.Property(e => e.Language).HasColumnName("language");
            entity.Property(e => e.Proficiency).HasColumnName("proficiency");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");

            entity.HasOne(d => d.ConsigneeNavigation).WithMany(p => p.LanguagePreferences)
                .HasForeignKey(d => d.Consignee)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LanguagePreference_Consignee");

            entity.HasOne(d => d.LanguageNavigation).WithMany(p => p.LanguagePreferences)
                .HasForeignKey(d => d.Language)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LanguagePreference_Language");
        });

        modelBuilder.Entity<LineItem>(entity =>
        {
            entity.ToTable("LineItem", "transaction");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddCharge)
                .HasColumnType("money")
                .HasColumnName("addCharge");
            entity.Property(e => e.Article).HasColumnName("article");
            entity.Property(e => e.CalculatedCost)
                .HasColumnType("money")
                .HasColumnName("calculatedCost");
            entity.Property(e => e.Cart).HasColumnName("cart");
            entity.Property(e => e.CreatedOn)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("createdOn");
            entity.Property(e => e.Discount)
                .HasColumnType("money")
                .HasColumnName("discount");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("endDate");
            entity.Property(e => e.Extension1)
                .HasMaxLength(50)
                .HasColumnName("extension1");
            entity.Property(e => e.Extension2)
                .HasMaxLength(50)
                .HasColumnName("extension2");
            entity.Property(e => e.Index).HasColumnName("index");
            entity.Property(e => e.IsVoid).HasColumnName("isVoid");
            entity.Property(e => e.LastModified)
                .HasColumnType("datetime")
                .HasColumnName("lastModified");
            entity.Property(e => e.Note)
                .HasMaxLength(50)
                .HasColumnName("note");
            entity.Property(e => e.Override).HasColumnName("override");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.SerialCode1)
                .HasMaxLength(50)
                .HasColumnName("serialCode1");
            entity.Property(e => e.SerialCode2)
                .HasMaxLength(50)
                .HasColumnName("serialCode2");
            entity.Property(e => e.SerialCode3)
                .HasMaxLength(50)
                .HasColumnName("serialCode3");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("startDate");
            entity.Property(e => e.Tax).HasColumnName("tax");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("money")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxableAmount)
                .HasColumnType("money")
                .HasColumnName("taxableAmount");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("money")
                .HasColumnName("totalAmount");
            entity.Property(e => e.UnitAmount)
                .HasColumnType("money")
                .HasColumnName("unitAmount");
            entity.Property(e => e.Uom).HasColumnName("uom");
            entity.Property(e => e.Voucher).HasColumnName("voucher");

            entity.HasOne(d => d.ArticleNavigation).WithMany(p => p.LineItems)
                .HasForeignKey(d => d.Article)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LineItem_Article");

            entity.HasOne(d => d.UomNavigation).WithMany(p => p.LineItems)
                .HasForeignKey(d => d.Uom)
                .HasConstraintName("FK_LineItem_SystemConstant");

            entity.HasOne(d => d.VoucherNavigation).WithMany(p => p.LineItems)
                .HasForeignKey(d => d.Voucher)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LineItem_Voucher");
        });

        modelBuilder.Entity<LineItemConversion>(entity =>
        {
            entity.ToTable("LineItemConversion", "transaction");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LineItem).HasColumnName("lineItem");
            entity.Property(e => e.Quantity)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("quantity");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.UnitAmount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("unitAmount");
            entity.Property(e => e.Uom).HasColumnName("uom");

            entity.HasOne(d => d.LineItemNavigation).WithMany(p => p.LineItemConversions)
                .HasForeignKey(d => d.LineItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LineItemConversion_LineItem");

            entity.HasOne(d => d.UomNavigation).WithMany(p => p.LineItemConversions)
                .HasForeignKey(d => d.Uom)
                .HasConstraintName("FK_LineItemConversion_SystemConstant");
        });

        modelBuilder.Entity<LineItemReference>(entity =>
        {
            entity.ToTable("LineItemReference", "transaction");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LineItem).HasColumnName("lineItem");
            entity.Property(e => e.Referenced).HasColumnName("referenced");
            entity.Property(e => e.ReferencedVouDfn).HasColumnName("referencedVouDfn");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Value)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("value");
            entity.Property(e => e.Voucher).HasColumnName("voucher");

            entity.HasOne(d => d.LineItemNavigation).WithMany(p => p.LineItemReferenceLineItemNavigations)
                .HasForeignKey(d => d.LineItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LineItemReference_LineItem");

            entity.HasOne(d => d.ReferencedNavigation).WithMany(p => p.LineItemReferenceReferencedNavigations)
                .HasForeignKey(d => d.Referenced)
                .HasConstraintName("FK_LineItemReference_LineItem1");

            entity.HasOne(d => d.ReferencedVouDfnNavigation).WithMany(p => p.LineItemReferences)
                .HasForeignKey(d => d.ReferencedVouDfn)
                .HasConstraintName("FK_LineItemReference_SystemConstant");

            entity.HasOne(d => d.VoucherNavigation).WithMany(p => p.LineItemReferences)
                .HasForeignKey(d => d.Voucher)
                .HasConstraintName("FK_LineItemReference_Voucher");
        });

        modelBuilder.Entity<LineItemValueFactor>(entity =>
        {
            entity.ToTable("LineItemValueFactor", "transaction");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("amount");
            entity.Property(e => e.IsDiscount).HasColumnName("isDiscount");
            entity.Property(e => e.LineItem).HasColumnName("lineItem");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.ValueFactor).HasColumnName("valueFactor");

            entity.HasOne(d => d.LineItemNavigation).WithMany(p => p.LineItemValueFactors)
                .HasForeignKey(d => d.LineItem)
                .HasConstraintName("FK_LineItemValueFactor_LineItem");

            entity.HasOne(d => d.ValueFactorNavigation).WithMany(p => p.LineItemValueFactors)
                .HasForeignKey(d => d.ValueFactor)
                .HasConstraintName("FK_LineItemValueFactor_ValueFactor");
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.ToTable("Location", "common");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GslType).HasColumnName("gslType");
            entity.Property(e => e.Reference).HasColumnName("reference");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Space).HasColumnName("space");
            entity.Property(e => e.Type).HasColumnName("type");

            entity.HasOne(d => d.GslTypeNavigation).WithMany(p => p.LocationGslTypeNavigations)
                .HasForeignKey(d => d.GslType)
                .HasConstraintName("FK_Location_GSLTypeList");

            entity.HasOne(d => d.SpaceNavigation).WithMany(p => p.Locations)
                .HasForeignKey(d => d.Space)
                .HasConstraintName("FK_Location_Space");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.LocationTypeNavigations)
                .HasForeignKey(d => d.Type)
                .HasConstraintName("FK_Location_SystemConstant");
        });

        modelBuilder.Entity<Lookup>(entity =>
        {
            entity.ToTable("Lookup", "common");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Component)
                .HasMaxLength(50)
                .HasColumnName("component");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.Index).HasColumnName("index");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsDefault).HasColumnName("isDefault");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");
            entity.Property(e => e.Value)
                .HasMaxLength(50)
                .HasColumnName("value");
        });

        modelBuilder.Entity<MenuDesigner>(entity =>
        {
            entity.ToTable("MenuDesigner", "setting");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FifthMenuSelectCount).HasColumnName("fifthMenuSelectCount");
            entity.Property(e => e.FirstMenu)
                .HasMaxLength(50)
                .HasColumnName("firstMenu");
            entity.Property(e => e.FirstMenuSelectCount).HasColumnName("firstMenuSelectCount");
            entity.Property(e => e.FourthMenu)
                .HasMaxLength(50)
                .HasColumnName("fourthMenu");
            entity.Property(e => e.FourthMenuSelectCount).HasColumnName("fourthMenuSelectCount");
            entity.Property(e => e.Note).HasColumnName("note");
            entity.Property(e => e.Pointer).HasColumnName("pointer");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.SecondMenu)
                .HasMaxLength(50)
                .HasColumnName("secondMenu");
            entity.Property(e => e.SecondMenuSelcetCount).HasColumnName("secondMenuSelcetCount");
            entity.Property(e => e.SixthMenu)
                .HasMaxLength(50)
                .HasColumnName("sixthMenu");
            entity.Property(e => e.SixthMenuSelectCount).HasColumnName("sixthMenuSelectCount");
            entity.Property(e => e.ThirdMenu)
                .HasMaxLength(50)
                .HasColumnName("thirdMenu");
            entity.Property(e => e.ThirdMenuSelectCount).HasColumnName("thirdMenuSelectCount");

            entity.HasOne(d => d.PointerNavigation).WithMany(p => p.MenuDesigners)
                .HasForeignKey(d => d.Pointer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MenuDesigner_SystemConstant");
        });

        modelBuilder.Entity<Movie>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Movies");

            entity.ToTable("Movie", "common");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Actors).HasColumnName("actors");
            entity.Property(e => e.Dimension).HasColumnName("dimension");
            entity.Property(e => e.Director).HasColumnName("director");
            entity.Property(e => e.Duration)
                .HasMaxLength(26)
                .HasColumnName("duration");
            entity.Property(e => e.Media).HasColumnName("media");
            entity.Property(e => e.Movielanguage)
                .HasMaxLength(26)
                .HasColumnName("movielanguage");
            entity.Property(e => e.Plot).HasColumnName("plot");
            entity.Property(e => e.Producer).HasColumnName("producer");
            entity.Property(e => e.Rating)
                .HasMaxLength(26)
                .HasColumnName("rating");
            entity.Property(e => e.ReleaseDate)
                .HasColumnType("date")
                .HasColumnName("releaseDate");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");
            entity.Property(e => e.Subtitlelanguage)
                .HasMaxLength(26)
                .HasColumnName("subtitlelanguage");
            entity.Property(e => e.Writer).HasColumnName("writer");

            entity.HasOne(d => d.DimensionNavigation).WithMany(p => p.Movies)
                .HasForeignKey(d => d.Dimension)
                .HasConstraintName("FK_Movie_SystemConstant");

            entity.HasOne(d => d.MediaNavigation).WithMany(p => p.Movies)
                .HasForeignKey(d => d.Media)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Movie_CNETMedia");
        });

        modelBuilder.Entity<MovieSchedule>(entity =>
        {
            entity.ToTable("MovieSchedule", "common");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Dimension).HasColumnName("dimension");
            entity.Property(e => e.OrgUnit).HasColumnName("orgUnit");
            entity.Property(e => e.Reference).HasColumnName("reference");
            entity.Property(e => e.Remark).HasColumnName("remark");
            entity.Property(e => e.ScheduleHeader).HasColumnName("scheduleHeader");
            entity.Property(e => e.Space).HasColumnName("space");
            entity.Property(e => e.Value)
                .HasColumnType("money")
                .HasColumnName("value");

            entity.HasOne(d => d.DimensionNavigation).WithMany(p => p.MovieSchedules)
                .HasForeignKey(d => d.Dimension)
                .HasConstraintName("FK_MovieSchedule_SystemConstant");

            entity.HasOne(d => d.OrgUnitNavigation).WithMany(p => p.MovieSchedules)
                .HasForeignKey(d => d.OrgUnit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MovieSchedule_ConsigneeUnit");

            entity.HasOne(d => d.ScheduleHeaderNavigation).WithMany(p => p.MovieSchedules)
                .HasForeignKey(d => d.ScheduleHeader)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MovieSchedule_ScheduleHeader");

            entity.HasOne(d => d.SpaceNavigation).WithMany(p => p.MovieSchedules)
                .HasForeignKey(d => d.Space)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MovieSchedule_Space");
        });

        modelBuilder.Entity<NonCashTransaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_NonCash");

            entity.ToTable("NonCashTransaction", "transaction");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasColumnType("money")
                .HasColumnName("amount");
            entity.Property(e => e.Consignee).HasColumnName("consignee");
            entity.Property(e => e.Currency)
                .HasMaxLength(50)
                .HasColumnName("currency");
            entity.Property(e => e.Executed).HasColumnName("executed");
            entity.Property(e => e.Index).HasColumnName("index");
            entity.Property(e => e.IsIncoming).HasColumnName("isIncoming");
            entity.Property(e => e.IssueDate)
                .HasColumnType("date")
                .HasColumnName("issueDate");
            entity.Property(e => e.MaturityDate)
                .HasColumnType("date")
                .HasColumnName("maturityDate");
            entity.Property(e => e.Number)
                .HasMaxLength(50)
                .HasColumnName("number");
            entity.Property(e => e.PaymentMethod).HasColumnName("paymentMethod");
            entity.Property(e => e.PaymentProcessor)
                .HasMaxLength(50)
                .HasColumnName("paymentProcessor");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("rate");
            entity.Property(e => e.Remark).HasColumnName("remark");
            entity.Property(e => e.Voucher).HasColumnName("voucher");

            entity.HasOne(d => d.ConsigneeNavigation).WithMany(p => p.NonCashTransactions)
                .HasForeignKey(d => d.Consignee)
                .HasConstraintName("FK_NonCashTransaction_Consignee");

            entity.HasOne(d => d.PaymentMethodNavigation).WithMany(p => p.NonCashTransactions)
                .HasForeignKey(d => d.PaymentMethod)
                .HasConstraintName("FK_NonCashTransaction_SystemConstant");

            entity.HasOne(d => d.VoucherNavigation).WithMany(p => p.NonCashTransactions)
                .HasForeignKey(d => d.Voucher)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NonCashTransaction_Voucher");
        });

        modelBuilder.Entity<ObjectState>(entity =>
        {
            entity.ToTable("ObjectState", "common");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.ObjectStateDefinition).HasColumnName("objectStateDefinition");
            entity.Property(e => e.Reference).HasColumnName("reference");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.ObjectState)
                .HasForeignKey<ObjectState>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ObjectState_ObjectStateDefinition");
        });

        modelBuilder.Entity<ObjectStateDefinition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_objectStateDefinition");

            entity.ToTable("ObjectStateDefinition", "setting");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Color)
                .HasMaxLength(50)
                .HasColumnName("color");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.Font).HasColumnName("font");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Type).HasColumnName("type");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.ObjectStateDefinitions)
                .HasForeignKey(d => d.Type)
                .HasConstraintName("FK_ObjectStateDefinition_SystemConstant");
        });

        modelBuilder.Entity<OrderStationMap>(entity =>
        {
            entity.ToTable("OrderStationMap", "setting");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PosDevice).HasColumnName("posDevice");
            entity.Property(e => e.Preference).HasColumnName("preference");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.StationDevice).HasColumnName("stationDevice");

            entity.HasOne(d => d.PosDeviceNavigation).WithMany(p => p.OrderStationMapPosDeviceNavigations)
                .HasForeignKey(d => d.PosDevice)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderStationMap_Device");

            entity.HasOne(d => d.PreferenceNavigation).WithMany(p => p.OrderStationMaps)
                .HasForeignKey(d => d.Preference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderStationMap_Preference");

            entity.HasOne(d => d.StationDeviceNavigation).WithMany(p => p.OrderStationMapStationDeviceNavigations)
                .HasForeignKey(d => d.StationDevice)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderStationMap_Device1");
        });

        modelBuilder.Entity<Period>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Period__3213E83F03A1D3D8");

            entity.ToTable("Period", "common");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.End)
                .HasColumnType("datetime")
                .HasColumnName("end");
            entity.Property(e => e.Index).HasColumnName("index");
            entity.Property(e => e.Parent)
                .HasMaxLength(50)
                .HasColumnName("parent");
            entity.Property(e => e.PeriodName)
                .HasMaxLength(50)
                .HasColumnName("periodName");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Start)
                .HasColumnType("datetime")
                .HasColumnName("start");
            entity.Property(e => e.Type).HasColumnName("type");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.Periods)
                .HasForeignKey(d => d.Type)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Period_SystemConstant");
        });

        modelBuilder.Entity<Preference>(entity =>
        {
            entity.ToTable("Preference", "setting");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Color)
                .HasMaxLength(50)
                .HasColumnName("color");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.Font)
                .HasMaxLength(50)
                .HasColumnName("font");
            entity.Property(e => e.Index).HasColumnName("index");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.Parent).HasColumnName("parent");
            entity.Property(e => e.Pointer).HasColumnName("pointer");
            entity.Property(e => e.Reference).HasColumnName("reference");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Value).HasColumnName("value");

            entity.HasOne(d => d.ParentNavigation).WithMany(p => p.InverseParentNavigation)
                .HasForeignKey(d => d.Parent)
                .HasConstraintName("FK_Preference_Preference");

            entity.HasOne(d => d.PointerNavigation).WithMany(p => p.PreferencePointerNavigations)
                .HasForeignKey(d => d.Pointer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Preference_SystemConstant");

            entity.HasOne(d => d.ReferenceNavigation).WithMany(p => p.PreferenceReferenceNavigations)
                .HasForeignKey(d => d.Reference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Preference_SystemConstant1");
        });

        modelBuilder.Entity<PreferenceAccess>(entity =>
        {
            entity.ToTable("PreferenceAccess", "setting");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.Device).HasColumnName("device");
            entity.Property(e => e.Preference).HasColumnName("preference");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.VoucherDfn).HasColumnName("voucherDfn");

            entity.HasOne(d => d.DeviceNavigation).WithMany(p => p.PreferenceAccesses)
                .HasForeignKey(d => d.Device)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PreferenceAccess_Device");

            entity.HasOne(d => d.PreferenceNavigation).WithMany(p => p.PreferenceAccesses)
                .HasForeignKey(d => d.Preference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PreferenceAccess_Preference");

            entity.HasOne(d => d.VoucherDfnNavigation).WithMany(p => p.PreferenceAccesses)
                .HasForeignKey(d => d.VoucherDfn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PreferenceAccess_SystemConstant");
        });

        modelBuilder.Entity<PreferentialValueFactor>(entity =>
        {
            entity.ToTable("PreferentialValueFactor", "transaction");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("amount");
            entity.Property(e => e.Preference).HasColumnName("preference");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.ValueFactorDefn).HasColumnName("valueFactorDefn");
            entity.Property(e => e.Voucher).HasColumnName("voucher");

            entity.HasOne(d => d.PreferenceNavigation).WithMany(p => p.PreferentialValueFactors)
                .HasForeignKey(d => d.Preference)
                .HasConstraintName("FK_PreferentialValueFactor_Preference");

            entity.HasOne(d => d.ValueFactorDefnNavigation).WithMany(p => p.PreferentialValueFactors)
                .HasForeignKey(d => d.ValueFactorDefn)
                .HasConstraintName("FK_PreferentialValueFactor_ValueFactorDefinition");

            entity.HasOne(d => d.VoucherNavigation).WithMany(p => p.PreferentialValueFactors)
                .HasForeignKey(d => d.Voucher)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PreferentialValueFactor_Voucher");
        });

        modelBuilder.Entity<ProgressTaxRate>(entity =>
        {
            entity.ToTable("ProgressTaxRate", "setting");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Constant)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("constant");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.Range).HasColumnName("range");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("rate");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.TaxCode).HasColumnName("taxCode");

            entity.HasOne(d => d.RangeNavigation).WithMany(p => p.ProgressTaxRates)
                .HasForeignKey(d => d.Range)
                .HasConstraintName("FK_ProgressTaxRate_Range");

            entity.HasOne(d => d.TaxCodeNavigation).WithMany(p => p.ProgressTaxRates)
                .HasForeignKey(d => d.TaxCode)
                .HasConstraintName("FK_ProgressTaxRate_ProgressTaxRate");
        });

        modelBuilder.Entity<Question>(entity =>
        {
            entity.ToTable("Question", "questionnaire");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AllowFraction).HasColumnName("allowFraction");
            entity.Property(e => e.Appearance)
                .HasMaxLength(50)
                .HasColumnName("appearance");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.Hint)
                .HasMaxLength(50)
                .HasColumnName("hint");
            entity.Property(e => e.Index).HasColumnName("index");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LastState).HasColumnName("lastState");
            entity.Property(e => e.LastUpdate)
                .HasColumnType("date")
                .HasColumnName("lastUpdate");
            entity.Property(e => e.Level)
                .HasMaxLength(50)
                .HasColumnName("level");
            entity.Property(e => e.Point)
                .HasMaxLength(50)
                .HasColumnName("point");
            entity.Property(e => e.TimeRequired)
                .HasMaxLength(50)
                .HasColumnName("timeRequired");
            entity.Property(e => e.Topic)
                .HasMaxLength(50)
                .HasColumnName("topic");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");

            entity.HasOne(d => d.CategoryNavigation).WithMany(p => p.Questions)
                .HasForeignKey(d => d.Category)
                .HasConstraintName("FK_Question_SystemConstant");
        });

        modelBuilder.Entity<QuestionDetail>(entity =>
        {
            entity.ToTable("QuestionDetail", "questionnaire");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.Hint)
                .HasMaxLength(50)
                .HasColumnName("hint");
            entity.Property(e => e.Point)
                .HasMaxLength(50)
                .HasColumnName("point");
            entity.Property(e => e.Question).HasColumnName("question");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Symbol)
                .HasMaxLength(50)
                .HasColumnName("symbol");

            entity.HasOne(d => d.QuestionNavigation).WithMany(p => p.QuestionDetails)
                .HasForeignKey(d => d.Question)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QuestionDetail_QuestionDetail");
        });

        modelBuilder.Entity<QuestionRouter>(entity =>
        {
            entity.ToTable("QuestionRouter", "questionnaire");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Question).HasColumnName("question");
            entity.Property(e => e.QuestionDetail).HasColumnName("questionDetail");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");

            entity.HasOne(d => d.QuestionNavigation).WithMany(p => p.QuestionRouters)
                .HasForeignKey(d => d.Question)
                .HasConstraintName("FK_QuestionRouter_Question");

            entity.HasOne(d => d.QuestionDetailNavigation).WithMany(p => p.QuestionRouters)
                .HasForeignKey(d => d.QuestionDetail)
                .HasConstraintName("FK_QuestionRouter_QuestionDetail");
        });

        modelBuilder.Entity<CNET_V7_Entities.DataModels.Range>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Range__3213E83F93B39FD0");

            entity.ToTable("Ranges", "common");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.Max)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("max");
            entity.Property(e => e.Min)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("min");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Type).HasColumnName("type");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.Ranges)
                .HasForeignKey(d => d.Type)
                .HasConstraintName("FK_Range_SystemConstant");
        });

        modelBuilder.Entity<ReconciliationDetail>(entity =>
        {
            entity.ToTable("ReconciliationDetail", "setting");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsDebit).HasColumnName("isDebit");
            entity.Property(e => e.ReconSum).HasColumnName("reconSum");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.VoucherDefinition).HasColumnName("voucherDefinition");

            entity.HasOne(d => d.ReconSumNavigation).WithMany(p => p.ReconciliationDetails)
                .HasForeignKey(d => d.ReconSum)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReconciliationDetail_ReconciliationSummary");

            entity.HasOne(d => d.VoucherDefinitionNavigation).WithMany(p => p.ReconciliationDetails)
                .HasForeignKey(d => d.VoucherDefinition)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReconciliationDetail_SystemConstant");
        });

        modelBuilder.Entity<ReconciliationSummary>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_RecounciliationSummary");

            entity.ToTable("ReconciliationSummary", "setting");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasColumnName("code");
            entity.Property(e => e.Comparision).HasColumnName("comparision");
            entity.Property(e => e.ComparisionType).HasColumnName("comparisionType");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");

            entity.HasOne(d => d.ComparisionNavigation).WithMany(p => p.ReconciliationSummaryComparisionNavigations)
                .HasForeignKey(d => d.Comparision)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReconciliationSummary_SystemConstant");

            entity.HasOne(d => d.ComparisionTypeNavigation).WithMany(p => p.ReconciliationSummaryComparisionTypeNavigations)
                .HasForeignKey(d => d.ComparisionType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReconciliationSummary_SystemConstant1");
        });

        modelBuilder.Entity<Relation>(entity =>
        {
            entity.ToTable("Relation", "common");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.ReferencedObject).HasColumnName("referencedObject");
            entity.Property(e => e.ReferringObject).HasColumnName("referringObject");
            entity.Property(e => e.RelationLevel).HasColumnName("relationLevel");
            entity.Property(e => e.RelationType).HasColumnName("relationType");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");

            entity.HasOne(d => d.RelationTypeNavigation).WithMany(p => p.Relations)
                .HasForeignKey(d => d.RelationType)
                .HasConstraintName("FK_Relation_SystemConstant");
        });

        modelBuilder.Entity<RelationalState>(entity =>
        {
            entity.ToTable("RelationalState", "setting");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Criteria)
                .HasMaxLength(50)
                .HasColumnName("criteria");
            entity.Property(e => e.Relation).HasColumnName("relation");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.State).HasColumnName("state");

            entity.HasOne(d => d.RelationNavigation).WithMany(p => p.RelationalStates)
                .HasForeignKey(d => d.Relation)
                .HasConstraintName("FK_RelationalState_Relation");

            entity.HasOne(d => d.StateNavigation).WithMany(p => p.RelationalStates)
                .HasForeignKey(d => d.State)
                .HasConstraintName("FK_RelationalState_ObjectStateDefinition");
        });

        modelBuilder.Entity<Report>(entity =>
        {
            entity.ToTable("Report", "setting");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasColumnName("code");
            entity.Property(e => e.CustomName)
                .HasMaxLength(50)
                .HasColumnName("customName");
            entity.Property(e => e.DefaultName)
                .HasMaxLength(50)
                .HasColumnName("defaultName");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.Index).HasColumnName("index");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.Pointer).HasColumnName("pointer");
            entity.Property(e => e.Reference)
                .HasMaxLength(50)
                .HasColumnName("reference");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.ReportType).HasColumnName("reportType");
            entity.Property(e => e.Url)
                .HasMaxLength(256)
                .HasColumnName("url");

            entity.HasOne(d => d.CategoryNavigation).WithMany(p => p.ReportCategoryNavigations)
                .HasForeignKey(d => d.Category)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Report_SystemConstant1");

            entity.HasOne(d => d.PointerNavigation).WithMany(p => p.ReportPointerNavigations)
                .HasForeignKey(d => d.Pointer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Report_SystemConstant");

            entity.HasOne(d => d.ReportTypeNavigation).WithMany(p => p.ReportReportTypeNavigations)
                .HasForeignKey(d => d.ReportType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Report_SystemConstant2");
        });

        modelBuilder.Entity<ReportHistory>(entity =>
        {
            entity.ToTable("ReportHistory", "common");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Mtd)
                .HasMaxLength(50)
                .HasColumnName("mtd");
            entity.Property(e => e.Period).HasColumnName("period");
            entity.Property(e => e.Reference)
                .HasMaxLength(1000)
                .HasColumnName("reference");
            entity.Property(e => e.Remark).HasColumnName("remark");
            entity.Property(e => e.Report)
                .HasMaxLength(50)
                .HasColumnName("report");
            entity.Property(e => e.ReportValue)
                .HasMaxLength(50)
                .HasColumnName("reportValue");
            entity.Property(e => e.Ytd)
                .HasMaxLength(50)
                .HasColumnName("ytd");

            entity.HasOne(d => d.PeriodNavigation).WithMany(p => p.ReportHistories)
                .HasForeignKey(d => d.Period)
                .HasConstraintName("FK_ReportHistory_ReportHistory");
        });

        modelBuilder.Entity<RequiredGsl>(entity =>
        {
            entity.ToTable("RequiredGSL", "setting");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.Index).HasColumnName("index");
            entity.Property(e => e.IsMandatory).HasColumnName("isMandatory");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.VoucherDefn).HasColumnName("voucherDefn");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.RequiredGslTypeNavigations)
                .HasForeignKey(d => d.Type)
                .HasConstraintName("FK_RequiredGSL_SystemConstant1");

            entity.HasOne(d => d.VoucherDefnNavigation).WithMany(p => p.RequiredGslVoucherDefnNavigations)
                .HasForeignKey(d => d.VoucherDefn)
                .HasConstraintName("FK_RequiredGSL_SystemConstant");
        });

        modelBuilder.Entity<RequiredGsldetail>(entity =>
        {
            entity.ToTable("RequiredGSLDetail", "setting");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GslType).HasColumnName("gslType");
            entity.Property(e => e.Index).HasColumnName("index");
            entity.Property(e => e.ObjectState).HasColumnName("objectState");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.RequiredGsl).HasColumnName("requiredGSL");

            entity.HasOne(d => d.GslTypeNavigation).WithMany(p => p.RequiredGsldetails)
                .HasForeignKey(d => d.GslType)
                .HasConstraintName("FK_RequiredGSLDetail_SystemConstant");

            entity.HasOne(d => d.ObjectStateNavigation).WithMany(p => p.RequiredGsldetails)
                .HasForeignKey(d => d.ObjectState)
                .HasConstraintName("FK_RequiredGSLDetail_ObjectStateDefinition");

            entity.HasOne(d => d.RequiredGslNavigation).WithMany(p => p.RequiredGsldetails)
                .HasForeignKey(d => d.RequiredGsl)
                .HasConstraintName("FK_RequiredGSLDetail_RequiredGSL");
        });

        modelBuilder.Entity<RoleActivity>(entity =>
        {
            entity.ToTable("RoleActivity", "security");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActivityDefinition).HasColumnName("activityDefinition");
            entity.Property(e => e.Range).HasColumnName("range");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Role).HasColumnName("role");

            entity.HasOne(d => d.ActivityDefinitionNavigation).WithMany(p => p.RoleActivities)
                .HasForeignKey(d => d.ActivityDefinition)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoleActivity_ActivityDefinition");

            entity.HasOne(d => d.RangeNavigation).WithMany(p => p.RoleActivities)
                .HasForeignKey(d => d.Range)
                .HasConstraintName("FK_RoleActivity_Range");

            entity.HasOne(d => d.RoleNavigation).WithMany(p => p.RoleActivities)
                .HasForeignKey(d => d.Role)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoleActivity_ConsigneeUnit");
        });

        modelBuilder.Entity<Route>(entity =>
        {
            entity.ToTable("Route", "common");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Carrier)
                .HasMaxLength(50)
                .HasColumnName("carrier");
            entity.Property(e => e.Distance)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("distance");
            entity.Property(e => e.Duration)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("duration");
            entity.Property(e => e.FromCity).HasColumnName("fromCity");
            entity.Property(e => e.FromStation).HasColumnName("fromStation");
            entity.Property(e => e.ObjectState).HasColumnName("objectState");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.ToCity).HasColumnName("toCity");
            entity.Property(e => e.ToStation).HasColumnName("toStation");
            entity.Property(e => e.TransportType).HasColumnName("transportType");

            entity.HasOne(d => d.FromCityNavigation).WithMany(p => p.RouteFromCityNavigations)
                .HasForeignKey(d => d.FromCity)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Route_SubCountry");

            entity.HasOne(d => d.FromStationNavigation).WithMany(p => p.RouteFromStationNavigations)
                .HasForeignKey(d => d.FromStation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Route_SystemConstant2");

            entity.HasOne(d => d.ObjectStateNavigation).WithMany(p => p.Routes)
                .HasForeignKey(d => d.ObjectState)
                .HasConstraintName("FK_Route_ObjectStateDefinition");

            entity.HasOne(d => d.ToCityNavigation).WithMany(p => p.RouteToCityNavigations)
                .HasForeignKey(d => d.ToCity)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Route_SubCountry1");

            entity.HasOne(d => d.ToStationNavigation).WithMany(p => p.RouteToStationNavigations)
                .HasForeignKey(d => d.ToStation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Route_SystemConstant1");

            entity.HasOne(d => d.TransportTypeNavigation).WithMany(p => p.RouteTransportTypeNavigations)
                .HasForeignKey(d => d.TransportType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Route_SystemConstant");
        });

        modelBuilder.Entity<RouteAssignment>(entity =>
        {
            entity.ToTable("RouteAssignment", "common");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.OrgUnit).HasColumnName("orgUnit");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.ScheduleHeader).HasColumnName("scheduleHeader");
            entity.Property(e => e.Space).HasColumnName("space");

            entity.HasOne(d => d.OrgUnitNavigation).WithMany(p => p.RouteAssignments)
                .HasForeignKey(d => d.OrgUnit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RouteAssignment_ConsigneeUnit");

            entity.HasOne(d => d.ScheduleHeaderNavigation).WithMany(p => p.RouteAssignments)
                .HasForeignKey(d => d.ScheduleHeader)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RouteAssignment_ScheduleHeader");

            entity.HasOne(d => d.SpaceNavigation).WithMany(p => p.RouteAssignments)
                .HasForeignKey(d => d.Space)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RouteAssignment_Space");
        });

        modelBuilder.Entity<Schedule>(entity =>
        {
            entity.ToTable("Schedule", "common");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.Pointer).HasColumnName("pointer");
            entity.Property(e => e.Reference)
                .HasMaxLength(50)
                .HasColumnName("reference");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.ScheduledHeader).HasColumnName("scheduledHeader");

            entity.HasOne(d => d.PointerNavigation).WithMany(p => p.Schedules)
                .HasForeignKey(d => d.Pointer)
                .HasConstraintName("FK_Schedule_SystemConstant");

            entity.HasOne(d => d.ScheduledHeaderNavigation).WithMany(p => p.Schedules)
                .HasForeignKey(d => d.ScheduledHeader)
                .HasConstraintName("FK_Schedule_ScheduleHeader");
        });

        modelBuilder.Entity<ScheduleDetail>(entity =>
        {
            entity.ToTable("ScheduleDetail", "common");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DayMonth)
                .HasMaxLength(50)
                .HasColumnName("dayMonth");
            entity.Property(e => e.DayOfMonth).HasColumnName("dayOfMonth");
            entity.Property(e => e.EndTime)
                .HasMaxLength(50)
                .HasColumnName("endTime");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.StartTime)
                .HasMaxLength(50)
                .HasColumnName("startTime");

            entity.HasOne(d => d.SeheduleheaderNavigation).WithMany(p => p.ScheduleDetails)
                .HasForeignKey(d => d.Seheduleheader)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ScheduleDetail_ScheduleDetail");
        });

        modelBuilder.Entity<ScheduleHeader>(entity =>
        {
            entity.ToTable("ScheduleHeader", "common");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cateogry).HasColumnName("cateogry");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("endDate");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("startDate");
            entity.Property(e => e.Type).HasColumnName("type");

            entity.HasOne(d => d.CateogryNavigation).WithMany(p => p.ScheduleHeaderCateogryNavigations)
                .HasForeignKey(d => d.Cateogry)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ScheduleHeader_SystemConstant");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.ScheduleHeaderTypeNavigations)
                .HasForeignKey(d => d.Type)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ScheduleHeader_SystemConstant1");
        });

        modelBuilder.Entity<SeasonalMessage>(entity =>
        {
            entity.ToTable("SeasonalMessage", "common");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Font)
                .HasMaxLength(50)
                .HasColumnName("font");
            entity.Property(e => e.Message)
                .HasMaxLength(50)
                .HasColumnName("message");
            entity.Property(e => e.Period).HasColumnName("period");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");

            entity.HasOne(d => d.PeriodNavigation).WithMany(p => p.SeasonalMessages)
                .HasForeignKey(d => d.Period)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SeasonalMessage_SeasonalMessage");
        });

        modelBuilder.Entity<SeatArrangement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PPK_SeatArrangement");

            entity.ToTable("SeatArrangement", "common");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Class)
                .HasMaxLength(26)
                .HasColumnName("class");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Remark).HasColumnName("remark");
            entity.Property(e => e.Space).HasColumnName("space");
            entity.Property(e => e.Type)
                .HasMaxLength(26)
                .HasColumnName("type");
            entity.Property(e => e.Zone)
                .HasMaxLength(50)
                .HasColumnName("zone");

            entity.HasOne(d => d.SpaceNavigation).WithMany(p => p.SeatArrangements)
                .HasForeignKey(d => d.Space)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SeatArrangement_SeatArrangement");
        });

        modelBuilder.Entity<SeatTransaction>(entity =>
        {
            entity.ToTable("SeatTransaction", "common");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Lineitem).HasColumnName("lineitem");
            entity.Property(e => e.Movieschedule).HasColumnName("movieschedule");
            entity.Property(e => e.Remark).HasColumnName("remark");
            entity.Property(e => e.Seatarrangement).HasColumnName("seatarrangement");
            entity.Property(e => e.Voudef).HasColumnName("voudef");

            entity.HasOne(d => d.LineitemNavigation).WithMany(p => p.SeatTransactions)
                .HasForeignKey(d => d.Lineitem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SeatTransaction_LineItem");

            entity.HasOne(d => d.MoviescheduleNavigation).WithMany(p => p.SeatTransactions)
                .HasForeignKey(d => d.Movieschedule)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SeatTransaction_MovieSchedule");

            entity.HasOne(d => d.SeatarrangementNavigation).WithMany(p => p.SeatTransactions)
                .HasForeignKey(d => d.Seatarrangement)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SeatTransaction_SeatArrangement");

            entity.HasOne(d => d.VoudefNavigation).WithMany(p => p.SeatTransactions)
                .HasForeignKey(d => d.Voudef)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SeatTransaction_SystemConstant");
        });

        modelBuilder.Entity<SerialDefinition>(entity =>
        {
            entity.ToTable("SerialDefinition", "article");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Article).HasColumnName("article");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.IsMandatory).HasColumnName("isMandatory");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");

            entity.HasOne(d => d.ArticleNavigation).WithMany(p => p.SerialDefinitions)
                .HasForeignKey(d => d.Article)
                .HasConstraintName("FK_SerialDefinition_SerialDefinition");
        });

        modelBuilder.Entity<Space>(entity =>
        {
            entity.ToTable("Space", "common");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.OrganizationalUnit).HasColumnName("organizationalUnit");
            entity.Property(e => e.Parent).HasColumnName("parent");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Type).HasColumnName("type");

            entity.HasOne(d => d.CategoryNavigation).WithMany(p => p.SpaceCategoryNavigations)
                .HasForeignKey(d => d.Category)
                .HasConstraintName("FK_Space_SystemConstant1");

            entity.HasOne(d => d.OrganizationalUnitNavigation).WithMany(p => p.Spaces)
                .HasForeignKey(d => d.OrganizationalUnit)
                .HasConstraintName("FK_Space_ConsigneeUnit");

            entity.HasOne(d => d.ParentNavigation).WithMany(p => p.InverseParentNavigation)
                .HasForeignKey(d => d.Parent)
                .HasConstraintName("FK_Space_Space1");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.SpaceTypeNavigations)
                .HasForeignKey(d => d.Type)
                .HasConstraintName("FK_Space_SystemConstant");
        });

        modelBuilder.Entity<SpaceDirection>(entity =>
        {
            entity.ToTable("SpaceDirection", "common");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Device).HasColumnName("device");
            entity.Property(e => e.Direction)
                .HasMaxLength(50)
                .HasColumnName("direction");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Space).HasColumnName("space");

            entity.HasOne(d => d.DeviceNavigation).WithMany(p => p.SpaceDirections)
                .HasForeignKey(d => d.Device)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SpaceDirection_Device");

            entity.HasOne(d => d.SpaceNavigation).WithMany(p => p.SpaceDirections)
                .HasForeignKey(d => d.Space)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SpaceDirection_Space");
        });

        modelBuilder.Entity<Specification>(entity =>
        {
            entity.ToTable("Specification", "article");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Article).HasColumnName("article");
            entity.Property(e => e.Attribute).HasColumnName("attribute");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.Font)
                .HasMaxLength(50)
                .HasColumnName("font");
            entity.Property(e => e.Index).HasColumnName("index");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Value).HasColumnName("value");

            entity.HasOne(d => d.ArticleNavigation).WithMany(p => p.Specifications)
                .HasForeignKey(d => d.Article)
                .HasConstraintName("FK_Specification_Article");

            entity.HasOne(d => d.CategoryNavigation).WithMany(p => p.Specifications)
                .HasForeignKey(d => d.Category)
                .HasConstraintName("FK_Specification_Preference");
        });

        modelBuilder.Entity<StockBalance>(entity =>
        {
            entity.ToTable("StockBalance", "article");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Article).HasColumnName("article");
            entity.Property(e => e.Period).HasColumnName("period");
            entity.Property(e => e.Quantity)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("quantity");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Store).HasColumnName("store");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Uom).HasColumnName("uom");

            entity.HasOne(d => d.ArticleNavigation).WithMany(p => p.StockBalances)
                .HasForeignKey(d => d.Article)
                .HasConstraintName("FK_StockBalance_Article");

            entity.HasOne(d => d.PeriodNavigation).WithMany(p => p.StockBalances)
                .HasForeignKey(d => d.Period)
                .HasConstraintName("FK_StockBalance_Period");

            entity.HasOne(d => d.StoreNavigation).WithMany(p => p.StockBalances)
                .HasForeignKey(d => d.Store)
                .HasConstraintName("FK_StockBalance_ConsigneeUnit");

            entity.HasOne(d => d.UomNavigation).WithMany(p => p.StockBalances)
                .HasForeignKey(d => d.Uom)
                .HasConstraintName("FK_StockBalance_Lookup");
        });

        modelBuilder.Entity<StockLevel>(entity =>
        {
            entity.ToTable("StockLevel", "article");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Article).HasColumnName("article");
            entity.Property(e => e.EconomicOrderQty)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("economicOrderQty");
            entity.Property(e => e.LeadTimeDays).HasColumnName("leadTimeDays");
            entity.Property(e => e.MaxLevel)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("maxLevel");
            entity.Property(e => e.MinLevel)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("minLevel");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Store).HasColumnName("store");

            entity.HasOne(d => d.ArticleNavigation).WithMany(p => p.StockLevels)
                .HasForeignKey(d => d.Article)
                .HasConstraintName("FK_StockLevel_Article");

            entity.HasOne(d => d.StoreNavigation).WithMany(p => p.StockLevels)
                .HasForeignKey(d => d.Store)
                .HasConstraintName("FK_StockLevel_ConsigneeUnit");
        });

        modelBuilder.Entity<SubCountry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Subcount__3213E83F2C8A5738");

            entity.ToTable("SubCountry", "common");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AlternativeName)
                .HasMaxLength(50)
                .HasColumnName("alternativeName");
            entity.Property(e => e.Country).HasColumnName("country");
            entity.Property(e => e.Gps)
                .HasMaxLength(50)
                .HasColumnName("gps");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Parent)
                .HasMaxLength(50)
                .HasColumnName("parent");
            entity.Property(e => e.Population).HasColumnName("population");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Type).HasColumnName("type");

            entity.HasOne(d => d.CountryNavigation).WithMany(p => p.SubCountries)
                .HasForeignKey(d => d.Country)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SubCountry_Country");
        });

        modelBuilder.Entity<Subtitle>(entity =>
        {
            entity.ToTable("Subtitle", "common");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Language).HasColumnName("language");
            entity.Property(e => e.Media).HasColumnName("media");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");
            entity.Property(e => e.Url)
                .HasMaxLength(100)
                .HasColumnName("url");

            entity.HasOne(d => d.LanguageNavigation).WithMany(p => p.Subtitles)
                .HasForeignKey(d => d.Language)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Subtitle_Language");

            entity.HasOne(d => d.MediaNavigation).WithMany(p => p.Subtitles)
                .HasForeignKey(d => d.Media)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Subtitle_CNETMedia");
        });

        modelBuilder.Entity<SystemConstant>(entity =>
        {
            entity.ToTable("SystemConstant", "setting");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .HasColumnName("category");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.Index).HasColumnName("index");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsDefault).HasColumnName("isDefault");
            entity.Property(e => e.ParenId).HasColumnName("parenId");
            entity.Property(e => e.Remark).HasColumnName("remark");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");
            entity.Property(e => e.Value)
                .HasMaxLength(50)
                .HasColumnName("value");
        });

        modelBuilder.Entity<Tax>(entity =>
        {
            entity.ToTable("Tax", "setting");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");

            entity.HasOne(d => d.CategoryNavigation).WithMany(p => p.Taxes)
                .HasForeignKey(d => d.Category)
                .HasConstraintName("FK_Tax_SystemConstant");
        });

        modelBuilder.Entity<TaxTransaction>(entity =>
        {
            entity.ToTable("TaxTransaction", "transaction");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("money")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxType).HasColumnName("taxType");
            entity.Property(e => e.TaxableAmount)
                .HasColumnType("money")
                .HasColumnName("taxableAmount");
            entity.Property(e => e.Voucher).HasColumnName("voucher");

            entity.HasOne(d => d.TaxTypeNavigation).WithMany(p => p.TaxTransactions)
                .HasForeignKey(d => d.TaxType)
                .HasConstraintName("FK_TaxTransaction_Tax");

            entity.HasOne(d => d.VoucherNavigation).WithMany(p => p.TaxTransactions)
                .HasForeignKey(d => d.Voucher)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TaxTransaction_Voucher");
        });

        modelBuilder.Entity<TermDefinition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TermList__3213E83F0813FCE1");

            entity.ToTable("TermDefinition", "setting");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.DefaultValue)
                .HasMaxLength(50)
                .HasColumnName("defaultValue");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.IsMandatory).HasColumnName("isMandatory");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.VoucherDefn).HasColumnName("voucherDefn");

            entity.HasOne(d => d.CategoryNavigation).WithMany(p => p.TermDefinitionCategoryNavigations)
                .HasForeignKey(d => d.Category)
                .HasConstraintName("FK_TermDefinition_SystemConstant1");

            entity.HasOne(d => d.VoucherDefnNavigation).WithMany(p => p.TermDefinitionVoucherDefnNavigations)
                .HasForeignKey(d => d.VoucherDefn)
                .HasConstraintName("FK_TermDefinition_SystemConstant");
        });

        modelBuilder.Entity<TransactionCurrency>(entity =>
        {
            entity.ToTable("TransactionCurrency", "transaction");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("amount");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("rate");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("total");
            entity.Property(e => e.Voucher).HasColumnName("voucher");

            entity.HasOne(d => d.CurrencyNavigation).WithMany(p => p.TransactionCurrencies)
                .HasForeignKey(d => d.Currency)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransactionCurrency_Currency");

            entity.HasOne(d => d.VoucherNavigation).WithMany(p => p.TransactionCurrencies)
                .HasForeignKey(d => d.Voucher)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransactionCurrency_Voucher");
        });

        modelBuilder.Entity<TransactionLimit>(entity =>
        {
            entity.ToTable("TransactionLimit", "consignee");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Consignee).HasColumnName("consignee");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.LimitFactor).HasColumnName("limitFactor");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Value)
                .HasMaxLength(50)
                .HasColumnName("value");

            entity.HasOne(d => d.ConsigneeNavigation).WithMany(p => p.TransactionLimits)
                .HasForeignKey(d => d.Consignee)
                .HasConstraintName("FK_TransactionLimit_Consignee");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.TransactionLimits)
                .HasForeignKey(d => d.Type)
                .HasConstraintName("FK_TransactionLimit_SystemConstant");
        });

        modelBuilder.Entity<TransactionReference>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TransactionReference_1");

            entity.ToTable("TransactionReference", "transaction");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Referenced).HasColumnName("referenced");
            entity.Property(e => e.ReferencedVoucherDefn).HasColumnName("referencedVoucherDefn");
            entity.Property(e => e.ReferencingVoucherDefn).HasColumnName("referencingVoucherDefn");
            entity.Property(e => e.Referring).HasColumnName("referring");
            entity.Property(e => e.RelationType).HasColumnName("relationType");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Value)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("value");

            entity.HasOne(d => d.ReferencedNavigation).WithMany(p => p.TransactionReferenceReferencedNavigations)
                .HasForeignKey(d => d.Referenced)
                .HasConstraintName("FK_TransactionReference_Voucher1");

            entity.HasOne(d => d.ReferencedVoucherDefnNavigation).WithMany(p => p.TransactionReferenceReferencedVoucherDefnNavigations)
                .HasForeignKey(d => d.ReferencedVoucherDefn)
                .HasConstraintName("FK_TransactionReference_SystemConstant1");

            entity.HasOne(d => d.ReferencingVoucherDefnNavigation).WithMany(p => p.TransactionReferenceReferencingVoucherDefnNavigations)
                .HasForeignKey(d => d.ReferencingVoucherDefn)
                .HasConstraintName("FK_TransactionReference_SystemConstant");

            entity.HasOne(d => d.ReferringNavigation).WithMany(p => p.TransactionReferenceReferringNavigations)
                .HasForeignKey(d => d.Referring)
                .HasConstraintName("FK_TransactionReference_Voucher");

            entity.HasOne(d => d.RelationTypeNavigation).WithMany(p => p.TransactionReferenceRelationTypeNavigations)
                .HasForeignKey(d => d.RelationType)
                .HasConstraintName("FK_TransactionReference_SystemConstant2");
        });

        modelBuilder.Entity<TrialBalance>(entity =>
        {
            entity.ToTable("TrialBalance", "accounting");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Account)
                .HasMaxLength(50)
                .HasColumnName("account");
            entity.Property(e => e.ConsigneeUnit).HasColumnName("consigneeUnit");
            entity.Property(e => e.Credit)
                .HasColumnType("money")
                .HasColumnName("credit");
            entity.Property(e => e.Debit)
                .HasColumnType("money")
                .HasColumnName("debit");
            entity.Property(e => e.Period).HasColumnName("period");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'worksheet')")
                .HasColumnName("type");

            entity.HasOne(d => d.PeriodNavigation).WithMany(p => p.TrialBalances)
                .HasForeignKey(d => d.Period)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TrialBalance_TrialBalance");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User", "security");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LoggedInStatus).HasColumnName("loggedInStatus");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.Person).HasColumnName("person");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .HasColumnName("userName");

            entity.HasOne(d => d.PersonNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.Person)
                .HasConstraintName("FK_User_Consignee");
        });

        modelBuilder.Entity<UserRoleMapper>(entity =>
        {
            entity.ToTable("UserRoleMapper", "security");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("expiryDate");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Role).HasColumnName("role");
            entity.Property(e => e.User).HasColumnName("user");

            entity.HasOne(d => d.RoleNavigation).WithMany(p => p.UserRoleMappers)
                .HasForeignKey(d => d.Role)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserRoleMapper_ConsigneeUnit");

            entity.HasOne(d => d.UserNavigation).WithMany(p => p.UserRoleMappers)
                .HasForeignKey(d => d.User)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserRoleMapper_User");
        });

        modelBuilder.Entity<Value>(entity =>
        {
            entity.ToTable("Value", "article");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Article).HasColumnName("article");
            entity.Property(e => e.ConsigneeUnit).HasColumnName("consigneeUnit");
            entity.Property(e => e.CreatedTimeStamp)
                .HasColumnType("datetime")
                .HasColumnName("createdTimeStamp");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.EndTimeStamp)
                .HasColumnType("datetime")
                .HasColumnName("endTimeStamp");
            entity.Property(e => e.IsDefault).HasColumnName("isDefault");
            entity.Property(e => e.LastModified)
                .HasColumnType("datetime")
                .HasColumnName("lastModified");
            entity.Property(e => e.Locked).HasColumnName("locked");
            entity.Property(e => e.MaxCount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("maxCount");
            entity.Property(e => e.MinCount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("minCount");
            entity.Property(e => e.NewValue)
                .HasColumnType("money")
                .HasColumnName("newValue");
            entity.Property(e => e.OldValue)
                .HasColumnType("money")
                .HasColumnName("oldValue");
            entity.Property(e => e.Priority).HasColumnName("priority");
            entity.Property(e => e.Remark).HasColumnName("remark");
            entity.Property(e => e.Schedule).HasColumnName("schedule");
            entity.Property(e => e.StartTimeStamp)
                .HasColumnType("datetime")
                .HasColumnName("startTimeStamp");

            entity.HasOne(d => d.ArticleNavigation).WithMany(p => p.Values)
                .HasForeignKey(d => d.Article)
                .HasConstraintName("FK_Value_Article");

            entity.HasOne(d => d.ConsigneeUnitNavigation).WithMany(p => p.Values)
                .HasForeignKey(d => d.ConsigneeUnit)
                .HasConstraintName("FK_Value_ConsigneeUnit");

            entity.HasOne(d => d.ScheduleNavigation).WithMany(p => p.Values)
                .HasForeignKey(d => d.Schedule)
                .HasConstraintName("FK_Value_Schedule");
        });

        modelBuilder.Entity<ValueChangeLog>(entity =>
        {
            entity.ToTable("ValueChangeLog", "article");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Activity).HasColumnName("activity");
            entity.Property(e => e.Article).HasColumnName("article");
            entity.Property(e => e.NewValue)
                .HasColumnType("money")
                .HasColumnName("newValue");
            entity.Property(e => e.PreviousValue)
                .HasColumnType("money")
                .HasColumnName("previousValue");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("timeStamp");

            entity.HasOne(d => d.ArticleNavigation).WithMany(p => p.ValueChangeLogs)
                .HasForeignKey(d => d.Article)
                .HasConstraintName("FK_ValueChangeLog_Article");
        });

        modelBuilder.Entity<ValueFactor>(entity =>
        {
            entity.ToTable("ValueFactor", "common");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.Pointer).HasColumnName("pointer");
            entity.Property(e => e.Reference).HasColumnName("reference");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.ValueFactorDefinition).HasColumnName("valueFactorDefinition");

            entity.HasOne(d => d.PointerNavigation).WithMany(p => p.ValueFactors)
                .HasForeignKey(d => d.Pointer)
                .HasConstraintName("FK_ValueFactor_SystemConstant");

            entity.HasOne(d => d.ValueFactorDefinitionNavigation).WithMany(p => p.ValueFactors)
                .HasForeignKey(d => d.ValueFactorDefinition)
                .HasConstraintName("FK_ValueFactor_ValueFactorDefinition");
        });

        modelBuilder.Entity<ValueFactorDefinition>(entity =>
        {
            entity.ToTable("ValueFactorDefinition", "setting");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.IsPercent).HasColumnName("isPercent");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Value)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("value");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.ValueFactorDefinitions)
                .HasForeignKey(d => d.Type)
                .HasConstraintName("FK_ValueFactorDefinition_SystemConstant");
        });

        modelBuilder.Entity<ValueFactorSetup>(entity =>
        {
            entity.ToTable("ValueFactorSetup", "setting");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Destination)
                .HasMaxLength(50)
                .HasColumnName("destination");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Source)
                .HasMaxLength(50)
                .HasColumnName("source");
            entity.Property(e => e.ValueFactorDefinition).HasColumnName("valueFactorDefinition");
            entity.Property(e => e.VoucherDefinition).HasColumnName("voucherDefinition");

            entity.HasOne(d => d.ValueFactorDefinitionNavigation).WithMany(p => p.ValueFactorSetups)
                .HasForeignKey(d => d.ValueFactorDefinition)
                .HasConstraintName("FK_ValueFactorSetup_ValueFactorDefinition");

            entity.HasOne(d => d.VoucherDefinitionNavigation).WithMany(p => p.ValueFactorSetups)
                .HasForeignKey(d => d.VoucherDefinition)
                .HasConstraintName("FK_ValueFactorSetup_SystemConstant");
        });

        modelBuilder.Entity<Voucher>(entity =>
        {
            entity.ToTable("Voucher", "transaction");

            entity.HasIndex(e => e.Code, "IX_Voucher").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AdditionalCharge)
                .HasColumnType("money")
                .HasColumnName("additionalCharge");
            entity.Property(e => e.Cart).HasColumnName("cart");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasColumnName("code");
            entity.Property(e => e.Consignee1).HasColumnName("consignee1");
            entity.Property(e => e.Consignee2).HasColumnName("consignee2");
            entity.Property(e => e.Consignee3).HasColumnName("consignee3");
            entity.Property(e => e.Consignee4).HasColumnName("consignee4");
            entity.Property(e => e.Consignee5).HasColumnName("consignee5");
            entity.Property(e => e.Consignee6).HasColumnName("consignee6");
            entity.Property(e => e.ConsigneeUnit1).HasColumnName("consigneeUnit1");
            entity.Property(e => e.ConsigneeUnit2).HasColumnName("consigneeUnit2");
            entity.Property(e => e.ConsigneeUnit3).HasColumnName("consigneeUnit3");
            entity.Property(e => e.ConsigneeUnit4).HasColumnName("consigneeUnit4");
            entity.Property(e => e.ConsigneeUnit5).HasColumnName("consigneeUnit5");
            entity.Property(e => e.ConsigneeUnit6).HasColumnName("consigneeUnit6");
            entity.Property(e => e.CreatedOn)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("createdOn");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.DefaultImageUrl).HasColumnName("defaultImageUrl");
            entity.Property(e => e.Definition).HasColumnName("definition");
            entity.Property(e => e.DestinationConsigneeUnit).HasColumnName("destinationConsigneeUnit");
            entity.Property(e => e.DestinationStore).HasColumnName("destinationStore");
            entity.Property(e => e.Discount)
                .HasColumnType("money")
                .HasColumnName("discount");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("endDate");
            entity.Property(e => e.ExchangeRate).HasColumnName("exchangeRate");
            entity.Property(e => e.Extension1)
                .HasMaxLength(50)
                .HasColumnName("extension1");
            entity.Property(e => e.Extension2)
                .HasMaxLength(50)
                .HasColumnName("extension2");
            entity.Property(e => e.Extension3)
                .HasMaxLength(50)
                .HasColumnName("extension3");
            entity.Property(e => e.Extension4)
                .HasMaxLength(50)
                .HasColumnName("extension4");
            entity.Property(e => e.Extension5)
                .HasColumnType("datetime")
                .HasColumnName("extension5");
            entity.Property(e => e.Extension6)
                .HasColumnType("datetime")
                .HasColumnName("extension6");
            entity.Property(e => e.FsNumber)
                .HasMaxLength(50)
                .HasColumnName("fsNumber");
            entity.Property(e => e.GrandTotal)
                .HasColumnType("money")
                .HasColumnName("grandTotal");
            entity.Property(e => e.HasEffect).HasColumnName("hasEffect");
            entity.Property(e => e.IsIssued).HasColumnName("isIssued");
            entity.Property(e => e.IsVoid).HasColumnName("isVoid");
            entity.Property(e => e.IssuedDate)
                .HasColumnType("datetime")
                .HasColumnName("issuedDate");
            entity.Property(e => e.LastActivity).HasColumnName("lastActivity");
            entity.Property(e => e.LastDevice).HasColumnName("lastDevice");
            entity.Property(e => e.LastModified)
                .HasColumnType("datetime")
                .HasColumnName("lastModified");
            entity.Property(e => e.LastState).HasColumnName("lastState");
            entity.Property(e => e.LastUser).HasColumnName("lastUser");
            entity.Property(e => e.Latitiude)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("latitiude");
            entity.Property(e => e.Locked).HasColumnName("locked");
            entity.Property(e => e.Longitude)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("longitude");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Mrc)
                .HasMaxLength(50)
                .HasColumnName("mrc");
            entity.Property(e => e.Note)
                .HasMaxLength(50)
                .HasColumnName("note");
            entity.Property(e => e.OriginConsigneeUnit).HasColumnName("originConsigneeUnit");
            entity.Property(e => e.PaymentMethod).HasColumnName("paymentMethod");
            entity.Property(e => e.Period).HasColumnName("period");
            entity.Property(e => e.Purpose).HasColumnName("purpose");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Shift).HasColumnName("shift");
            entity.Property(e => e.SourceStore).HasColumnName("sourceStore");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("startDate");
            entity.Property(e => e.SubTotal)
                .HasColumnType("money")
                .HasColumnName("subTotal");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.Consignee1Navigation).WithMany(p => p.VoucherConsignee1Navigations)
                .HasForeignKey(d => d.Consignee1)
                .HasConstraintName("FK_Voucher_Consignee");

            entity.HasOne(d => d.Consignee2Navigation).WithMany(p => p.VoucherConsignee2Navigations)
                .HasForeignKey(d => d.Consignee2)
                .HasConstraintName("FK_Voucher_Consignee1");

            entity.HasOne(d => d.Consignee3Navigation).WithMany(p => p.VoucherConsignee3Navigations)
                .HasForeignKey(d => d.Consignee3)
                .HasConstraintName("FK_Voucher_Consignee2");

            entity.HasOne(d => d.Consignee31).WithMany(p => p.VoucherConsignee31s)
                .HasForeignKey(d => d.Consignee3)
                .HasConstraintName("FK_Voucher_ConsigneeUnit4");

            entity.HasOne(d => d.Consignee4Navigation).WithMany(p => p.VoucherConsignee4Navigations)
                .HasForeignKey(d => d.Consignee4)
                .HasConstraintName("FK_Voucher_Consignee3");

            entity.HasOne(d => d.Consignee41).WithMany(p => p.VoucherConsignee41s)
                .HasForeignKey(d => d.Consignee4)
                .HasConstraintName("FK_Voucher_ConsigneeUnit7");

            entity.HasOne(d => d.Consignee5Navigation).WithMany(p => p.VoucherConsignee5Navigations)
                .HasForeignKey(d => d.Consignee5)
                .HasConstraintName("FK_Voucher_Consignee4");

            entity.HasOne(d => d.Consignee6Navigation).WithMany(p => p.VoucherConsignee6Navigations)
                .HasForeignKey(d => d.Consignee6)
                .HasConstraintName("FK_Voucher_Consignee5");

            entity.HasOne(d => d.Consignee61).WithMany(p => p.VoucherConsignee61s)
                .HasForeignKey(d => d.Consignee6)
                .HasConstraintName("FK_Voucher_ConsigneeUnit6");

            entity.HasOne(d => d.ConsigneeUnit1Navigation).WithMany(p => p.VoucherConsigneeUnit1Navigations)
                .HasForeignKey(d => d.ConsigneeUnit1)
                .HasConstraintName("FK_Voucher_ConsigneeUnit2");

            entity.HasOne(d => d.ConsigneeUnit2Navigation).WithMany(p => p.VoucherConsigneeUnit2Navigations)
                .HasForeignKey(d => d.ConsigneeUnit2)
                .HasConstraintName("FK_Voucher_ConsigneeUnit3");

            entity.HasOne(d => d.ConsigneeUnit5Navigation).WithMany(p => p.VoucherConsigneeUnit5Navigations)
                .HasForeignKey(d => d.ConsigneeUnit5)
                .HasConstraintName("FK_Voucher_ConsigneeUnit5");

            entity.HasOne(d => d.DefinitionNavigation).WithMany(p => p.VoucherDefinitionNavigations)
                .HasForeignKey(d => d.Definition)
                .HasConstraintName("FK_Voucher_SystemConstant1");

            entity.HasOne(d => d.DestinationConsigneeUnitNavigation).WithMany(p => p.VoucherDestinationConsigneeUnitNavigations)
                .HasForeignKey(d => d.DestinationConsigneeUnit)
                .HasConstraintName("FK_Voucher_ConsigneeUnit1");

            entity.HasOne(d => d.DestinationStoreNavigation).WithMany(p => p.VoucherDestinationStoreNavigations)
                .HasForeignKey(d => d.DestinationStore)
                .HasConstraintName("FK_Voucher_ConsigneeUnit9");

            entity.HasOne(d => d.LastActivityNavigation).WithMany(p => p.Vouchers)
                .HasForeignKey(d => d.LastActivity)
                .HasConstraintName("FK_Voucher_Activity");

            entity.HasOne(d => d.LastDeviceNavigation).WithMany(p => p.Vouchers)
                .HasForeignKey(d => d.LastDevice)
                .HasConstraintName("FK_Voucher_Device");

            entity.HasOne(d => d.LastStateNavigation).WithMany(p => p.Vouchers)
                .HasForeignKey(d => d.LastState)
                .HasConstraintName("FK_Voucher_ObjectStateDefinition");

            entity.HasOne(d => d.LastUserNavigation).WithMany(p => p.Vouchers)
                .HasForeignKey(d => d.LastUser)
                .HasConstraintName("FK_Voucher_User");

            entity.HasOne(d => d.OriginConsigneeUnitNavigation).WithMany(p => p.VoucherOriginConsigneeUnitNavigations)
                .HasForeignKey(d => d.OriginConsigneeUnit)
                .HasConstraintName("FK_Voucher_ConsigneeUnit");

            entity.HasOne(d => d.PeriodNavigation).WithMany(p => p.VoucherPeriodNavigations)
                .HasForeignKey(d => d.Period)
                .HasConstraintName("FK_Voucher_Period");

            entity.HasOne(d => d.ShiftNavigation).WithMany(p => p.VoucherShiftNavigations)
                .HasForeignKey(d => d.Shift)
                .HasConstraintName("FK_Voucher_Period1");

            entity.HasOne(d => d.SourceStoreNavigation).WithMany(p => p.VoucherSourceStoreNavigations)
                .HasForeignKey(d => d.SourceStore)
                .HasConstraintName("FK_Voucher_ConsigneeUnit8");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.VoucherTypeNavigations)
                .HasForeignKey(d => d.Type)
                .HasConstraintName("FK_Voucher_SystemConstant");
        });

        modelBuilder.Entity<VoucherAccount>(entity =>
        {
            entity.ToTable("VoucherAccount", "transaction");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountCode)
                .HasMaxLength(50)
                .HasColumnName("accountCode");
            entity.Property(e => e.Amount)
                .HasColumnType("money")
                .HasColumnName("amount");
            entity.Property(e => e.Remark).HasColumnName("remark");
            entity.Property(e => e.Voucher).HasColumnName("voucher");

            entity.HasOne(d => d.VoucherNavigation).WithMany(p => p.VoucherAccounts)
                .HasForeignKey(d => d.Voucher)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VoucherAccount_Voucher");
        });

        modelBuilder.Entity<VoucherConsigneeList>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_VoucherCnosigneeList");

            entity.ToTable("VoucherConsigneeList", "transaction");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Consignee).HasColumnName("consignee");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Voucher).HasColumnName("voucher");

            entity.HasOne(d => d.ConsigneeNavigation).WithMany(p => p.VoucherConsigneeLists)
                .HasForeignKey(d => d.Consignee)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VoucherConsigneeList_Consignee");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.VoucherConsigneeLists)
                .HasForeignKey(d => d.Type)
                .HasConstraintName("FK_VoucherConsigneeList_SystemConstant");

            entity.HasOne(d => d.VoucherNavigation).WithMany(p => p.VoucherConsigneeLists)
                .HasForeignKey(d => d.Voucher)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VoucherConsigneeList_Voucher");
        });

        modelBuilder.Entity<VoucherExtension>(entity =>
        {
            entity.ToTable("VoucherExtension", "common");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descritpion)
                .HasMaxLength(50)
                .HasColumnName("descritpion");
            entity.Property(e => e.Index).HasColumnName("index");
            entity.Property(e => e.IsMandatory).HasColumnName("isMandatory");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.VoucherDefn).HasColumnName("voucherDefn");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.VoucherExtensionTypeNavigations)
                .HasForeignKey(d => d.Type)
                .HasConstraintName("FK_VoucherExtension_SystemConstant1");

            entity.HasOne(d => d.VoucherDefnNavigation).WithMany(p => p.VoucherExtensionVoucherDefnNavigations)
                .HasForeignKey(d => d.VoucherDefn)
                .HasConstraintName("FK_VoucherExtension_SystemConstant");
        });

        modelBuilder.Entity<VoucherLookupList>(entity =>
        {
            entity.ToTable("VoucherLookupList", "transaction");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.SelectedLookup).HasColumnName("selectedLookup");
            entity.Property(e => e.Voucher).HasColumnName("voucher");

            entity.HasOne(d => d.SelectedLookupNavigation).WithMany(p => p.VoucherLookupLists)
                .HasForeignKey(d => d.SelectedLookup)
                .HasConstraintName("FK_VoucherLookupList_SystemConstant");

            entity.HasOne(d => d.VoucherNavigation).WithMany(p => p.VoucherLookupLists)
                .HasForeignKey(d => d.Voucher)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VoucherLookupList_Voucher");
        });

        modelBuilder.Entity<VoucherStoreMapping>(entity =>
        {
            entity.ToTable("VoucherStoreMapping", "setting");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsDefault).HasColumnName("isDefault");
            entity.Property(e => e.IsSource).HasColumnName("isSource");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Store).HasColumnName("store");
            entity.Property(e => e.VoucherDefinition).HasColumnName("voucherDefinition");

            entity.HasOne(d => d.StoreNavigation).WithMany(p => p.VoucherStoreMappings)
                .HasForeignKey(d => d.Store)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VoucherStoreMapping_ConsigneeUnit");

            entity.HasOne(d => d.VoucherDefinitionNavigation).WithMany(p => p.VoucherStoreMappings)
                .HasForeignKey(d => d.VoucherDefinition)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VoucherStoreMapping_VoucherStoreMapping");
        });

        modelBuilder.Entity<VoucherTerm>(entity =>
        {
            entity.ToTable("VoucherTerm", "transaction");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Term).HasColumnName("term");
            entity.Property(e => e.Value)
                .HasMaxLength(50)
                .HasColumnName("value");
            entity.Property(e => e.Voucher).HasColumnName("voucher");

            entity.HasOne(d => d.TermNavigation).WithMany(p => p.VoucherTerms)
                .HasForeignKey(d => d.Term)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VoucherTerm_TermDefinition");

            entity.HasOne(d => d.VoucherNavigation).WithMany(p => p.VoucherTerms)
                .HasForeignKey(d => d.Voucher)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VoucherTerm_Voucher");
        });

        modelBuilder.Entity<WriteUp>(entity =>
        {
            entity.ToTable("WriteUp", "questionnaire");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Question).HasColumnName("question");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");

            entity.HasOne(d => d.QuestionNavigation).WithMany(p => p.WriteUps)
                .HasForeignKey(d => d.Question)
                .HasConstraintName("FK_WriteUp_Question");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
