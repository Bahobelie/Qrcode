using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("RequiredGSLDetail", Schema = "common")]
[Index("code", Name = "IX_RequiredGSLDetail", IsUnique = true)]
[Index("gslType", Name = "RequiredGSL_GSL_type_Index")]
public partial class RequiredGSLDetail
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string requiredGSL { get; set; } = null!;

    public int? gslType { get; set; }

    [StringLength(26)]
    public string objectState { get; set; } = null!;

    public byte Index { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("gslType")]
    [InverseProperty("RequiredGSLDetails")]
    public virtual GSLTypeList? gslTypeNavigation { get; set; }

    [ForeignKey("requiredGSL")]
    [InverseProperty("RequiredGSLDetails")]
    public virtual RequriedGSL requiredGSLNavigation { get; set; } = null!;
}
