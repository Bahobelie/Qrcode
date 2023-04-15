using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.CommonSchema;
public partial class SpaceDTO{
    public int Id { get; set; }
    public int Code { get; set; }
    public int? Category { get; set; }
    public string? Description { get; set; }
    public int? Type { get; set; }
    public int? Parent { get; set; }
    public int? OrganizationalUnit { get; set; }
    public string? Remark { get; set; }
}
