using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.SecuritySchema;
public partial class UserDTO{
    public int Id { get; set; }
    public int? Person { get; set; }
    public string UserName { get; set; } = null!;
    public string Password { get; set; } = null!;
    public int? LoggedInStatus { get; set; }
    public bool? IsActive { get; set; }
    public string? Remark { get; set; }
}
