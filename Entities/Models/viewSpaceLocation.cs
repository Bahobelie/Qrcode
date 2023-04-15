using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class viewSpaceLocation
{
    [StringLength(26)]
    public string spaceCode { get; set; } = null!;

    [StringLength(200)]
    public string spaceDescription { get; set; } = null!;

    [StringLength(26)]
    public string? OrganizationUnitDef { get; set; }

    [StringLength(50)]
    public string Store_Description { get; set; } = null!;

    [StringLength(26)]
    public string? Type { get; set; }

    [StringLength(26)]
    public string? Catagory { get; set; }

    [StringLength(26)]
    public string? Parent { get; set; }

    [StringLength(26)]
    public string locationCode { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(26)]
    public string? SpaceId { get; set; }

    public int? gslType { get; set; }
}
