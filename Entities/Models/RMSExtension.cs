using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("RMSExtension", Schema = "pos")]
public partial class RMSExtension
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(26)]
    public string? waiter { get; set; }

    [StringLength(26)]
    public string? table { get; set; }

    [StringLength(26)]
    public string? cover { get; set; }

    [StringLength(26)]
    public string? remark { get; set; }
}
