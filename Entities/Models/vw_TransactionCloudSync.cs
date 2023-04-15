using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_TransactionCloudSync
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string destinationCode { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    public int status { get; set; }

    public int? tryCount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? uploadTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? downloadTimeStamp { get; set; }

    public int voucherDefinition { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [StringLength(26)]
    public string? period { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    public string? consignee { get; set; }

    [StringLength(100)]
    public string? name { get; set; }

    [StringLength(50)]
    public string destination { get; set; } = null!;

    [StringLength(50)]
    public string source { get; set; } = null!;

    [StringLength(26)]
    public string? sourceCode { get; set; }

    public int? lineItemCount { get; set; }

    [StringLength(30)]
    public string? userName { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }
}
