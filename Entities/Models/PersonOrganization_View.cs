using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class PersonOrganization_View
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(50)]
    public string firstName { get; set; } = null!;

    [StringLength(50)]
    public string? middleName { get; set; }

    [StringLength(20)]
    public string? lastName { get; set; }

    [StringLength(62)]
    public string Name { get; set; } = null!;

    public bool isActive { get; set; }

    [StringLength(26)]
    public string preference { get; set; } = null!;

    public int type { get; set; }

    [StringLength(20)]
    public string? idNumber { get; set; }

    [StringLength(26)]
    public string? identification_Type { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string Component { get; set; } = null!;

    [StringLength(50)]
    public string GslDescription { get; set; } = null!;
}
