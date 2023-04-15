using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_TerminatedEmployeeView
{
    [StringLength(26)]
    public string? terminationCode { get; set; }

    [StringLength(50)]
    public string? title { get; set; }

    [StringLength(62)]
    public string? fullName { get; set; }

    [StringLength(20)]
    public string? firstName { get; set; }

    [StringLength(20)]
    public string? middleName { get; set; }

    [StringLength(20)]
    public string? lastName { get; set; }

    [StringLength(50)]
    public string? department { get; set; }

    public int? referingDefn { get; set; }

    [StringLength(26)]
    public string? empCode { get; set; }

    public string? TerminationDate { get; set; }

    [StringLength(75)]
    public string? TerminationReasonType { get; set; }

    public string? Reason { get; set; }
}
