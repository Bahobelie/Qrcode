using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_countryAndCity
{
    [StringLength(100)]
    public string name { get; set; } = null!;

    [StringLength(100)]
    public string politicalName { get; set; } = null!;

    [StringLength(26)]
    public string continent { get; set; } = null!;

    [StringLength(50)]
    public string nationality { get; set; } = null!;

    [StringLength(5)]
    public string ICAOCountryCode { get; set; } = null!;

    [StringLength(26)]
    public string cityCode { get; set; } = null!;

    [StringLength(50)]
    public string cityName { get; set; } = null!;

    [StringLength(50)]
    public string? alternativeName { get; set; }

    [StringLength(26)]
    public string code { get; set; } = null!;
}
