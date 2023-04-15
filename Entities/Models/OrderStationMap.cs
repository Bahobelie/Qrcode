using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("OrderStationMap", Schema = "pos")]
public partial class OrderStationMap
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string posDevice { get; set; } = null!;

    [StringLength(26)]
    public string preference { get; set; } = null!;

    [StringLength(26)]
    public string stationDevice { get; set; } = null!;

    [StringLength(50)]
    public string? remark { get; set; }

    [ForeignKey("posDevice")]
    [InverseProperty("OrderStationMapposDeviceNavigations")]
    public virtual Device posDeviceNavigation { get; set; } = null!;

    [ForeignKey("preference")]
    [InverseProperty("OrderStationMaps")]
    public virtual Preference preferenceNavigation { get; set; } = null!;

    [ForeignKey("stationDevice")]
    [InverseProperty("OrderStationMapstationDeviceNavigations")]
    public virtual Device stationDeviceNavigation { get; set; } = null!;
}
