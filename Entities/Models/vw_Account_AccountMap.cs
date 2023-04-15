using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_Account_AccountMap
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string account { get; set; } = null!;

    [StringLength(26)]
    public string controlAccount { get; set; } = null!;

    [StringLength(26)]
    public string consignee { get; set; } = null!;

    [StringLength(15)]
    public string accCategory { get; set; } = null!;

    [StringLength(50)]
    public string accType { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    public bool isActive { get; set; }
}
