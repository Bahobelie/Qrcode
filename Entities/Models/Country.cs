using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Country", Schema = "common")]
[Index("code", Name = "IX_Country", IsUnique = true)]
public partial class Country
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(100)]
    public string name { get; set; } = null!;

    [StringLength(100)]
    public string politicalName { get; set; } = null!;

    [StringLength(26)]
    public string continent { get; set; } = null!;

    [StringLength(5)]
    public string telephoneCode { get; set; } = null!;

    [StringLength(50)]
    public string? timeZone { get; set; }

    [StringLength(50)]
    public string nationality { get; set; } = null!;

    [StringLength(5)]
    public string ICAOCountryCode { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("countryNavigation")]
    public virtual ICollection<Currency> Currencies { get; } = new List<Currency>();
}
