using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_SelectAllMoviesView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string scheduleHeader { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [StringLength(26)]
    public string moviecode { get; set; } = null!;

    [StringLength(50)]
    public string moviename { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime date { get; set; }

    [StringLength(26)]
    public string? dayMonth { get; set; }

    [StringLength(26)]
    public string? startTime { get; set; }

    [StringLength(26)]
    public string? endTime { get; set; }

    [StringLength(200)]
    public string cinemahall { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal pricevalue { get; set; }

    [StringLength(26)]
    public string spacecode { get; set; } = null!;

    [StringLength(26)]
    public string mediacode { get; set; } = null!;

    [StringLength(26)]
    public string Schdetailcode { get; set; } = null!;

    [StringLength(26)]
    public string? article { get; set; }

    public string? remark { get; set; }

    [StringLength(100)]
    public string? AttachementDesc { get; set; }

    public string plot { get; set; } = null!;

    [StringLength(256)]
    public string? url { get; set; }

    [StringLength(50)]
    public string branchName { get; set; } = null!;

    public string? brandName { get; set; }

    public string tradeName { get; set; } = null!;

    [StringLength(26)]
    public string orgUnit { get; set; } = null!;

    [StringLength(26)]
    public string? orgUnitDef { get; set; }

    [Column(TypeName = "date")]
    public DateTime releaseDate { get; set; }

    [StringLength(26)]
    public string? Parent { get; set; }
}
