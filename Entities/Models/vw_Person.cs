using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_Person
{
    [StringLength(26)]
    public string consignee { get; set; } = null!;

    public int type { get; set; }

    [StringLength(20)]
    public string firstName { get; set; } = null!;

    [StringLength(20)]
    public string? middleName { get; set; }

    [StringLength(20)]
    public string? lastName { get; set; }

    [StringLength(26)]
    public string? nationality { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DOB { get; set; }

    [StringLength(26)]
    public string? title { get; set; }

    [StringLength(26)]
    public string gender { get; set; } = null!;

    [StringLength(26)]
    public string? preference { get; set; }

    public bool isActive { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? isActive_D { get; set; }

    [StringLength(50)]
    public string type_description { get; set; } = null!;

    [StringLength(50)]
    public string? title_description { get; set; }

    [StringLength(100)]
    public string pref_description { get; set; } = null!;

    [StringLength(14)]
    [Unicode(false)]
    public string AssignedPerson { get; set; } = null!;

    [StringLength(12)]
    [Unicode(false)]
    public string BusinessType { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string Tax { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string Discount { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string CreditLimit { get; set; } = null!;

    [StringLength(20)]
    public string? VatNumber { get; set; }

    [StringLength(20)]
    public string? LicenseNumber { get; set; }

    [StringLength(20)]
    public string? Passport { get; set; }

    [StringLength(20)]
    public string? TinNumber { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? Object_State_Colour { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string Object_State_Font { get; set; } = null!;

    [StringLength(256)]
    public string? url { get; set; }

    [StringLength(26)]
    public string? lastPlavementVoucher { get; set; }

    [StringLength(50)]
    public string? ouDescription { get; set; }

    [StringLength(26)]
    public string? ouType { get; set; }
}
