using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class Space_View
{
    public Guid id { get; set; }

    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(200)]
    public string Description { get; set; } = null!;

    [StringLength(26)]
    public string? OrganizationUnitDef { get; set; }

    [StringLength(26)]
    public string? Lookuptype { get; set; }

    public string? type { get; set; }

    [StringLength(200)]
    public string? p_desc { get; set; }

    public string? CatagoryDescription { get; set; }

    [StringLength(26)]
    public string? Catagory { get; set; }

    [StringLength(26)]
    public string? Parent { get; set; }

    [StringLength(50)]
    public string? Remark { get; set; }

    [StringLength(26)]
    public string? RT_Code { get; set; }

    public int? maxOccupancy { get; set; }

    public string? shape { get; set; }

    [StringLength(26)]
    public string? grade { get; set; }

    [StringLength(50)]
    public string? RestaurantRemark { get; set; }

    [StringLength(26)]
    public string? spaceArrangment { get; set; }

    public int? capacity { get; set; }
}
