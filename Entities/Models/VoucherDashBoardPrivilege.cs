using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("VoucherDashBoardPrivilege", Schema = "common")]
public partial class VoucherDashBoardPrivilege
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string role { get; set; } = null!;

    [StringLength(26)]
    public string voucherDefinition { get; set; } = null!;

    [StringLength(100)]
    public string remark { get; set; } = null!;
}
