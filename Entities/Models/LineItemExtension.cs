using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("LineItemExtension", Schema = "common")]
public partial class LineItemExtension
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(50)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string lineitem { get; set; } = null!;

    [StringLength(26)]
    public string voucherExtension { get; set; } = null!;

    public string number { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("lineitem")]
    [InverseProperty("LineItemExtensions")]
    public virtual LineItem lineitemNavigation { get; set; } = null!;

    [ForeignKey("voucherExtension")]
    [InverseProperty("LineItemExtensions")]
    public virtual VoucherExtension voucherExtensionNavigation { get; set; } = null!;
}
