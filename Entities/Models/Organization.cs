using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Organization", Schema = "common")]
[Index("type", Name = "Gsl_Type_Index")]
[Index("code", Name = "IX_Organization", IsUnique = true)]
public partial class Organization
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    public string tradeName { get; set; } = null!;

    public string? brandName { get; set; }

    [StringLength(26)]
    public string? businessType { get; set; }

    public int type { get; set; }

    [StringLength(26)]
    public string? preference { get; set; }

    public bool isActive { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("reference1")]
    public virtual ICollection<AccountMap> AccountMaps { get; } = new List<AccountMap>();

    [InverseProperty("reference1")]
    public virtual ICollection<Activity> Activities { get; } = new List<Activity>();

    [InverseProperty("referenceNavigation")]
    public virtual ICollection<Address> Addresses { get; } = new List<Address>();

    [InverseProperty("reference3")]
    public virtual ICollection<Attachment> Attachments { get; } = new List<Attachment>();

    [InverseProperty("referenceNavigation")]
    public virtual ICollection<BankAccountDetail> BankAccountDetails { get; } = new List<BankAccountDetail>();

    [InverseProperty("reference1")]
    public virtual ICollection<Beginning> Beginnings { get; } = new List<Beginning>();

    [InverseProperty("referenceNavigation")]
    public virtual ICollection<CNETPrivacy> CNETPrivacies { get; } = new List<CNETPrivacy>();

    [InverseProperty("reference2")]
    public virtual ICollection<CommunicationSource> CommunicationSources { get; } = new List<CommunicationSource>();

    [InverseProperty("Reference1")]
    public virtual ICollection<CurrencyPreference> CurrencyPreferences { get; } = new List<CurrencyPreference>();

    [InverseProperty("reference1")]
    public virtual ICollection<GSLTax> GSLTaxes { get; } = new List<GSLTax>();

    [InverseProperty("reference1")]
    public virtual ICollection<IdSetting> IdSettings { get; } = new List<IdSetting>();

    [InverseProperty("reference2")]
    public virtual ICollection<Identification> Identifications { get; } = new List<Identification>();

    [InverseProperty("reference1")]
    public virtual ICollection<IndustryInvolved> IndustryInvolveds { get; } = new List<IndustryInvolved>();

    [InverseProperty("componentNavigation")]
    public virtual ICollection<IssuedCared> IssuedCareds { get; } = new List<IssuedCared>();

    [InverseProperty("reference1")]
    public virtual ICollection<Lifetime> Lifetimes { get; } = new List<Lifetime>();

    [InverseProperty("consigneeNavigation")]
    public virtual ICollection<NegotiatedRate> NegotiatedRates { get; } = new List<NegotiatedRate>();

    [InverseProperty("consigneeNavigation")]
    public virtual ICollection<NonCashTransaction> NonCashTransactionconsigneeNavigations { get; } = new List<NonCashTransaction>();

    [InverseProperty("paymentProcesserNavigation")]
    public virtual ICollection<NonCashTransaction> NonCashTransactionpaymentProcesserNavigations { get; } = new List<NonCashTransaction>();

    [InverseProperty("reference1")]
    public virtual ICollection<ObjectState> ObjectStates { get; } = new List<ObjectState>();

    [InverseProperty("article1")]
    public virtual ICollection<OptionalCode> OptionalCodes { get; } = new List<OptionalCode>();

    [InverseProperty("referenceNavigation")]
    public virtual ICollection<OrganizationUnit> OrganizationUnits { get; } = new List<OrganizationUnit>();

    [InverseProperty("consigneeNavigation")]
    public virtual ICollection<OtherConsignee> OtherConsignees { get; } = new List<OtherConsignee>();

    [InverseProperty("referenceObject1")]
    public virtual ICollection<Relation> Relations { get; } = new List<Relation>();

    [InverseProperty("reference1")]
    public virtual ICollection<TransactionLimit> TransactionLimits { get; } = new List<TransactionLimit>();

    [InverseProperty("reference1")]
    public virtual ICollection<Translation> Translations { get; } = new List<Translation>();

    [InverseProperty("reference1")]
    public virtual ICollection<ValueFactor> ValueFactors { get; } = new List<ValueFactor>();

    [InverseProperty("consigneeNavigation")]
    public virtual ICollection<Voucher> Vouchers { get; } = new List<Voucher>();

    [ForeignKey("preference")]
    [InverseProperty("Organizations")]
    public virtual Preference? preferenceNavigation { get; set; }

    [ForeignKey("type")]
    [InverseProperty("Organizations")]
    public virtual GSLTypeList typeNavigation { get; set; } = null!;
}
