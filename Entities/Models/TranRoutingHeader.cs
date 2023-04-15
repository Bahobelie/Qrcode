using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("TranRoutingHeader", Schema = "PMS")]
public partial class TranRoutingHeader
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string component { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(26)]
    public string type { get; set; } = null!;

    [Column(TypeName = "date")]
    public DateTime startDate { get; set; }

    [Column(TypeName = "date")]
    public DateTime endDate { get; set; }

    [StringLength(50)]
    public string? remark { get; set; }

    [InverseProperty("tranRoutingHeaderNavigation")]
    public virtual ICollection<TranRoutingDetail> TranRoutingDetails { get; } = new List<TranRoutingDetail>();

    [ForeignKey("component")]
    [InverseProperty("TranRoutingHeaders")]
    public virtual CNETComponent componentNavigation { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("TranRoutingHeaders")]
    public virtual RegistrationExtension referenceNavigation { get; set; } = null!;

    [ForeignKey("type")]
    [InverseProperty("TranRoutingHeaders")]
    public virtual Lookup typeNavigation { get; set; } = null!;
}
