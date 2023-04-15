using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.CommonSchema;
public partial class CloudSyncDTO{
    public int Id { get; set; }
    public int Pointer { get; set; }
    public string Reference { get; set; } = null!;
    public int OrganizationUnitDefinition { get; set; }
    public int Status { get; set; }
    public int? TryCount { get; set; }
    public DateTime? UploadTimeStamp { get; set; }
    public DateTime? DownloadTimeStamp { get; set; }
    public string? Remark { get; set; }
}
