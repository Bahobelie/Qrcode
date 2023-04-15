using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.SettingSchema;
public partial class IddefinitionDTO{
    public int Id { get; set; }
    public int Code { get; set; }
    public int? Pointer { get; set; }
    public string? Description { get; set; }
    public string? Prefix { get; set; }
    public string? PrefixSeparator { get; set; }
    public int? Length { get; set; }
    public string? SuffixSeparator { get; set; }
    public string? Suffix { get; set; }
    public string? Remark { get; set; }
}
