using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class ClearanceEmployeeView
{
    [StringLength(26)]
    public string? code { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? IssuedDate { get; set; }

    [StringLength(62)]
    public string? fullName { get; set; }

    [StringLength(20)]
    public string? firstName { get; set; }

    [StringLength(20)]
    public string? middleName { get; set; }

    [StringLength(20)]
    public string? lastName { get; set; }

    [StringLength(50)]
    public string? title { get; set; }

    [StringLength(50)]
    public string? department { get; set; }

    public int? referingDefn { get; set; }

    [StringLength(26)]
    public string? empCode { get; set; }

    public string? description { get; set; }

    public string? TerminationDate { get; set; }
}
