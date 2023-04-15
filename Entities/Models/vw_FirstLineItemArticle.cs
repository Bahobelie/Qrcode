using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_FirstLineItemArticle
{
    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(26)]
    public string firstLineitemCode { get; set; } = null!;

    [StringLength(26)]
    public string firstArticleCode { get; set; } = null!;

    public string firstArticleName { get; set; } = null!;
}
