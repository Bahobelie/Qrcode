using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class User
{
    public int Id { get; set; }

    public int? Person { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int? LoggedInStatus { get; set; }

    public bool? IsActive { get; set; }

    public string? Remark { get; set; }

    public virtual ICollection<Activity> Activities { get; } = new List<Activity>();

    public virtual Consignee? PersonNavigation { get; set; }

    public virtual ICollection<UserRoleMapper> UserRoleMappers { get; } = new List<UserRoleMapper>();

    public virtual ICollection<Voucher> Vouchers { get; } = new List<Voucher>();
}
