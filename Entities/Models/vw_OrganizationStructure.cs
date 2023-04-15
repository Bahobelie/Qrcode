using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_OrganizationStructure
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? parentId { get; set; }

    [StringLength(50)]
    public string description { get; set; } = null!;

    [StringLength(26)]
    public string PersonCode { get; set; } = null!;

    public string FullName { get; set; } = null!;

    [StringLength(20)]
    public string firstName { get; set; } = null!;

    [StringLength(20)]
    public string middleName { get; set; } = null!;

    [StringLength(20)]
    public string lastName { get; set; } = null!;

    [StringLength(26)]
    public string gender { get; set; } = null!;

    [StringLength(26)]
    public string RelationCode { get; set; } = null!;

    [StringLength(26)]
    public string relationType { get; set; } = null!;
}
