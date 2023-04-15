using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class Device
{
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

    public virtual ICollection<AcLog> AcLogs { get; } = new List<AcLog>();

    public virtual ICollection<Activity> Activities { get; } = new List<Activity>();

    public virtual Article? ArticleNavigation { get; set; }

    public virtual ICollection<AttendanceLog> AttendanceLogs { get; } = new List<AttendanceLog>();

    public virtual ICollection<Cnetlicense> Cnetlicenses { get; } = new List<Cnetlicense>();

    public virtual SystemConstant? ConnectionTypeNavigation { get; set; }

    public virtual ICollection<Idsetting> Idsettings { get; } = new List<Idsetting>();

    public virtual ICollection<OrderStationMap> OrderStationMapPosDeviceNavigations { get; } = new List<OrderStationMap>();

    public virtual ICollection<OrderStationMap> OrderStationMapStationDeviceNavigations { get; } = new List<OrderStationMap>();

    public virtual ICollection<PreferenceAccess> PreferenceAccesses { get; } = new List<PreferenceAccess>();

    public virtual ICollection<SpaceDirection> SpaceDirections { get; } = new List<SpaceDirection>();

    public virtual ICollection<Voucher> Vouchers { get; } = new List<Voucher>();
}
