using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_VoucherUserNameDetailView
{
    [StringLength(26)]
    public string userCode { get; set; } = null!;

    [StringLength(30)]
    public string userName { get; set; } = null!;

    [StringLength(50)]
    public string? preference { get; set; }

    [StringLength(50)]
    public string? gslType { get; set; }

    [StringLength(26)]
    public string personCode { get; set; } = null!;

    [StringLength(115)]
    public string? fullName { get; set; }

    [StringLength(50)]
    public string? Title { get; set; }

    [StringLength(20)]
    public string firstName { get; set; } = null!;

    [StringLength(20)]
    public string? middleName { get; set; }

    [StringLength(20)]
    public string? lastName { get; set; }

    [StringLength(100)]
    public string? Country { get; set; }

    [StringLength(50)]
    public string? nationality { get; set; }

    [StringLength(50)]
    public string? gender { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DOB { get; set; }

    public bool isActive { get; set; }
}
