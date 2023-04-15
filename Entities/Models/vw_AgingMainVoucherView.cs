using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_AgingMainVoucherView
{
    [StringLength(26)]
    public string mainVoucherCode { get; set; } = null!;

    public int mainVoucherDefn { get; set; }

    [StringLength(26)]
    public string? consignee { get; set; }

    [Column(TypeName = "money")]
    public decimal baseAmount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime mainIssueDate { get; set; }

    [StringLength(26)]
    public string code { get; set; } = null!;

    public string? consigeeName { get; set; }
}
