using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_JobCardActivityDetail
{
    [StringLength(26)]
    public string lineitemCode { get; set; } = null!;

    [StringLength(26)]
    public string voucherCode { get; set; } = null!;

    [StringLength(26)]
    public string articleCode { get; set; } = null!;

    public string articleName { get; set; } = null!;

    [StringLength(51)]
    [Unicode(false)]
    public string standardTime { get; set; } = null!;

    [StringLength(11)]
    [Unicode(false)]
    public string ItemStatus { get; set; } = null!;
}
