using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_PoliceView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? arrivalDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? departureDate { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [StringLength(50)]
    public string? idType { get; set; }

    public string idNumber { get; set; } = null!;

    [StringLength(26)]
    public string personCode { get; set; } = null!;

    public string? name { get; set; }

    public string gender { get; set; } = null!;

    [StringLength(50)]
    public string nationality { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? DOB { get; set; }

    public string? title { get; set; }

    [Column(TypeName = "date")]
    public DateTime? Date { get; set; }

    [StringLength(50)]
    public string roomType { get; set; } = null!;

    [StringLength(26)]
    public string roomcode { get; set; } = null!;

    [StringLength(50)]
    public string? room { get; set; }

    public int? adult { get; set; }

    public int? child { get; set; }
}
