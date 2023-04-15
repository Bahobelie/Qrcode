using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("ResidentSummary", Schema = "PMS")]
public partial class ResidentSummary
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime summaryDate { get; set; }

    [StringLength(26)]
    public string registration { get; set; } = null!;

    [StringLength(26)]
    public string? guest { get; set; }

    [StringLength(26)]
    public string room { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal accommodation { get; set; }

    [Column(TypeName = "money")]
    public decimal? posCharge { get; set; }

    [Column(TypeName = "money")]
    public decimal todayTotal { get; set; }

    [Column(TypeName = "money")]
    public decimal bbf { get; set; }

    [Column(TypeName = "money")]
    public decimal toDateTotal { get; set; }

    [Column(TypeName = "money")]
    public decimal discount { get; set; }

    [StringLength(30)]
    public string? rebate { get; set; }

    [Column(TypeName = "money")]
    public decimal? payment { get; set; }

    [Column(TypeName = "money")]
    public decimal bcf { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("guest")]
    [InverseProperty("ResidentSummaries")]
    public virtual Person? guest1 { get; set; }

    [ForeignKey("guest")]
    [InverseProperty("ResidentSummaries")]
    public virtual OrganizationUnitDefinition? guestNavigation { get; set; }

    [ForeignKey("registration")]
    [InverseProperty("ResidentSummaries")]
    public virtual RegistrationExtension registrationNavigation { get; set; } = null!;

    [ForeignKey("room")]
    [InverseProperty("ResidentSummaries")]
    public virtual RoomDetail roomNavigation { get; set; } = null!;
}
