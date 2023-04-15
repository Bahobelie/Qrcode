using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("MultiOrganization", Schema = "common")]
public partial class MultiOrganization
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? component { get; set; }

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(26)]
    public string TIN { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("component")]
    [InverseProperty("MultiOrganizations")]
    public virtual CNETComponent? componentNavigation { get; set; }
}
