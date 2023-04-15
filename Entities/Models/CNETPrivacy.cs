using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("CNETPrivacy", Schema = "common")]
public partial class CNETPrivacy
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string PrivacyRule { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("PrivacyRule")]
    [InverseProperty("CNETPrivacies")]
    public virtual Lookup PrivacyRuleNavigation { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("CNETPrivacies")]
    public virtual Person reference1 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("CNETPrivacies")]
    public virtual Organization referenceNavigation { get; set; } = null!;
}
