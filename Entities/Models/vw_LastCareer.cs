using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_LastCareer
{
    [StringLength(50)]
    public string person { get; set; } = null!;

    [StringLength(50)]
    public string lastQualificationLevelCode { get; set; } = null!;

    [StringLength(50)]
    public string lastQualificationLevelDesc { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime lastQualificationDate { get; set; }

    [StringLength(50)]
    public string lastQualificationInstituteCode { get; set; } = null!;

    public string lastQualificationInstituteName { get; set; } = null!;

    [StringLength(50)]
    public string lastQualificationFieldCode { get; set; } = null!;

    [StringLength(50)]
    public string lastQualificationFieldDesc { get; set; } = null!;
}
