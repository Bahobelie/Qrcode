using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Device", Schema = "common")]
[Index("code", Name = "IX_Device", IsUnique = true)]
public partial class Device
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string article { get; set; } = null!;

    [StringLength(26)]
    public string connectionType { get; set; } = null!;

    [StringLength(26)]
    public string? host { get; set; }

    [StringLength(40)]
    public string? deviceValue { get; set; }

    [StringLength(26)]
    public string preference { get; set; } = null!;

    public bool isActive { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("acDeviceNavigation")]
    public virtual ICollection<ACLog> ACLogs { get; } = new List<ACLog>();

    [InverseProperty("reference1")]
    public virtual ICollection<AccessMatrix> AccessMatrices { get; } = new List<AccessMatrix>();

    [InverseProperty("deviceNavigation")]
    public virtual ICollection<Activity> Activities { get; } = new List<Activity>();

    [InverseProperty("reference1")]
    public virtual ICollection<Attachment> Attachments { get; } = new List<Attachment>();

    [InverseProperty("reference1")]
    public virtual ICollection<CommunicationSource> CommunicationSources { get; } = new List<CommunicationSource>();

    [InverseProperty("reference1")]
    public virtual ICollection<Configuration> Configurations { get; } = new List<Configuration>();

    [InverseProperty("DeviceNavigation")]
    public virtual ICollection<DeviceSchedule> DeviceSchedules { get; } = new List<DeviceSchedule>();

    [InverseProperty("destinationNavigation")]
    public virtual ICollection<Distribution> Distributions { get; } = new List<Distribution>();

    [InverseProperty("deviceNavigation")]
    public virtual ICollection<IPParameter> IPParameters { get; } = new List<IPParameter>();

    [InverseProperty("deviceNavigation")]
    public virtual ICollection<IdSetting> IdSettings { get; } = new List<IdSetting>();

    [InverseProperty("reference1")]
    public virtual ICollection<Identification> Identifications { get; } = new List<Identification>();

    [InverseProperty("hostNavigation")]
    public virtual ICollection<Device> InversehostNavigation { get; } = new List<Device>();

    [InverseProperty("posDeviceNavigation")]
    public virtual ICollection<OrderStationMap> OrderStationMapposDeviceNavigations { get; } = new List<OrderStationMap>();

    [InverseProperty("stationDeviceNavigation")]
    public virtual ICollection<OrderStationMap> OrderStationMapstationDeviceNavigations { get; } = new List<OrderStationMap>();

    [InverseProperty("deviceNavigation")]
    public virtual ICollection<PreferenceAccess> PreferenceAccesses { get; } = new List<PreferenceAccess>();

    [InverseProperty("deviceNavigation")]
    public virtual ICollection<SerialParameter> SerialParameters { get; } = new List<SerialParameter>();

    [InverseProperty("deviceNavigation")]
    public virtual ICollection<SpaceDirection> SpaceDirections { get; } = new List<SpaceDirection>();

    [ForeignKey("article")]
    [InverseProperty("Devices")]
    public virtual Article articleNavigation { get; set; } = null!;

    [ForeignKey("connectionType")]
    [InverseProperty("Devices")]
    public virtual Lookup connectionTypeNavigation { get; set; } = null!;

    [ForeignKey("host")]
    [InverseProperty("InversehostNavigation")]
    public virtual Device? hostNavigation { get; set; }

    [ForeignKey("preference")]
    [InverseProperty("Devices")]
    public virtual Preference preferenceNavigation { get; set; } = null!;
}
