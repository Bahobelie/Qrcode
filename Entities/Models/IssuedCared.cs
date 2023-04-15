using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("IssuedCared", Schema = "common")]
public partial class IssuedCared
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string card { get; set; } = null!;

    [StringLength(26)]
    public string component { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    public int? PIN { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("card")]
    [InverseProperty("IssuedCareds")]
    public virtual Card cardNavigation { get; set; } = null!;

    [ForeignKey("component")]
    [InverseProperty("IssuedCareds")]
    public virtual Organization componentNavigation { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("IssuedCareds")]
    public virtual Person referenceNavigation { get; set; } = null!;
}
