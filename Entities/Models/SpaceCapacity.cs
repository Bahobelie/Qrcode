using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("SpaceCapacity", Schema = "cnetEvent")]
public partial class SpaceCapacity
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string space { get; set; } = null!;

    [StringLength(26)]
    public string? spaceArrangment { get; set; }

    public int? capacity { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("spaceArrangment")]
    [InverseProperty("SpaceCapacities")]
    public virtual Lookup? spaceArrangmentNavigation { get; set; }

    [ForeignKey("space")]
    [InverseProperty("SpaceCapacities")]
    public virtual Space spaceNavigation { get; set; } = null!;
}
