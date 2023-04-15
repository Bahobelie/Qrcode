using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("CNETLicense", Schema = "common")]
[Index("code", Name = "IX_License", IsUnique = true)]
public partial class CNETLicense
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(26)]
    public string? device { get; set; }

    [StringLength(60)]
    public string licenseCode { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }
}
