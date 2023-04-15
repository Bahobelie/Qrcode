using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_AllArticleOptionalCode
{
    [StringLength(26)]
    public string articleCode { get; set; } = null!;

    public string? optionCodesValue { get; set; }
}
