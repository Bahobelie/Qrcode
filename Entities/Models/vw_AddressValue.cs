using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_AddressValue
{
    [StringLength(26)]
    public string reference { get; set; } = null!;

    public string? addressValue { get; set; }

    public string? addressValue1 { get; set; }
}
