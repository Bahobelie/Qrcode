using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_LastActivityWithObjectState
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(26)]
    public string activitiyDefinition { get; set; } = null!;

    [StringLength(26)]
    public string objectStateDefinition { get; set; } = null!;

    [StringLength(50)]
    public string objectStateDefnDesc { get; set; } = null!;
}
