using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("ArticleModifier", Schema = "pos")]
public partial class ArticleModifier
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? article { get; set; }

    [StringLength(50)]
    public string description { get; set; } = null!;

    public bool? isCookingInstruction { get; set; }

    [StringLength(50)]
    public string? remark { get; set; }

    [InverseProperty("articleModfierNavigation")]
    public virtual ICollection<LineItemModfier> LineItemModfiers { get; } = new List<LineItemModfier>();
}
