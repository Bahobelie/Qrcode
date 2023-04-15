using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_GSLTaxList
{
    [StringLength(26)]
    public string reference { get; set; } = null!;

    public string? GSLTaxCodes { get; set; }

    public string? GSLTaxDescs { get; set; }
}
