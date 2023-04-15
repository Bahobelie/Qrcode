using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_bankAccountDetail
{
    [StringLength(26)]
    public string employee { get; set; } = null!;

    [StringLength(50)]
    public string? description { get; set; }

    [StringLength(26)]
    public string bankCode { get; set; } = null!;

    public string bankName { get; set; } = null!;

    [StringLength(26)]
    public string branchCode { get; set; } = null!;

    [StringLength(50)]
    public string branchName { get; set; } = null!;

    [StringLength(50)]
    public string accountType { get; set; } = null!;

    [StringLength(40)]
    public string accountNo { get; set; } = null!;
}
