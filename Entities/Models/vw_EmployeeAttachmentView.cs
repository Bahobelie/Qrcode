using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_EmployeeAttachmentView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(256)]
    public string url { get; set; } = null!;
}
