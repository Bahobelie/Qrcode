using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("TranRoutingDetail", Schema = "PMS")]
public partial class TranRoutingDetail
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string tranRoutingHeader { get; set; } = null!;

    [StringLength(26)]
    public string article { get; set; } = null!;

    [StringLength(26)]
    public string container { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal amountLimit { get; set; }

    public bool needApproval { get; set; }

    [StringLength(50)]
    public string? remark { get; set; }

    [ForeignKey("article")]
    [InverseProperty("TranRoutingDetails")]
    public virtual Article articleNavigation { get; set; } = null!;

    [ForeignKey("tranRoutingHeader")]
    [InverseProperty("TranRoutingDetails")]
    public virtual TranRoutingHeader tranRoutingHeaderNavigation { get; set; } = null!;
}
