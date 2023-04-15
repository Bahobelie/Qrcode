using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("AvailabilityCalendar", Schema = "PMS")]
public partial class AvailabilityCalendar
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string component { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [Column(TypeName = "date")]
    public DateTime date { get; set; }

    public int year { get; set; }

    public int month { get; set; }

    public int day { get; set; }

    public int availabilityStatus { get; set; }

    public int restrictedBy { get; set; }

    [StringLength(50)]
    public string? remark { get; set; }
}
