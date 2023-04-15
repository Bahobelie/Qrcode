using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_IndustryInvolvedOrganization
{
    [StringLength(26)]
    public string OrganizationCode { get; set; } = null!;

    [StringLength(26)]
    public string industryCode { get; set; } = null!;

    [StringLength(26)]
    public string? involvementCode { get; set; }

    [StringLength(50)]
    public string IndustryDescription { get; set; } = null!;

    [StringLength(50)]
    public string involvementDescription { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }
}
