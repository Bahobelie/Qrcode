﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_CnetComponentWithLicence
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string compCode { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(60)]
    public string licenseCode { get; set; } = null!;
}
