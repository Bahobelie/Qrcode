using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_OtherConsigneeView
{
    [StringLength(26)]
    public string RequiredGSLCode { get; set; } = null!;

    [StringLength(50)]
    public string RequiredGSLDescription { get; set; } = null!;

    [StringLength(26)]
    public string ConsigneeCode { get; set; } = null!;

    public string? ConsigneeName { get; set; }

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [StringLength(26)]
    public string code { get; set; } = null!;
}
