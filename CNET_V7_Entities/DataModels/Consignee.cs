using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class Consignee
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public int GslType { get; set; }

    public string? IdNumber { get; set; }

    public string? Tin { get; set; }

    public int? Title { get; set; }

    public string? FirstName { get; set; }

    public string? SecondName { get; set; }

    public string? ThirdName { get; set; }

    public int? Gender { get; set; }

    public int? BusinessType { get; set; }

    public int? Preference { get; set; }

    public DateTime? StartDate { get; set; }

    public int? Nationality { get; set; }

    public bool? IsActive { get; set; }

    public int? MaritalStatus { get; set; }

    public string? Note { get; set; }

    public byte[]? CreatedOn { get; set; }

    public DateTime? LastModified { get; set; }

    public int? MainConsigneeUnit { get; set; }

    public int? ParentId { get; set; }

    public int? ComminicationSource { get; set; }

    public int? DefaultLanguage { get; set; }

    public int? DefaultCurrency { get; set; }

    public string? DefaultImageUrl { get; set; }

    public bool? Locked { get; set; }

    public string? Remark { get; set; }

    public virtual ICollection<BankAccountDetail> BankAccountDetails { get; } = new List<BankAccountDetail>();

    public virtual SystemConstant? BusinessTypeNavigation { get; set; }

    public virtual ICollection<ConsigneeUnit> ConsigneeUnits { get; } = new List<ConsigneeUnit>();

    public virtual ICollection<ConsigneeUser> ConsigneeUserExternalConsigneeNavigations { get; } = new List<ConsigneeUser>();

    public virtual ICollection<ConsigneeUser> ConsigneeUserOwnConsigneeNavigations { get; } = new List<ConsigneeUser>();

    public virtual Currency? DefaultCurrencyNavigation { get; set; }

    public virtual Language? DefaultLanguageNavigation { get; set; }

    public virtual SystemConstant? GenderNavigation { get; set; }

    public virtual SystemConstant GslTypeNavigation { get; set; } = null!;

    public virtual ICollection<Identification> Identifications { get; } = new List<Identification>();

    public virtual ICollection<Consignee> InverseParent { get; } = new List<Consignee>();

    public virtual ICollection<IssuedCard> IssuedCards { get; } = new List<IssuedCard>();

    public virtual ICollection<LanguagePreference> LanguagePreferences { get; } = new List<LanguagePreference>();

    public virtual ConsigneeUnit? MainConsigneeUnitNavigation { get; set; }

    public virtual SystemConstant? MaritalStatusNavigation { get; set; }

    public virtual Country? NationalityNavigation { get; set; }

    public virtual ICollection<NonCashTransaction> NonCashTransactions { get; } = new List<NonCashTransaction>();

    public virtual Consignee? Parent { get; set; }

    public virtual Preference? PreferenceNavigation { get; set; }

    public virtual SystemConstant? TitleNavigation { get; set; }

    public virtual ICollection<TransactionLimit> TransactionLimits { get; } = new List<TransactionLimit>();

    public virtual ICollection<User> Users { get; } = new List<User>();

    public virtual ICollection<Voucher> VoucherConsignee1Navigations { get; } = new List<Voucher>();

    public virtual ICollection<Voucher> VoucherConsignee2Navigations { get; } = new List<Voucher>();

    public virtual ICollection<Voucher> VoucherConsignee3Navigations { get; } = new List<Voucher>();

    public virtual ICollection<Voucher> VoucherConsignee4Navigations { get; } = new List<Voucher>();

    public virtual ICollection<Voucher> VoucherConsignee5Navigations { get; } = new List<Voucher>();

    public virtual ICollection<Voucher> VoucherConsignee6Navigations { get; } = new List<Voucher>();

    public virtual ICollection<VoucherConsigneeList> VoucherConsigneeLists { get; } = new List<VoucherConsigneeList>();
}
