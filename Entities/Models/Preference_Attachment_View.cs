using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class Preference_Attachment_View
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(100)]
    public string description { get; set; } = null!;

    [StringLength(26)]
    public string? parent { get; set; }

    [StringLength(256)]
    public string? imageURL { get; set; }

    public byte index { get; set; }

    [StringLength(26)]
    public string? color { get; set; }
}
