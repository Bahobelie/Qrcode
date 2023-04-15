using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_RegistrationDetailWithMonth
{
    [StringLength(26)]
    public string voucher { get; set; } = null!;

    public int? month { get; set; }

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    public int? year { get; set; }

    [StringLength(26)]
    public string? organizationUnitDefinition { get; set; }
}
