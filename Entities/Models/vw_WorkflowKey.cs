using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_WorkflowKey
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? reference { get; set; }

    public string description { get; set; } = null!;

    public byte Index { get; set; }

    public bool hasIssuingEffect { get; set; }

    public bool isManual { get; set; }

    public bool? sequence { get; set; }

    [StringLength(26)]
    public string? color { get; set; }

    [StringLength(50)]
    public string objectStateDefinition { get; set; } = null!;

    public bool? needsPassCode { get; set; }
}
