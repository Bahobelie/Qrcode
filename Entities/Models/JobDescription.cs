using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("JobDescription", Schema = "hrms")]
public partial class JobDescription
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(50)]
    public string code { get; set; } = null!;

    [StringLength(50)]
    public string orgUnitDefn { get; set; } = null!;

    public int index { get; set; }

    [StringLength(50)]
    public string category { get; set; } = null!;

    public string description { get; set; } = null!;

    [StringLength(50)]
    public string status { get; set; } = null!;

    [StringLength(30)]
    public string? remark { get; set; }
}
