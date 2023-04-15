using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Person", Schema = "common")]
[Index("type", Name = "GSL_Type_Index")]
[Index("code", Name = "IX_Person", IsUnique = true)]
public partial class Person
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int type { get; set; }

    public string firstName { get; set; } = null!;

    [StringLength(20)]
    public string? middleName { get; set; }

    [StringLength(20)]
    public string? lastName { get; set; }

    [StringLength(26)]
    public string? nationality { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DOB { get; set; }

    [StringLength(26)]
    public string? title { get; set; }

    [StringLength(50)]
    public string? maritalStatus { get; set; }

    [StringLength(26)]
    public string gender { get; set; } = null!;

    [StringLength(26)]
    public string? religion { get; set; }

    [StringLength(26)]
    public string? preference { get; set; }

    public bool isActive { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("reference2")]
    public virtual ICollection<AccountMap> AccountMaps { get; } = new List<AccountMap>();

    [InverseProperty("reference2")]
    public virtual ICollection<Activity> Activities { get; } = new List<Activity>();

    [InverseProperty("reference1")]
    public virtual ICollection<Address> Addresses { get; } = new List<Address>();

    [InverseProperty("reference4")]
    public virtual ICollection<Attachment> Attachments { get; } = new List<Attachment>();

    [InverseProperty("identificationNavigation")]
    public virtual ICollection<AttendanceLog> AttendanceLogs { get; } = new List<AttendanceLog>();

    [InverseProperty("reference1")]
    public virtual ICollection<BankAccountDetail> BankAccountDetails { get; } = new List<BankAccountDetail>();

    [InverseProperty("reference2")]
    public virtual ICollection<Beginning> Beginnings { get; } = new List<Beginning>();

    [InverseProperty("reference1")]
    public virtual ICollection<CNETPrivacy> CNETPrivacies { get; } = new List<CNETPrivacy>();

    [InverseProperty("reference2")]
    public virtual ICollection<CNET_GP> CNET_GPs { get; } = new List<CNET_GP>();

    [InverseProperty("reference3")]
    public virtual ICollection<CommunicationSource> CommunicationSources { get; } = new List<CommunicationSource>();

    [InverseProperty("Reference2")]
    public virtual ICollection<CurrencyPreference> CurrencyPreferences { get; } = new List<CurrencyPreference>();

    [InverseProperty("assignedToNavigation")]
    public virtual ICollection<EscalationDetail> EscalationDetails { get; } = new List<EscalationDetail>();

    [InverseProperty("reference2")]
    public virtual ICollection<GSLTax> GSLTaxes { get; } = new List<GSLTax>();

    [InverseProperty("reference2")]
    public virtual ICollection<IdSetting> IdSettings { get; } = new List<IdSetting>();

    [InverseProperty("reference3")]
    public virtual ICollection<Identification> Identifications { get; } = new List<Identification>();

    [InverseProperty("reference2")]
    public virtual ICollection<IndustryInvolved> IndustryInvolveds { get; } = new List<IndustryInvolved>();

    [InverseProperty("referenceNavigation")]
    public virtual ICollection<IssuedCared> IssuedCareds { get; } = new List<IssuedCared>();

    [InverseProperty("personNavigation")]
    public virtual ICollection<LanguageOfInterest> LanguageOfInterests { get; } = new List<LanguageOfInterest>();

    [InverseProperty("reference2")]
    public virtual ICollection<Lifetime> Lifetimes { get; } = new List<Lifetime>();

    [InverseProperty("consignee1")]
    public virtual ICollection<NegotiatedRate> NegotiatedRates { get; } = new List<NegotiatedRate>();

    [InverseProperty("consignee2")]
    public virtual ICollection<NonCashTransaction> NonCashTransactions { get; } = new List<NonCashTransaction>();

    [InverseProperty("reference2")]
    public virtual ICollection<ObjectState> ObjectStates { get; } = new List<ObjectState>();

    [InverseProperty("article2")]
    public virtual ICollection<OptionalCode> OptionalCodes { get; } = new List<OptionalCode>();

    [InverseProperty("consignee1")]
    public virtual ICollection<OtherConsignee> OtherConsignees { get; } = new List<OtherConsignee>();

    [InverseProperty("referenceObject2")]
    public virtual ICollection<Relation> Relations { get; } = new List<Relation>();

    [InverseProperty("guest1")]
    public virtual ICollection<ResidentSummary> ResidentSummaries { get; } = new List<ResidentSummary>();

    [InverseProperty("reference2")]
    public virtual ICollection<TransactionLimit> TransactionLimits { get; } = new List<TransactionLimit>();

    [InverseProperty("reference2")]
    public virtual ICollection<Translation> Translations { get; } = new List<Translation>();

    [InverseProperty("personNavigation")]
    public virtual ICollection<User> Users { get; } = new List<User>();

    [InverseProperty("reference2")]
    public virtual ICollection<ValueFactor> ValueFactors { get; } = new List<ValueFactor>();

    [InverseProperty("consignee1")]
    public virtual ICollection<Voucher> Vouchers { get; } = new List<Voucher>();

    [ForeignKey("preference")]
    [InverseProperty("People")]
    public virtual Preference? preferenceNavigation { get; set; }

    [ForeignKey("type")]
    [InverseProperty("People")]
    public virtual GSLTypeList typeNavigation { get; set; } = null!;
}
