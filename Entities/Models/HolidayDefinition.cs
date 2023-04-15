using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("HolidayDefinition", Schema = "common")]
public partial class HolidayDefinition
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [StringLength(26)]
    public string type { get; set; } = null!;

    public bool isFixed { get; set; }

    public bool willClose { get; set; }

    public int? alertBefore { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("holidayDfnNavigation")]
    public virtual ICollection<Holiday> Holidays { get; } = new List<Holiday>();

    [ForeignKey("type")]
    [InverseProperty("HolidayDefinitions")]
    public virtual Lookup typeNavigation { get; set; } = null!;
}
