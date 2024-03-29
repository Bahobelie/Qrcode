﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_OrgPrefNoCatagory
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(50)]
    public string tradeName { get; set; } = null!;

    [StringLength(26)]
    public string? PreferanceCode { get; set; }

    [StringLength(26)]
    public string? orgPreferanceCode { get; set; }
}
