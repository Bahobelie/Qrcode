using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class ChargableRegistrationView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? consignee { get; set; }

    [StringLength(50)]
    public string? room { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? deptDate { get; set; }

    [Column(TypeName = "date")]
    public DateTime? Date { get; set; }

    [StringLength(26)]
    public string? companyCode { get; set; }

    public string GuestName { get; set; } = null!;

    public string? idNumber { get; set; }

    public string? tradeName { get; set; }

    [StringLength(26)]
    public string? OrganizationUnitDefinition { get; set; }
}
