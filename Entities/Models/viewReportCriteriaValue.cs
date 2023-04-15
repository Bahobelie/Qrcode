using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class viewReportCriteriaValue
{
    [StringLength(26)]
    public string? artCode { get; set; }

    [StringLength(40)]
    public string? artName { get; set; }

    [StringLength(15)]
    public string? artUOM { get; set; }

    [StringLength(26)]
    public string? devCode { get; set; }

    [StringLength(40)]
    public string? deviceValue { get; set; }

    [StringLength(100)]
    public string? devRemark { get; set; }

    [StringLength(26)]
    public string? orgCode { get; set; }

    [StringLength(50)]
    public string? tradeName { get; set; }

    public int? orgType { get; set; }

    [StringLength(26)]
    public string? perCode { get; set; }

    public int? perType { get; set; }

    [StringLength(62)]
    public string? fullName { get; set; }

    [StringLength(26)]
    public string? perNationality { get; set; }

    [StringLength(26)]
    public string? prefCode { get; set; }

    [StringLength(50)]
    public string? prefDescription { get; set; }

    [StringLength(50)]
    public string? prefCategory { get; set; }

    public int? gslCode { get; set; }

    [StringLength(50)]
    public string? gslDescription { get; set; }
}
