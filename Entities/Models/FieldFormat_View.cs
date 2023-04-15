using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class FieldFormat_View
{
    public Guid id { get; set; }

    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(100)]
    public string objectComponent { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(100)]
    public string? viewComponent { get; set; }

    [StringLength(100)]
    public string fieldComponent { get; set; } = null!;

    public byte index { get; set; }

    public int? width { get; set; }

    [StringLength(26)]
    public string? font { get; set; }

    [StringLength(26)]
    public string? color { get; set; }

    [StringLength(40)]
    public string? caption { get; set; }

    public bool isRequired { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [StringLength(50)]
    public string? font_description { get; set; }

    public byte? font_size { get; set; }

    [StringLength(50)]
    public string? font_color { get; set; }

    [StringLength(50)]
    public string? font_face { get; set; }
}
