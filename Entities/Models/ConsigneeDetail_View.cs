using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class ConsigneeDetail_View
{
    public long? NID { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string DGroup { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(50)]
    public string DKey { get; set; } = null!;

    [StringLength(50)]
    public string? DValue { get; set; }
}
