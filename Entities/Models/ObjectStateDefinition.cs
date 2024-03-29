﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("ObjectStateDefinition", Schema = "common")]
[Index("code", Name = "IX_ObjectStateDefinition", IsUnique = true)]
public partial class ObjectStateDefinition
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [StringLength(26)]
    public string? color { get; set; }

    [StringLength(26)]
    public string? font { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("LastObjectStateNavigation")]
    public virtual ICollection<Voucher> Vouchers { get; } = new List<Voucher>();
}
