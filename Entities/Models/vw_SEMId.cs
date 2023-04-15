using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_SEMId
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(20)]
    public string semID { get; set; } = null!;

    public long? r { get; set; }
}
