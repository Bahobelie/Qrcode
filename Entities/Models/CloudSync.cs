using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("CloudSync", Schema = "common")]
public partial class CloudSync
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
    public string organizationUnitDefinition { get; set; } = null!;

    public int status { get; set; }

    public int? tryCount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? uploadTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? downloadTimeStamp { get; set; }

    public string? remark { get; set; }
}
