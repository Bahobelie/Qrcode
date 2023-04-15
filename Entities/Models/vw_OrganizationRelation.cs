using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_OrganizationRelation
{
    [StringLength(26)]
    public string referringObject { get; set; } = null!;

    [StringLength(26)]
    public string referenceObject { get; set; } = null!;

    [StringLength(62)]
    public string personName { get; set; } = null!;

    [StringLength(26)]
    public string relationType { get; set; } = null!;

    public string relationTypeDesc { get; set; } = null!;
}
