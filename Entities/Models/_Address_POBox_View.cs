using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class _Address_POBox_View
{
    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(26)]
    public string preference { get; set; } = null!;

    [StringLength(100)]
    public string description { get; set; } = null!;

    public string POBox { get; set; } = null!;
}
