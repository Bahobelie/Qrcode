using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class Location_View
{
    public Guid Id { get; set; }

    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(26)]
    public string? SpaceId { get; set; }

    public int? gslType { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [StringLength(26)]
    public string? Catagory { get; set; }

    [StringLength(200)]
    public string space_description { get; set; } = null!;

    [StringLength(50)]
    public string organizationUnitDefinition_description { get; set; } = null!;

    [StringLength(26)]
    public string organizationUnitDefinition_code { get; set; } = null!;
}
