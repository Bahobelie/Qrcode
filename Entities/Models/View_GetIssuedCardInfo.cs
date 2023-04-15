using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class View_GetIssuedCardInfo
{
    [StringLength(26)]
    public string cardNo { get; set; } = null!;

    [StringLength(26)]
    public string cardType { get; set; } = null!;

    [StringLength(25)]
    public string? model { get; set; }

    public int? pin { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? registrationDate { get; set; }

    [StringLength(26)]
    public string? status { get; set; }

    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string component { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    public string? consignee { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }
}
