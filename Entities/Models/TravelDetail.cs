using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("TravelDetail", Schema = "PMS")]
public partial class TravelDetail
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? voucher { get; set; }

    [StringLength(26)]
    public string? type { get; set; }

    [StringLength(26)]
    public string? actionRequired { get; set; }

    [StringLength(26)]
    public string? route { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? travelDate { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }
}
