using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_GuestComment
{
    [StringLength(26)]
    public string? voucherCode { get; set; }

    [StringLength(26)]
    public string? consignee { get; set; }

    public string? name { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? IssuedDate { get; set; }

    [StringLength(26)]
    public string? evaluationVoucher { get; set; }

    [StringLength(26)]
    public string? evaluationSheet { get; set; }

    [StringLength(50)]
    public string? question { get; set; }

    [StringLength(50)]
    public string? questionType { get; set; }

    [StringLength(50)]
    public string? questionDesc { get; set; }

    [StringLength(50)]
    public string? answer { get; set; }

    [StringLength(50)]
    public string? answerDesc { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }
}
