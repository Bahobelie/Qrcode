using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("PackagesToPost", Schema = "PMS")]
public partial class PackagesToPost
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string registrationDetail { get; set; } = null!;

    [StringLength(26)]
    public string? packageHeader { get; set; }

    [Column(TypeName = "money")]
    public decimal amount { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("packageHeader")]
    [InverseProperty("PackagesToPosts")]
    public virtual PackageHeader? packageHeaderNavigation { get; set; }

    [ForeignKey("registrationDetail")]
    [InverseProperty("PackagesToPosts")]
    public virtual RegistrationDetail registrationDetailNavigation { get; set; } = null!;
}
