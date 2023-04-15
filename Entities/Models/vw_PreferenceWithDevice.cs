using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_PreferenceWithDevice
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string article { get; set; } = null!;

    public string name { get; set; } = null!;

    [StringLength(100)]
    public string category { get; set; } = null!;

    [StringLength(26)]
    public string? parentcode { get; set; }

    [StringLength(26)]
    public string connectionType { get; set; } = null!;

    public string Connection { get; set; } = null!;

    [StringLength(26)]
    public string preference { get; set; } = null!;

    [StringLength(26)]
    public string? parentpreference { get; set; }

    [StringLength(100)]
    public string model { get; set; } = null!;

    public bool isActive { get; set; }

    [StringLength(40)]
    public string? deviceValue { get; set; }

    [StringLength(35)]
    public string? ip { get; set; }

    [StringLength(5)]
    public string? port { get; set; }

    [StringLength(30)]
    public string? mac { get; set; }

    [StringLength(26)]
    public string? baudRate { get; set; }

    [StringLength(5)]
    public string? serialPort { get; set; }

    [StringLength(26)]
    public string? parity { get; set; }

    [StringLength(26)]
    public string organizationUnitDefinition { get; set; } = null!;

    [StringLength(26)]
    public string referringObject { get; set; } = null!;
}
