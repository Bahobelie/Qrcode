using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_EquipmentDatum
{
    [StringLength(26)]
    public string voucherCode { get; set; } = null!;

    [StringLength(26)]
    public string? plateNumber { get; set; }

    [StringLength(26)]
    public string? consignee { get; set; }

    public string? consigneeName { get; set; }

    [StringLength(26)]
    public string? Mark { get; set; }

    public string? engineNo { get; set; }

    public string? chasisNo { get; set; }

    public string? modelNo { get; set; }
}
