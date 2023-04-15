using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class ListOfWaiterView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(20)]
    public string firstName { get; set; } = null!;

    [StringLength(20)]
    public string? middleName { get; set; }

    [StringLength(20)]
    public string? lastName { get; set; }

    public byte[]? picture { get; set; }

    [StringLength(26)]
    public string? fileType { get; set; }

    [StringLength(26)]
    public string gender { get; set; } = null!;
}
