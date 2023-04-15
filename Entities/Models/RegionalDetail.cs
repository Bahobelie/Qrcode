using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("RegionalDetail", Schema = "common")]
public partial class RegionalDetail
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string Code { get; set; } = null!;

    [StringLength(26)]
    public string Region { get; set; } = null!;

    [StringLength(26)]
    public string Country { get; set; } = null!;

    [StringLength(26)]
    public string Type { get; set; } = null!;

    [StringLength(100)]
    public string? Remark { get; set; }

    [ForeignKey("Region")]
    [InverseProperty("RegionalDetails")]
    public virtual Lookup RegionNavigation { get; set; } = null!;
}
