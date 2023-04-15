using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class ArticleDetail_View
{
    public long? NID { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string DGroup { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(101)]
    public string? DKey { get; set; }

    [StringLength(50)]
    public string? DValue { get; set; }
}
