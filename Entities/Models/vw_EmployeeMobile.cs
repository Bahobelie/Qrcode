using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_EmployeeMobile
{
    public string Address { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;
}
