using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_ArticleAccountMap
{
    public string ArticleName { get; set; } = null!;

    [StringLength(26)]
    public string ArticleCode { get; set; } = null!;

    [StringLength(26)]
    public string account { get; set; } = null!;
}
