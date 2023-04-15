using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_pictureAttachment
{
    public Guid id { get; set; }

    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(26)]
    public string catagory { get; set; } = null!;

    [StringLength(100)]
    public string? description { get; set; }

    [StringLength(256)]
    public string url { get; set; } = null!;

    public byte[]? file { get; set; }

    [StringLength(26)]
    public string type { get; set; } = null!;

    public byte? index { get; set; }

    [StringLength(4000)]
    public string? remark { get; set; }
}
