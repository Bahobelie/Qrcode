using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.SettingSchema;
public partial class DeviceDTO{
    public int Id { get; set; }
    public int? Article { get; set; }
    public string? MachineName { get; set; }
    public string? Description { get; set; }
    public int? ConnectionType { get; set; }
    public string? Host { get; set; }
    public string? DeviceValue { get; set; }
    public string? Preference { get; set; }
    public byte[]? Timestamp { get; set; }
    public string? IpAddress { get; set; }
    public string? MacAddress { get; set; }
    public int? IpPort { get; set; }
    public int? SerialPort { get; set; }
    public bool? IsEvenParity { get; set; }
    public int? BaudRate { get; set; }
    public DateTime? CreatedOn { get; set; }
    public DateTime? LastModified { get; set; }
    public bool? IsActive { get; set; }
    public string? Remark { get; set; }
}
