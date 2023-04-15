using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_ACLogView
{
    [StringLength(26)]
    public string ACLogCode { get; set; } = null!;

    [StringLength(50)]
    public string reader { get; set; } = null!;

    public string? description { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime timeStamp { get; set; }

    public bool isEntry { get; set; }

    public bool? isClosed { get; set; }

    public bool isGranted { get; set; }

    [StringLength(26)]
    public string cardCode { get; set; } = null!;

    [StringLength(26)]
    public string? cardType { get; set; }

    [StringLength(25)]
    public string? model { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? registrationDate { get; set; }

    [StringLength(26)]
    public string? status { get; set; }

    [StringLength(26)]
    public string? locationType { get; set; }

    [StringLength(26)]
    public string? reference { get; set; }

    [StringLength(64)]
    public string name { get; set; } = null!;

    [StringLength(26)]
    public string deviceCode { get; set; } = null!;

    [StringLength(26)]
    public string? spaceCode { get; set; }

    [StringLength(100)]
    public string? licensePlate { get; set; }

    [StringLength(200)]
    public string Facility { get; set; } = null!;

    public string? cardTypeDescription { get; set; }
}
