using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("RoomFeature", Schema = "PMS")]
public partial class RoomFeature
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string component { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(26)]
    public string feature { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("component")]
    [InverseProperty("RoomFeatures")]
    public virtual CNETComponent componentNavigation { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("RoomFeatures")]
    public virtual RoomType referenceNavigation { get; set; } = null!;
}
