using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class CloudSync
{
    public int Id { get; set; }

    public int Pointer { get; set; }

    public string Reference { get; set; } = null!;

    public int OrganizationUnitDefinition { get; set; }

    public int Status { get; set; }

    public int? TryCount { get; set; }

    public DateTime? UploadTimeStamp { get; set; }

    public DateTime? DownloadTimeStamp { get; set; }

    public string? Remark { get; set; }

    public virtual ConsigneeUnit OrganizationUnitDefinitionNavigation { get; set; } = null!;

    public virtual SystemConstant PointerNavigation { get; set; } = null!;
}
