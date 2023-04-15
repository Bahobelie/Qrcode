using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_OtherConsigneeFirst
{
    [StringLength(26)]
    public string voucher { get; set; } = null!;

    public string? otherConsigneeOneName { get; set; }

    [StringLength(26)]
    public string otherConsigneeOne { get; set; } = null!;

    [StringLength(26)]
    public string otherConsigneeCode { get; set; } = null!;
}
