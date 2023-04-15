using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_Sales_by_Timestamp
{
    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Date { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? time { get; set; }
}
