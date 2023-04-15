using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_journalDetailLineItemView
{
    [StringLength(26)]
    public string account { get; set; } = null!;

    [StringLength(26)]
    public string journalDetailCode { get; set; } = null!;

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(26)]
    public string referenced { get; set; } = null!;

    [StringLength(26)]
    public string article { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [StringLength(26)]
    public string controlAccount { get; set; } = null!;
}
