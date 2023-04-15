using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("RequriedGSL", Schema = "common")]
[Index("code", Name = "IX_RequriedGSL", IsUnique = true)]
[Index("voucherDefn", Name = "Required_GSL_Vdef_Index")]
public partial class RequriedGSL
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int voucherDefn { get; set; }

    [StringLength(26)]
    public string type { get; set; } = null!;

    public byte Index { get; set; }

    [StringLength(50)]
    public string description { get; set; } = null!;

    public bool IsMandatory { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("requiredGSLNavigation")]
    public virtual ICollection<OtherConsignee> OtherConsignees { get; } = new List<OtherConsignee>();

    [InverseProperty("requiredGSLNavigation")]
    public virtual ICollection<RequiredGSLDetail> RequiredGSLDetails { get; } = new List<RequiredGSLDetail>();

    [ForeignKey("type")]
    [InverseProperty("RequriedGSLs")]
    public virtual Lookup typeNavigation { get; set; } = null!;

    [ForeignKey("voucherDefn")]
    [InverseProperty("RequriedGSLs")]
    public virtual VoucherDefinition voucherDefnNavigation { get; set; } = null!;
}
