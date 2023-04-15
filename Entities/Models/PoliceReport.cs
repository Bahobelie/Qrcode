using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("PoliceReport", Schema = "common")]
public partial class PoliceReport
{
    [Key]
    public int Code { get; set; }

    [Unicode(false)]
    public string Hotel { get; set; } = null!;

    [Unicode(false)]
    public string Room { get; set; } = null!;

    [Unicode(false)]
    public string? Company { get; set; }

    [Unicode(false)]
    public string GuestName { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? Gender { get; set; }

    [Unicode(false)]
    public string Nationality { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DoB { get; set; }

    [Unicode(false)]
    public string IDType { get; set; } = null!;

    [Unicode(false)]
    public string IDNumber { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ArrivalDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DepartureDate { get; set; }

    [Unicode(false)]
    public string? PurposeOfTravel { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ReportDate { get; set; }

    [Unicode(false)]
    public string RegisteredBy { get; set; } = null!;

    public int Pax { get; set; }

    [Unicode(false)]
    public string? FileName { get; set; }

    [Unicode(false)]
    public string? Remark { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedAt { get; set; }
}
