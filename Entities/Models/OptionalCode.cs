using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("OptionalCode", Schema = "common")]
[Index("code", Name = "IX_OptionalCode", IsUnique = true)]
public partial class OptionalCode
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string article { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [StringLength(50)]
    public string codeValue { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("article")]
    [InverseProperty("OptionalCodes")]
    public virtual Organization article1 { get; set; } = null!;

    [ForeignKey("article")]
    [InverseProperty("OptionalCodes")]
    public virtual Person article2 { get; set; } = null!;

    [ForeignKey("article")]
    [InverseProperty("OptionalCodes")]
    public virtual Article articleNavigation { get; set; } = null!;
}
