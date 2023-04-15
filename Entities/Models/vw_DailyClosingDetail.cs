using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_DailyClosingDetail
{
    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    public string? comment { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    public string sessionDescription { get; set; } = null!;

    public int refVoucherDefn { get; set; }

    [StringLength(100)]
    public string? refVoucherDefnName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime startTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime endTime { get; set; }

    [StringLength(26)]
    public string? consigneeCode { get; set; }

    public string? consigneeName { get; set; }

    public string? consigneeTelephone { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    public string? WBS { get; set; }
}
