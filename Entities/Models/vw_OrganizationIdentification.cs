using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_OrganizationIdentification
{
    public Guid id { get; set; }

    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string organizationCode { get; set; } = null!;

    [StringLength(50)]
    public string tradeName { get; set; } = null!;

    [StringLength(26)]
    public string typeCode { get; set; } = null!;

    [StringLength(50)]
    public string type { get; set; } = null!;

    [StringLength(50)]
    public string? description { get; set; }

    [StringLength(20)]
    public string idNumber { get; set; } = null!;
}
