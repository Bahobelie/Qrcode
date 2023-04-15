using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("RateCodeDetail", Schema = "PMS")]
public partial class RateCodeDetail
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string rateCodeHeader { get; set; } = null!;

    [StringLength(150)]
    public string description { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime startDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime endDate { get; set; }

    [StringLength(26)]
    public string stayDuration { get; set; } = null!;

    [StringLength(50)]
    public string? remark { get; set; }

    [InverseProperty("rateCodeDetailNavigation")]
    public virtual ICollection<RateCodeDetailGuestCount> RateCodeDetailGuestCounts { get; } = new List<RateCodeDetailGuestCount>();

    [InverseProperty("rateCodeDetailNavigation")]
    public virtual ICollection<RateCodeDetailRoomType> RateCodeDetailRoomTypes { get; } = new List<RateCodeDetailRoomType>();

    [InverseProperty("rateCodeDetailNavigation")]
    public virtual ICollection<RegistrationDetail> RegistrationDetails { get; } = new List<RegistrationDetail>();

    [ForeignKey("rateCodeHeader")]
    [InverseProperty("RateCodeDetails")]
    public virtual RateCodeHeader rateCodeHeaderNavigation { get; set; } = null!;

    [ForeignKey("stayDuration")]
    [InverseProperty("RateCodeDetails")]
    public virtual Range stayDurationNavigation { get; set; } = null!;
}
