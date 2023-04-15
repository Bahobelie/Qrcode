using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class RequiredGSL_View
{
    [StringLength(26)]
    public string requiredGSl { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    public byte Index { get; set; }

    public bool IsMandatory { get; set; }

    [StringLength(26)]
    public string lookupType { get; set; } = null!;

    public int voucherDefn { get; set; }

    [StringLength(26)]
    public string detailCode { get; set; } = null!;

    public int? gslType { get; set; }

    [StringLength(26)]
    public string objectState { get; set; } = null!;

    [StringLength(50)]
    public string name { get; set; } = null!;
}
