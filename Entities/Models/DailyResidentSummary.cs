using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("DailyResidentSummary", Schema = "PMS")]
public partial class DailyResidentSummary
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [Column(TypeName = "date")]
    public DateTime date { get; set; }

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(26)]
    public string? reference { get; set; }

    [StringLength(26)]
    public string rateCodeHeader { get; set; } = null!;

    [StringLength(26)]
    public string guest { get; set; } = null!;

    [StringLength(26)]
    public string? company { get; set; }

    [StringLength(26)]
    public string? consigneecode { get; set; }

    [StringLength(26)]
    public string room { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal roomRevenue { get; set; }

    [Column(TypeName = "money")]
    public decimal package { get; set; }

    [Column(TypeName = "money")]
    public decimal serviceCharge { get; set; }

    [Column(TypeName = "money")]
    public decimal vat { get; set; }

    [Column(TypeName = "money")]
    public decimal roomTotal { get; set; }

    [Column(TypeName = "money")]
    public decimal posCharge { get; set; }

    [Column(TypeName = "money")]
    public decimal todayTotal { get; set; }

    [Column(TypeName = "money")]
    public decimal bbf { get; set; }

    [Column(TypeName = "money")]
    public decimal toDateTotal { get; set; }

    [Column(TypeName = "money")]
    public decimal discount { get; set; }

    [Column(TypeName = "money")]
    public decimal payment { get; set; }

    [Column(TypeName = "money")]
    public decimal paidout { get; set; }

    [Column(TypeName = "money")]
    public decimal bcf { get; set; }

    [Column(TypeName = "money")]
    public decimal outstanding { get; set; }

    [StringLength(50)]
    public string? remark { get; set; }

    [StringLength(26)]
    public string? organizationUnitDefinition { get; set; }
}
