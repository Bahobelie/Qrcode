using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("LineItemNote", Schema = "common")]
public partial class LineItemNote
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string lineItem { get; set; } = null!;

    public string note { get; set; } = null!;

    public bool overrideArticleDescription { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("lineItem")]
    [InverseProperty("LineItemNotes")]
    public virtual LineItem lineItemNavigation { get; set; } = null!;
}
