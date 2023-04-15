using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_JobCardView
{
    [StringLength(26)]
    public string voucherCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [StringLength(26)]
    public string? consigneeCode { get; set; }

    public string? consigneeName { get; set; }

    [StringLength(26)]
    public string articleCode { get; set; } = null!;

    public string articleName { get; set; } = null!;

    [StringLength(26)]
    public string? promissingDate { get; set; }

    [StringLength(26)]
    public string? kmIn { get; set; }

    [StringLength(26)]
    public string? preparedBycode { get; set; }

    [StringLength(30)]
    public string? preparedByName { get; set; }

    [StringLength(26)]
    public string? plateNo { get; set; }

    [StringLength(100)]
    public string? model { get; set; }

    [StringLength(100)]
    public string? brand { get; set; }
}
