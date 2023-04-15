using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("HKValue", Schema = "PMS")]
public partial class HKValue
{
    public Guid? id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? component { get; set; }

    [StringLength(26)]
    public string? reference { get; set; }

    [StringLength(26)]
    public string? attribute { get; set; }

    [StringLength(26)]
    public string? value { get; set; }

    [StringLength(26)]
    public string? remark { get; set; }
}
