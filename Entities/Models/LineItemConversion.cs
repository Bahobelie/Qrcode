using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("LineItemConversion", Schema = "common")]
public partial class LineItemConversion
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string lineItem { get; set; } = null!;

    [StringLength(26)]
    public string uom { get; set; } = null!;

    public double quantity { get; set; }

    public double unitAmount { get; set; }

    public string? remark { get; set; }

    [ForeignKey("lineItem")]
    [InverseProperty("LineItemConversions")]
    public virtual LineItem lineItemNavigation { get; set; } = null!;
}
