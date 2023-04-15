using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class Address_View
{
    public Guid id { get; set; }

    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(26)]
    public string preference { get; set; } = null!;

    public string value { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [StringLength(50)]
    public string preference_description { get; set; } = null!;

    [StringLength(50)]
    public string address_description { get; set; } = null!;
}
