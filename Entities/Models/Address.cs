using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Address", Schema = "common")]
[Index("code", Name = "IX_Address", IsUnique = true)]
[Index("preference", "reference", Name = "_dta_index_Address_5_608317527__K4_K3_5")]
public partial class Address
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    /// <summary>
    /// Can Be:Organization (common),Person (common),Store (common)
    /// </summary>
    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(26)]
    public string preference { get; set; } = null!;

    public string value { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("preference")]
    [InverseProperty("Addresses")]
    public virtual Preference preferenceNavigation { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("Addresses")]
    public virtual Person reference1 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("Addresses")]
    public virtual Organization referenceNavigation { get; set; } = null!;
}
