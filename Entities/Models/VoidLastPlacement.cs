using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class VoidLastPlacement
{
    [StringLength(26)]
    public string? consignee { get; set; }

    [StringLength(26)]
    public string type { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    [StringLength(20)]
    public string firstName { get; set; } = null!;

    [StringLength(20)]
    public string? middleName { get; set; }

    [StringLength(20)]
    public string? lastName { get; set; }

    [StringLength(62)]
    public string? fullName { get; set; }

    [StringLength(26)]
    public string branchCode { get; set; } = null!;

    [StringLength(50)]
    public string branchDescription { get; set; } = null!;

    [StringLength(26)]
    public string deptCode { get; set; } = null!;

    [StringLength(50)]
    public string department { get; set; } = null!;
}
