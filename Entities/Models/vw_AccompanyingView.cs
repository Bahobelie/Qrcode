using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_AccompanyingView
{
    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(26)]
    public string requiredGSL { get; set; } = null!;

    [StringLength(26)]
    public string consignee { get; set; } = null!;

    [StringLength(50)]
    public string? TitleDescription { get; set; }

    [StringLength(20)]
    public string firstName { get; set; } = null!;

    [StringLength(20)]
    public string? middleName { get; set; }

    [StringLength(20)]
    public string? lastName { get; set; }

    [StringLength(64)]
    public string? name { get; set; }

    [StringLength(50)]
    public string? PersonGender { get; set; }

    [StringLength(50)]
    public string? nationalityName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DOB { get; set; }

    [StringLength(50)]
    public string? IdentficationDescription { get; set; }

    [StringLength(20)]
    public string? idNumber { get; set; }

    [StringLength(50)]
    public string? GslType { get; set; }
}
