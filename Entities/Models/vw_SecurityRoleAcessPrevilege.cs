using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_SecurityRoleAcessPrevilege
{
    [StringLength(26)]
    public string? parentId { get; set; }

    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(50)]
    public string RDescription { get; set; } = null!;

    [StringLength(26)]
    public string component { get; set; } = null!;

    [StringLength(50)]
    public string VisualComponentDescription { get; set; } = null!;

    [StringLength(26)]
    public string visualComponent { get; set; } = null!;

    [StringLength(50)]
    public string subsystemComponentDescription { get; set; } = null!;

    [StringLength(26)]
    public string subsystemComponent { get; set; } = null!;

    [StringLength(100)]
    public string FDescription { get; set; } = null!;

    [StringLength(50)]
    public string function { get; set; } = null!;

    [StringLength(50)]
    public string FunctionDescription { get; set; } = null!;

    public string category { get; set; } = null!;
}
