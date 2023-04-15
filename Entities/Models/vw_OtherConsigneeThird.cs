using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_OtherConsigneeThird
{
    [StringLength(26)]
    public string voucher { get; set; } = null!;

    public string? otherConsigneeThreeName { get; set; }

    [StringLength(26)]
    public string otherConsigneeThree { get; set; } = null!;

    [StringLength(26)]
    public string otherConsigneeCode { get; set; } = null!;
}
