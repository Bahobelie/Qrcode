using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_IdentificationBioId
{
    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(20)]
    public string idNumber { get; set; } = null!;

    [StringLength(50)]
    public string? IDDesc { get; set; }

    [StringLength(26)]
    public string IdentficationType { get; set; } = null!;

    public string IDtypeDesc { get; set; } = null!;

    public long? r { get; set; }
}
