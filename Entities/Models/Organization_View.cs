using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class Organization_View
{
    public Guid id { get; set; }

    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(50)]
    public string tradeName { get; set; } = null!;

    [StringLength(50)]
    public string? brandName { get; set; }

    [StringLength(26)]
    public string businessType { get; set; } = null!;

    public int type { get; set; }

    [StringLength(26)]
    public string preference { get; set; } = null!;

    public bool isActive { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? isActive_D { get; set; }

    [StringLength(50)]
    public string type_description { get; set; } = null!;

    [StringLength(50)]
    public string pref_description { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? Registration_Date { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string AssignedPerson { get; set; } = null!;

    [StringLength(50)]
    public string BusinessType_D { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string Tax { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string Discount { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string CreditLimit { get; set; } = null!;

    [StringLength(30)]
    public string? User { get; set; }

    [StringLength(20)]
    public string? VatNumber { get; set; }

    [StringLength(20)]
    public string? LicenseNumber { get; set; }

    [StringLength(20)]
    public string? TinNumber { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? Object_State_Colour { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string Object_State_Font { get; set; } = null!;
}
