using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_OtherConsigneeSecond
{
    [StringLength(26)]
    public string voucher { get; set; } = null!;

    public string? otherConsigneeTwoName { get; set; }

    [StringLength(26)]
    public string otherConsigneeTwo { get; set; } = null!;

    [StringLength(26)]
    public string otherConsigneeCode { get; set; } = null!;
}
