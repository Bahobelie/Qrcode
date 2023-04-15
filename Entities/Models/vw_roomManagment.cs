using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_roomManagment
{
    [StringLength(26)]
    public string roomDetailCode { get; set; } = null!;

    [StringLength(50)]
    public string? roomNo { get; set; }

    [StringLength(50)]
    public string RoomType { get; set; } = null!;

    public string rmstatus { get; set; } = null!;

    [StringLength(200)]
    public string Floor { get; set; } = null!;

    [StringLength(26)]
    public string roomStatusCode { get; set; } = null!;

    [StringLength(26)]
    public string? color { get; set; }
}
