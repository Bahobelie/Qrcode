using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_AttendanceLog
{
    [StringLength(26)]
    public string attendanceCode { get; set; } = null!;

    [StringLength(26)]
    public string BioID { get; set; } = null!;

    public string machineId { get; set; } = null!;

    public bool isSynchronized { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Time { get; set; }

    [StringLength(26)]
    public string code { get; set; } = null!;

    public string? EmployeeName { get; set; }

    [StringLength(26)]
    public string branchCode { get; set; } = null!;

    [StringLength(50)]
    public string branchDescription { get; set; } = null!;

    [StringLength(26)]
    public string deptCode { get; set; } = null!;

    [StringLength(50)]
    public string department { get; set; } = null!;
}
