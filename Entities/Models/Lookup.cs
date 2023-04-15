using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Lookup", Schema = "common")]
[Index("code", Name = "IX_Lookup", IsUnique = true)]
public partial class Lookup
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int index { get; set; }

    [StringLength(50)]
    public string component { get; set; } = null!;

    [StringLength(75)]
    public string type { get; set; } = null!;

    public string description { get; set; } = null!;

    [StringLength(40)]
    public string? value { get; set; }

    public bool isDefault { get; set; }

    public bool isActive { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("categoryNavigation")]
    public virtual ICollection<CNETMedium> CNETMediumcategoryNavigations { get; } = new List<CNETMedium>();

    [InverseProperty("typeNavigation")]
    public virtual ICollection<CNETMedium> CNETMediumtypeNavigations { get; } = new List<CNETMedium>();

    [InverseProperty("PrivacyRuleNavigation")]
    public virtual ICollection<CNETPrivacy> CNETPrivacies { get; } = new List<CNETPrivacy>();

    [InverseProperty("causeNavigation")]
    public virtual ICollection<CaseDetail> CaseDetailcauseNavigations { get; } = new List<CaseDetail>();

    [InverseProperty("issueNavigation")]
    public virtual ICollection<CaseDetail> CaseDetailissueNavigations { get; } = new List<CaseDetail>();

    [InverseProperty("resultNavigation")]
    public virtual ICollection<CaseDetail> CaseDetailresultNavigations { get; } = new List<CaseDetail>();

    [InverseProperty("solutionNavigation")]
    public virtual ICollection<CaseDetail> CaseDetailsolutionNavigations { get; } = new List<CaseDetail>();

    [InverseProperty("connectionTypeNavigation")]
    public virtual ICollection<Device> Devices { get; } = new List<Device>();

    [InverseProperty("typeNavigation")]
    public virtual ICollection<Distribution> Distributions { get; } = new List<Distribution>();

    [InverseProperty("effortTypeNavigation")]
    public virtual ICollection<EffortConsumption> EffortConsumptions { get; } = new List<EffortConsumption>();

    [InverseProperty("functionalityNavigation")]
    public virtual ICollection<EscalationDetail> EscalationDetailfunctionalityNavigations { get; } = new List<EscalationDetail>();

    [InverseProperty("priorityNavigation")]
    public virtual ICollection<EscalationDetail> EscalationDetailpriorityNavigations { get; } = new List<EscalationDetail>();

    [InverseProperty("typeNavigation")]
    public virtual ICollection<FieldFormat> FieldFormats { get; } = new List<FieldFormat>();

    [InverseProperty("TypeNavigation")]
    public virtual ICollection<GSLUser> GSLUsers { get; } = new List<GSLUser>();

    [InverseProperty("typeNavigation")]
    public virtual ICollection<HolidayDefinition> HolidayDefinitions { get; } = new List<HolidayDefinition>();

    [InverseProperty("typeNavigation")]
    public virtual ICollection<Identification> Identifications { get; } = new List<Identification>();

    [InverseProperty("industyNavigation")]
    public virtual ICollection<IndustryInvolved> IndustryInvolvedindustyNavigations { get; } = new List<IndustryInvolved>();

    [InverseProperty("involvmentNavigation")]
    public virtual ICollection<IndustryInvolved> IndustryInvolvedinvolvmentNavigations { get; } = new List<IndustryInvolved>();

    [InverseProperty("typeNavigation")]
    public virtual ICollection<Language> Languages { get; } = new List<Language>();

    [InverseProperty("factorNavigation")]
    public virtual ICollection<Lifetime> Lifetimes { get; } = new List<Lifetime>();

    [InverseProperty("UOMNavigation")]
    public virtual ICollection<LineItem> LineItems { get; } = new List<LineItem>();

    [InverseProperty("typeNavigation")]
    public virtual ICollection<Location> Locations { get; } = new List<Location>();

    [InverseProperty("paymentMethodNavigation")]
    public virtual ICollection<NonCashTransaction> NonCashTransactions { get; } = new List<NonCashTransaction>();

    [InverseProperty("typeNavigation")]
    public virtual ICollection<OrganizationUnitDefinition> OrganizationUnitDefinitions { get; } = new List<OrganizationUnitDefinition>();

    [InverseProperty("calculationRuleNavigation")]
    public virtual ICollection<PackageHeader> PackageHeadercalculationRuleNavigations { get; } = new List<PackageHeader>();

    [InverseProperty("pakgGroupNavigation")]
    public virtual ICollection<PackageHeader> PackageHeaderpakgGroupNavigations { get; } = new List<PackageHeader>();

    [InverseProperty("postingRhythmNavigation")]
    public virtual ICollection<PackageHeader> PackageHeaderpostingRhythmNavigations { get; } = new List<PackageHeader>();

    [InverseProperty("rateApearanceNavigation")]
    public virtual ICollection<PackageHeader> PackageHeaderrateApearanceNavigations { get; } = new List<PackageHeader>();

    [InverseProperty("typeNavigation")]
    public virtual ICollection<PackageHeader> PackageHeadertypeNavigations { get; } = new List<PackageHeader>();

    [InverseProperty("typeNavigation")]
    public virtual ICollection<Period> Periods { get; } = new List<Period>();

    [InverseProperty("ratingNavigation")]
    public virtual ICollection<Plan> PlanratingNavigations { get; } = new List<Plan>();

    [InverseProperty("typeNavigation")]
    public virtual ICollection<Plan> PlantypeNavigations { get; } = new List<Plan>();

    [InverseProperty("alertTypeNavigation")]
    public virtual ICollection<ProcessTaskMap> ProcessTaskMaps { get; } = new List<ProcessTaskMap>();

    [InverseProperty("categoryNavigation")]
    public virtual ICollection<Process> ProcesscategoryNavigations { get; } = new List<Process>();

    [InverseProperty("typeNavigation")]
    public virtual ICollection<Process> ProcesstypeNavigations { get; } = new List<Process>();

    [InverseProperty("componentNavigation")]
    public virtual ICollection<RateComponent> RateComponents { get; } = new List<RateComponent>();

    [InverseProperty("comparisionNavigation")]
    public virtual ICollection<ReconciliationSummary> ReconciliationSummarycomparisionNavigations { get; } = new List<ReconciliationSummary>();

    [InverseProperty("comparisionTypeNavigation")]
    public virtual ICollection<ReconciliationSummary> ReconciliationSummarycomparisionTypeNavigations { get; } = new List<ReconciliationSummary>();

    [InverseProperty("RegionNavigation")]
    public virtual ICollection<RegionalDetail> RegionalDetails { get; } = new List<RegionalDetail>();

    [InverseProperty("SpecialsNavigation")]
    public virtual ICollection<RegistrationExtension> RegistrationExtensionSpecialsNavigations { get; } = new List<RegistrationExtension>();

    [InverseProperty("paymentTypeNavigation")]
    public virtual ICollection<RegistrationExtension> RegistrationExtensionpaymentTypeNavigations { get; } = new List<RegistrationExtension>();

    [InverseProperty("resTypeNavigation")]
    public virtual ICollection<RegistrationExtension> RegistrationExtensionresTypeNavigations { get; } = new List<RegistrationExtension>();

    [InverseProperty("controlTypeNavigation")]
    public virtual ICollection<ReportCriterion> ReportCriteria { get; } = new List<ReportCriterion>();

    [InverseProperty("typeNavigation")]
    public virtual ICollection<RequriedGSL> RequriedGSLs { get; } = new List<RequriedGSL>();

    [InverseProperty("roomClassNavigation")]
    public virtual ICollection<RoomType> RoomTypes { get; } = new List<RoomType>();

    [InverseProperty("cateogryNavigation")]
    public virtual ICollection<ScheduleHeader> ScheduleHeadercateogryNavigations { get; } = new List<ScheduleHeader>();

    [InverseProperty("typeNavigation")]
    public virtual ICollection<ScheduleHeader> ScheduleHeadertypeNavigations { get; } = new List<ScheduleHeader>();

    [InverseProperty("baudRateNavigation")]
    public virtual ICollection<SerialParameter> SerialParameterbaudRateNavigations { get; } = new List<SerialParameter>();

    [InverseProperty("parityNavigation")]
    public virtual ICollection<SerialParameter> SerialParameterparityNavigations { get; } = new List<SerialParameter>();

    [InverseProperty("spaceArrangmentNavigation")]
    public virtual ICollection<SpaceCapacity> SpaceCapacities { get; } = new List<SpaceCapacity>();

    [InverseProperty("CatagoryNavigation")]
    public virtual ICollection<Space> SpaceCatagoryNavigations { get; } = new List<Space>();

    [InverseProperty("directionNavigation")]
    public virtual ICollection<SpaceDirection> SpaceDirections { get; } = new List<SpaceDirection>();

    [InverseProperty("TypeNavigation")]
    public virtual ICollection<Space> SpaceTypeNavigations { get; } = new List<Space>();

    [InverseProperty("categoryNavigation")]
    public virtual ICollection<Specification> SpecificationcategoryNavigations { get; } = new List<Specification>();

    [InverseProperty("typeNavigation")]
    public virtual ICollection<Specification> SpecificationtypeNavigations { get; } = new List<Specification>();

    [InverseProperty("typeNavigation")]
    public virtual ICollection<Subcountry> Subcountries { get; } = new List<Subcountry>();

    [InverseProperty("categoryNavigation")]
    public virtual ICollection<Tax> Taxes { get; } = new List<Tax>();

    [InverseProperty("categoryNavigation")]
    public virtual ICollection<TermList> TermLists { get; } = new List<TermList>();

    [InverseProperty("typeNavigation")]
    public virtual ICollection<TranRoutingHeader> TranRoutingHeaders { get; } = new List<TranRoutingHeader>();

    [InverseProperty("typeNavigation")]
    public virtual ICollection<TransactionLimit> TransactionLimits { get; } = new List<TransactionLimit>();

    [InverseProperty("typeNavigation")]
    public virtual ICollection<VoucherExtension> VoucherExtensions { get; } = new List<VoucherExtension>();

    [InverseProperty("typeNavigation")]
    public virtual ICollection<Voucher> Vouchers { get; } = new List<Voucher>();
}
