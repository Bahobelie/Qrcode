using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_LineItemJournalDetailDatum
{
    [StringLength(26)]
    public string JournalDetailCode { get; set; } = null!;

    [StringLength(26)]
    public string Referenced { get; set; } = null!;

    [StringLength(26)]
    public string Article { get; set; } = null!;

    [StringLength(26)]
    public string Account { get; set; } = null!;

    [Column("Account Description")]
    [StringLength(50)]
    public string Account_Description { get; set; } = null!;

    [StringLength(26)]
    public string ControlAccount { get; set; } = null!;

    [StringLength(26)]
    public string JournalVoucherNumber { get; set; } = null!;
}
