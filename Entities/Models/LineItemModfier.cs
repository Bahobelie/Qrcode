using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("LineItemModfier", Schema = "common")]
public partial class LineItemModfier
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string Code { get; set; } = null!;

    [StringLength(26)]
    public string LineItem { get; set; } = null!;

    [StringLength(26)]
    public string articleModfier { get; set; } = null!;

    [StringLength(100)]
    public string? Remark { get; set; }

    [ForeignKey("LineItem")]
    [InverseProperty("LineItemModfiers")]
    public virtual LineItem LineItemNavigation { get; set; } = null!;

    [ForeignKey("articleModfier")]
    [InverseProperty("LineItemModfiers")]
    public virtual ArticleModifier articleModfierNavigation { get; set; } = null!;
}
