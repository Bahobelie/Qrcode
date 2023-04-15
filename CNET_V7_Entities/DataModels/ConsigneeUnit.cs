using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class ConsigneeUnit
{
    public int Id { get; set; }

    public int Code { get; set; }

    public int? Consignee { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int? Type { get; set; }

    public int? IndustryInvolved { get; set; }

    public int? Purpose { get; set; }

    public int? Preference { get; set; }

    public string? Abrivation { get; set; }

    public double? Longitude { get; set; }

    public double? Latitude { get; set; }

    public string? Contact { get; set; }

    public string? Phone1 { get; set; }

    public string? Phone2 { get; set; }

    public string? Email { get; set; }

    public string? Website { get; set; }

    public string? SpecificAddress { get; set; }

    public string? Street { get; set; }

    public string? HouseNumber { get; set; }

    public string? PoBox { get; set; }

    public string? Kebele { get; set; }

    public string? Wereda { get; set; }

    public int? Subcity { get; set; }

    public int? City { get; set; }

    public int? Region { get; set; }

    public int? Country { get; set; }

    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? AddressLine3 { get; set; }

    public int? ParentId { get; set; }

    public byte[]? CreatedOn { get; set; }

    public DateTime? LastModified { get; set; }

    public bool? IsActive { get; set; }

    public bool? Locked { get; set; }

    public bool? IsOnline { get; set; }

    public string? DefaultImageUrl { get; set; }

    public string? Remark { get; set; }

    public virtual ICollection<AccessMatrix> AccessMatrices { get; } = new List<AccessMatrix>();

    public virtual ICollection<ArticleUser> ArticleUsers { get; } = new List<ArticleUser>();

    public virtual ICollection<BankAccountDetail> BankAccountDetails { get; } = new List<BankAccountDetail>();

    public virtual ICollection<CloudSync> CloudSyncs { get; } = new List<CloudSync>();

    public virtual Consignee? ConsigneeNavigation { get; set; }

    public virtual ICollection<ConsigneeUser> ConsigneeUsers { get; } = new List<ConsigneeUser>();

    public virtual ICollection<Consignee> Consignees { get; } = new List<Consignee>();

    public virtual Country? CountryNavigation { get; set; }

    public virtual ICollection<Distribution> Distributions { get; } = new List<Distribution>();

    public virtual ICollection<Gsluser> Gslusers { get; } = new List<Gsluser>();

    public virtual ICollection<Idsetting> Idsettings { get; } = new List<Idsetting>();

    public virtual SystemConstant? IndustryInvolvedNavigation { get; set; }

    public virtual ICollection<ConsigneeUnit> InverseParent { get; } = new List<ConsigneeUnit>();

    public virtual ICollection<MovieSchedule> MovieSchedules { get; } = new List<MovieSchedule>();

    public virtual ConsigneeUnit? Parent { get; set; }

    public virtual Preference? PreferenceNavigation { get; set; }

    public virtual ICollection<RoleActivity> RoleActivities { get; } = new List<RoleActivity>();

    public virtual ICollection<RouteAssignment> RouteAssignments { get; } = new List<RouteAssignment>();

    public virtual ICollection<Space> Spaces { get; } = new List<Space>();

    public virtual ICollection<StockBalance> StockBalances { get; } = new List<StockBalance>();

    public virtual ICollection<StockLevel> StockLevels { get; } = new List<StockLevel>();

    public virtual SystemConstant? TypeNavigation { get; set; }

    public virtual ICollection<UserRoleMapper> UserRoleMappers { get; } = new List<UserRoleMapper>();

    public virtual ICollection<Value> Values { get; } = new List<Value>();

    public virtual ICollection<Voucher> VoucherConsignee31s { get; } = new List<Voucher>();

    public virtual ICollection<Voucher> VoucherConsignee41s { get; } = new List<Voucher>();

    public virtual ICollection<Voucher> VoucherConsignee61s { get; } = new List<Voucher>();

    public virtual ICollection<Voucher> VoucherConsigneeUnit1Navigations { get; } = new List<Voucher>();

    public virtual ICollection<Voucher> VoucherConsigneeUnit2Navigations { get; } = new List<Voucher>();

    public virtual ICollection<Voucher> VoucherConsigneeUnit5Navigations { get; } = new List<Voucher>();

    public virtual ICollection<Voucher> VoucherDestinationConsigneeUnitNavigations { get; } = new List<Voucher>();

    public virtual ICollection<Voucher> VoucherDestinationStoreNavigations { get; } = new List<Voucher>();

    public virtual ICollection<Voucher> VoucherOriginConsigneeUnitNavigations { get; } = new List<Voucher>();

    public virtual ICollection<Voucher> VoucherSourceStoreNavigations { get; } = new List<Voucher>();

    public virtual ICollection<VoucherStoreMapping> VoucherStoreMappings { get; } = new List<VoucherStoreMapping>();
}
