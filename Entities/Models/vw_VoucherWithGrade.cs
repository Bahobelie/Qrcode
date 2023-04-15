using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_VoucherWithGrade
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    [StringLength(26)]
    public string? StudentId { get; set; }

    [StringLength(64)]
    public string? StudentName { get; set; }

    [StringLength(26)]
    public string? fsNo { get; set; }

    public string? name { get; set; }

    [StringLength(26)]
    public string? artpreference { get; set; }

    [StringLength(26)]
    public string? referenceObject { get; set; }

    [StringLength(26)]
    public string? referringObject { get; set; }

    [StringLength(26)]
    public string? preferenceCode { get; set; }

    [StringLength(50)]
    public string? description { get; set; }

    [StringLength(50)]
    public string? Prefrancedescription { get; set; }

    [StringLength(26)]
    public string? Prefcode { get; set; }
}
