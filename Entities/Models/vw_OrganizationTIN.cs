using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_OrganizationTIN
{
    [StringLength(20)]
    public string idNumber { get; set; } = null!;

    [StringLength(26)]
    public string code { get; set; } = null!;
}
