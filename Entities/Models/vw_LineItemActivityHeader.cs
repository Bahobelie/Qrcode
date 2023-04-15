using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_LineItemActivityHeader
{
    [StringLength(26)]
    public string voucherCode { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string? consigneeCode { get; set; }

    public string? consigneeName { get; set; }

    [StringLength(56)]
    [Unicode(false)]
    public string? TIN { get; set; }

    [StringLength(56)]
    [Unicode(false)]
    public string? telephone { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    public bool IsIssued { get; set; }

    public bool IsVoid { get; set; }

    [StringLength(26)]
    public string? vouchExtOne { get; set; }

    [StringLength(50)]
    public string? vouchExtDescOne { get; set; }

    [StringLength(26)]
    public string? vouchExtNumberOne { get; set; }

    [StringLength(26)]
    public string? vouchExtSecond { get; set; }

    [StringLength(50)]
    public string? vouchExtDescSecond { get; set; }

    [StringLength(26)]
    public string? vouchExtNumberSecond { get; set; }

    [StringLength(26)]
    public string? vouchExtThird { get; set; }

    [StringLength(50)]
    public string? vouchExtDescThird { get; set; }

    [StringLength(26)]
    public string? vouchExtNumberThird { get; set; }

    [StringLength(26)]
    public string? vouchExtFourth { get; set; }

    [StringLength(50)]
    public string? vouchExtDescFourth { get; set; }

    [StringLength(26)]
    public string? vouchExtNumberFourth { get; set; }

    public int totalStandartTime { get; set; }

    [StringLength(56)]
    [Unicode(false)]
    public string? TotalTime { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string JobStatus { get; set; } = null!;
}
