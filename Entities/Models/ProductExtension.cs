using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("ProductExtension", Schema = "common")]
[Index("code", Name = "IX_ProductExtension", IsUnique = true)]
public partial class ProductExtension
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string article { get; set; } = null!;

    [StringLength(100)]
    public string? brand { get; set; }

    [StringLength(100)]
    public string? generic { get; set; }

    [StringLength(100)]
    public string model { get; set; } = null!;

    [StringLength(25)]
    public string? size { get; set; }

    [StringLength(50)]
    public string? color { get; set; }

    [StringLength(26)]
    public string? country { get; set; }

    [StringLength(100)]
    public string? manufacturer { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("article")]
    [InverseProperty("ProductExtensions")]
    public virtual Article articleNavigation { get; set; } = null!;
}
