using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class Organization_Region_Town_View
{
    public int code { get; set; }

    [Unicode(false)]
    public string Hotel { get; set; } = null!;

    public string value { get; set; } = null!;

    [StringLength(26)]
    public string preference { get; set; } = null!;
}
