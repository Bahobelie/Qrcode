using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("GSLAcctRequirement", Schema = "common")]
[Index("gslTypeList", Name = "GSL_type_list_Index")]
[Index("code", Name = "IX_GSLAcctRequirement", IsUnique = true)]
public partial class GSLAcctRequirement
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string contAcct { get; set; } = null!;

    public int gslTypeList { get; set; }

    public bool isMandatory { get; set; }

    public bool restrictSelection { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("gslTypeList")]
    [InverseProperty("GSLAcctRequirements")]
    public virtual GSLTypeList gslTypeListNavigation { get; set; } = null!;
}
