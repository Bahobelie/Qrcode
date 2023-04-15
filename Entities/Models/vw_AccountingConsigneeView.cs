using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_AccountingConsigneeView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(62)]
    public string? Name { get; set; }

    public bool isActive { get; set; }

    [StringLength(26)]
    public string? preference { get; set; }

    public int type { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string Component { get; set; } = null!;

    [StringLength(50)]
    public string GslDescription { get; set; } = null!;
}
